using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Capturer.Processor;
using System.IO;

namespace Capturer
{
    public partial class ExcelPadFrom : Form
    {
        private ExcelProcessor _currentExcelProcessor = null;
        private CapturerForm _capturer = null;
        private DataGridView _currentDataGridView = null;
        private AdvanceTabControl _tabControl1 = null;

        public ExcelPadFrom()
        {
            InitializeComponent();
        }

        private void ExcelPadFrom_Load(object sender, EventArgs e)
        {
            this._tabControl1 = new AdvanceTabControl();
            this._tabControl1.Dock = DockStyle.Fill;
            this._tabControl1.TabPagePreClosing += new EventHandler(btnSave_Click);
            this._tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            tblPnlExcel.Controls.Add(_tabControl1);
        }

        private void ExcelPadFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPage tab in this._tabControl1.TabPages)
            {
                if ((tab.Tag as TabPageTag).UnSaved)
                {
                    DialogResult dialogResult = MessageBox.Show("有未保存的文档，是否保存后退出？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.btnSaveAll_Click(sender, e);
                    }

                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this._currentExcelProcessor == null || string.IsNullOrEmpty(this._currentExcelProcessor.FilePath))
            {
                MessageBox.Show("请先打开一个Excel文件");
                return;
            }

            this.SaveToExcel(this._currentExcelProcessor, this._currentDataGridView);
            this.SetSaved();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in this._tabControl1.TabPages)
            {
                this.SaveToExcel((tab.Tag as TabPageTag).ExcelProcessor, tab.Controls["guidview"] as DataGridView);
                this.SetSaved(tab);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            StringFormat centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && _currentDataGridView.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    _currentDataGridView.ClearSelection();
                    _currentDataGridView.CurrentCell = _currentDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    _currentDataGridView.CurrentCell.Selected = true;

                    //弹出操作菜单
                    ctxGridCellMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int height = 96;
            DataGridView grid = sender as DataGridView;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col is DataGridViewImageColumn)
                {
                    object temp = grid.Rows[e.RowIndex].Cells[col.Index].Value;
                    if (temp != null)
                    {
                        int tempH = 0;
                        if (temp is Bitmap)
                        {
                            tempH = (temp as Bitmap).Height;
                        }
                        else if (temp is byte[])
                        {
                            tempH = ImageProcessor.BytesToBitmap(temp as byte[]).Height;
                        }
                        else
                        {
                            continue;
                        }
                        height = tempH > height ? tempH : height;
                    }
                }
            }

            grid.Rows[e.RowIndex].Height = height;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.SetUnSaved();
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            if (_currentDataGridView.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (_currentDataGridView.Columns[_currentDataGridView.CurrentCell.ColumnIndex] is DataGridViewImageColumn)
            {
                this.ctxGridCellMenuBtnChoose_Click(sender, e);
            }
            else
            {
                MessageBox.Show("选择的列无法放置图片");
            }
        }

        private void ctxGridCellMenuBtnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                fileChoosePicture.Filter = "图片|*.jpg;*.jpeg;*.png;*.gif";
                if (fileChoosePicture.ShowDialog() == DialogResult.OK)
                {
                    _currentDataGridView.CurrentCell.Value = Image.FromFile(fileChoosePicture.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctxGridCellMenuBtnSnapshot_Click(object sender, EventArgs e)
        {
            if (this._capturer == null)
            {
                MessageBox.Show("请确认是否已打开视频设备");
                return;
            }

            Bitmap bitmap = _capturer.videoSourcePlayer1.GetCurrentVideoFrame();
            if (bitmap == null)
            {
                MessageBox.Show("请确认是否已打开视频设备");
                return;
            }
            string dicPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Snapshot";
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            string filePath = $"{dicPath}\\{fileName}.png";

            try
            {
                if (!Directory.Exists(dicPath))
                {
                    Directory.CreateDirectory(dicPath);
                }
                ImageProcessor imgproc = new ImageProcessor(filePath);
                Image image = imgproc.ResizeImage(bitmap, 0.2D);
                image.Save(filePath);
                _currentDataGridView.CurrentCell.Value = Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            if (_currentDataGridView.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (_currentDataGridView.Columns[_currentDataGridView.CurrentCell.ColumnIndex] is DataGridViewImageColumn)
            {
                this.ctxGridCellMenuBtnSnapshot_Click(sender, e);
            }
            else
            {
                MessageBox.Show("选择的列无法放置图片");
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (_currentDataGridView.Columns == null || _currentDataGridView.Columns.Count < 1)
            {
                MessageBox.Show("请先打开一个Excel文件");
                return;
            }

            _currentDataGridView.Rows.Add();
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待");
            return;
            if (_currentDataGridView.SelectedRows == null || _currentDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择行");
                return;
            }

            bool hasData = false;
            foreach (DataGridViewRow row in _currentDataGridView.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        hasData = true;
                        break;
                    }
                }

                if (hasData)
                {
                    break;
                }
            }

            if (hasData)
            {
                DialogResult dr = MessageBox.Show("这些行包含有数据是否删除？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr != DialogResult.Yes)
                {
                    return;
                }
            }

            this.RemoveSelectRows(_currentDataGridView.SelectedRows);
        }

        private void btnCurrentDatetime_Click(object sender, EventArgs e)
        {
            if (_currentDataGridView.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (_currentDataGridView.Columns[_currentDataGridView.CurrentCell.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                _currentDataGridView.CurrentCell.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                MessageBox.Show("选择的列无法放置时间");
            }

        }

        private void btnOpenExcelFile_Click(object sender, EventArgs e)
        {
            fileChooseExcel.Filter = "EXCEL|*.xls";
            if (fileChooseExcel.ShowDialog() == DialogResult.OK)
            {
                if (!cbxFIlePath.Items.Contains(fileChooseExcel.FileName))
                {
                    cbxFIlePath.Items.Insert(0, fileChooseExcel.FileName);
                }
                cbxFIlePath.SelectedItem = fileChooseExcel.FileName;

                TabPage temp = this.FindTabPage(fileChooseExcel.FileName);
                if (temp != null)
                {
                    this._tabControl1.SelectedTab = temp;
                    return;
                }

                this.GetExcelData(fileChooseExcel.FileName);
            }
        }

        private void cbxFIlePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = (sender as ComboBox).SelectedItem.ToString();
            TabPage temp = this.FindTabPage(fileName);
            if (temp != null)
            {
                this._tabControl1.SelectedTab = temp;
            }
            else
            {
                this.GetExcelData(fileName);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_tabControl1.SelectedTab == null) return;

            TabPageTag tag = _tabControl1.SelectedTab.Tag as TabPageTag;
            cbxFIlePath.SelectedItem = tag.FileName;
            this._currentDataGridView = _tabControl1.SelectedTab.Controls["guidview"] as DataGridView;
            this._currentExcelProcessor = tag.ExcelProcessor;
        }

        private void btnOpenCaptuer_Click(object sender, EventArgs e)
        {
            this._capturer = new CapturerForm();
            this._capturer.StartPosition = FormStartPosition.CenterScreen;
            this._capturer.Show(this);
        }

        private void RemoveSelectRows(DataGridViewSelectedRowCollection rows)
        {
            if (rows != null || rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        this._currentExcelProcessor.RemovePictureInRow(row.Index + 1, 0);
                        this._currentExcelProcessor.RemoveRow(row.Index + 1, 0);
                        _currentDataGridView.Rows.Remove(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SetUnSaved()
        {
            TabPageTag tag = _tabControl1.SelectedTab.Tag as TabPageTag;
            _tabControl1.SelectedTab.Text = $"{Path.GetFileNameWithoutExtension(tag.FileName)} *";
            tag.UnSaved = true;
        }

        private void SetSaved(TabPage tab = null)
        {
            if (tab == null)
            {
                tab = _tabControl1.SelectedTab;
            }
            TabPageTag tag = tab.Tag as TabPageTag;
            tab.Text = Path.GetFileNameWithoutExtension(tag.FileName);
            tag.UnSaved = false;
        }

        private TabPage FindTabPage(string fileName)
        {
            TabPage result = null;
            foreach (TabPage page in _tabControl1.TabPages)
            {
                TabPageTag tag = page.Tag  as TabPageTag;
                if (tag.FileName == fileName)
                {
                    result = page;
                    break;
                }
            }

            return result;
        }

        private void GetExcelData(string fileName)
        {
            IList<object[]> data = null;
            IList<ExcelProcessor.PictureInfo> pictureInfos = null;
            try
            {
                this._currentExcelProcessor = new ExcelProcessor(fileName);
                pictureInfos = this._currentExcelProcessor.GetPictures(0);
                data = this._currentExcelProcessor.GetSheetData(0);

                if (pictureInfos != null && pictureInfos.Count > 0)
                {
                    foreach (var item in pictureInfos)
                    {
                        if (item.Row1 == item.Row2 && item.Col1 == item.Col2)
                        {
                            if (item.Row1 < data.Count && item.Col1 < data[item.Row1].Length)
                            {
                                data[item.Row1][item.Col1] = item.Picture;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataGridView dataGridView = new DataGridView();
            dataGridView.Name = "guidview";
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
            dataGridView.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridView1_CellMouseDown);
            dataGridView.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            dataGridView.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridView1_RowsAdded);

            if (data != null && data.Count > 0)
            {
                foreach (object item in data[0])
                {
                    string text = item.ToString();
                    if (ConfigurationManager.AppSettings["imageColumnsName"].Split('|').Contains(text))
                    {
                        DataGridViewImageColumn col = new DataGridViewImageColumn();
                        col.Name = text;
                        col.HeaderText = text;
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        col.MinimumWidth = 132;
                        dataGridView.Columns.Add(col);
                    }
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = text;
                        col.Name = text;
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                        dataGridView.Columns.Add(col);
                    }
                }

                data.RemoveAt(0);

                if (data.Count > 0)
                {
                    foreach (object[] row in data)
                    {
                        dataGridView.Rows.Add(row);
                    }
                }
            }

            TabPage tabPage = new TabPage(Path.GetFileNameWithoutExtension(fileName));
            tabPage.Tag = new TabPageTag(fileName, false, this._currentExcelProcessor);
            tabPage.Controls.Add(dataGridView);
            _tabControl1.Controls.Add(tabPage);
            _tabControl1.SelectedTab = tabPage;
            this._currentDataGridView = dataGridView;
        }

        private void SaveToExcel(ExcelProcessor excelProcessor, DataGridView grid)
        {
            string dicPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Backup";
            if (!Directory.Exists(dicPath))
            {
                Directory.CreateDirectory(dicPath);
            }

            string fileName = $"{Path.GetFileNameWithoutExtension(excelProcessor.FilePath)}_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}{Path.GetExtension(excelProcessor.FilePath)}";
            string filePath = $"{dicPath}\\{fileName}";
            try
            {
                File.Copy(excelProcessor.FilePath, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int row = 0; row < grid.Rows.Count; row++)
            {
                for (int col = 0; col < grid.Rows[row].Cells.Count; col++)
                {
                    DataGridViewCell cell = grid.Rows[row].Cells[col];
                    if (grid.Columns[cell.ColumnIndex] is DataGridViewImageColumn)
                    {
                        byte[] temp = null;
                        if (cell.Value is Bitmap)
                        {
                            temp = ImageProcessor.BitmapToBytes(cell.Value as Bitmap);
                        }
                        else if (cell.Value is byte[])
                        {
                            temp = cell.Value as byte[];
                        }
                        else
                        {
                            continue;
                        }
                        excelProcessor.RemovePictureInCell(row + 1, col, 0);
                        excelProcessor.InsertPictureInCell(col, row + 1, col + 1, row + 2, 5, 5, 5, 5, temp, 0);

                        if (temp != null)
                        {
                            Bitmap bitmap = ImageProcessor.BytesToBitmap(temp);
                            excelProcessor.SetCellWidth(col, bitmap.Width, 0);
                            excelProcessor.SetRowHeight(row + 1, bitmap.Height, 0);
                        }
                    }
                    else if (grid.Columns[cell.ColumnIndex] is DataGridViewTextBoxColumn)
                    {
                        cell.Value = cell.Value ?? string.Empty;
                        excelProcessor.SetCellValue(cell.Value.ToString(), row + 1, col, 0);
                    }
                }

            }

            excelProcessor.Save();
        }
    }
}