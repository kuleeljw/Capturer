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
using static Capturer.Processor.ExcelProcessor;
using System.IO;

namespace Capturer
{
    public partial class MainForm : Form
    {
        private readonly VideoCapturerProcessor _videoCapturerProcessor = null;
        private ExcelProcessor _excelProcessor = null;

        public MainForm()
        {
            this._videoCapturerProcessor = new VideoCapturerProcessor();

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cbxChooseDevice.Items.AddRange(this._videoCapturerProcessor.DeviceNames);
            this.cbxChooseDevice.SelectedIndex = 0;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void cbxChooseDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deviceIndex = (sender as ComboBox).SelectedIndex;
            IList<int[]> resolutions = new List<int[]>();

            try
            {
                this._videoCapturerProcessor.ChooseDevice(deviceIndex);
                resolutions = this._videoCapturerProcessor.GetAvailableResolution().OrderBy(x => x[1]).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (int[] item in resolutions)
            {
                this.cbxChooseResolution.Items.Add(new ComboBoxItem($"{item[1]} x {item[2]}", item[0].ToString()));
            }

            this.cbxChooseResolution.SelectedIndex = 2;
        }

        private void cbxChooseResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            object capabilitiesIndex = ((sender as ComboBox).SelectedItem as ComboBoxItem).Value;
            try
            {
                this._videoCapturerProcessor.ChooseCapabilities(Convert.ToInt32(capabilitiesIndex));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBeginOrCancel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "打开摄像头")
            {
                btn.Enabled = false;
                this.EnableController(false);

                try
                {
                    this.videoSourcePlayer1.VideoSource = this._videoCapturerProcessor.OpenCapturer();
                    this.videoSourcePlayer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }

                btn.Text = "关闭摄像头";
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;

                this.Close();

                btn.Text = "打开摄像头";
                btn.Enabled = true;
                this.EnableController(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this._excelProcessor == null || string.IsNullOrEmpty(this._excelProcessor.FilePath))
            {
                MessageBox.Show("请先打开一个Excel文件");
                return;
            }

            string dicPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Backup";
            if (!Directory.Exists(dicPath))
            {
                Directory.CreateDirectory(dicPath);
            }

            string fileName = $"{Path.GetFileNameWithoutExtension(this._excelProcessor.FilePath)}_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}{Path.GetExtension(this._excelProcessor.FilePath)}";
            string filePath = $"{dicPath}\\{fileName}";
            try
            {
                File.Copy(this._excelProcessor.FilePath, filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Rows[row].Cells.Count; col++)
                {
                    DataGridViewCell cell = dataGridView1.Rows[row].Cells[col];
                    if (dataGridView1.Columns[cell.ColumnIndex] is DataGridViewImageColumn)
                    {
                        byte[] temp = null;
                        if (cell.Value is Bitmap)
                        {
                            temp = ImageProcessor.BitmapToBytes(cell.Value as Bitmap);
                        }
                        else if (cell.Value is byte[])
                        {
                            temp = (byte[])cell.Value;
                        }
                        else
                        {
                            continue;
                        }
                        this._excelProcessor.RemovePictureInCell(row + 1, col, 0);
                        this._excelProcessor.InsertPictureInCell(col, row + 1, col + 1, row + 2, 5, 5, 5, 5, temp, 0);

                        if (temp != null)
                        {
                            Bitmap bitmap = ImageProcessor.BytesToBitmap(temp);
                            this._excelProcessor.SetCellWidth(col, bitmap.Width, 0);
                            this._excelProcessor.SetRowHeight(row + 1, bitmap.Height, 0);
                        }
                    }
                    else if (dataGridView1.Columns[cell.ColumnIndex] is DataGridViewTextBoxColumn)
                    {
                        cell.Value = cell.Value ?? string.Empty;
                        this._excelProcessor.SetCellValue(cell.Value.ToString(), row + 1, col, 0);
                    }
                }

            }

            this._excelProcessor.Save();
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
                if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.CurrentCell.Selected = true;

                    //弹出操作菜单
                    ctxGridCellMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void btnChoosebtnChoosePicture_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex] is DataGridViewImageColumn)
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
                    dataGridView1.CurrentCell.Value = Image.FromFile(fileChoosePicture.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex] is DataGridViewImageColumn)
            {
                this.ctxGridCellMenuBtnSnapshot_Click(sender, e);
            }
            else
            {
                MessageBox.Show("选择的列无法放置图片");
            }
        }

        private void ctxGridCellMenuBtnSnapshot_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
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
                dataGridView1.CurrentCell.Value = Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns == null || dataGridView1.Columns.Count < 1)
            {
                MessageBox.Show("请先打开一个Excel文件");
                return;
            }
            dataGridView1.Rows.Add();
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("敬请期待");
            return;
            if (dataGridView1.SelectedRows == null || dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择行");
                return;
            }

            bool hasData = false;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
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

            this.RemoveSelectRows(dataGridView1.SelectedRows);
        }

        private void btnCurrentDatetime_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("请先选择一个单元格");
                return;
            }

            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                dataGridView1.CurrentCell.Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
                txtFIlePath.Text = fileChooseExcel.FileName;

                IList<object[]> data = null;
                IList<PictureInfo> pictureInfos = null;
                try
                {
                    this._excelProcessor = new ExcelProcessor(fileChooseExcel.FileName);
                    pictureInfos = this._excelProcessor.GetPictures(0);
                    data = this._excelProcessor.GetSheetData(0);

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

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
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
                            col.Width = 132;
                            dataGridView1.Columns.Add(col);
                        }
                        else
                        {
                            dataGridView1.Columns.Add(text, text);
                        }
                    }

                    data.RemoveAt(0);

                    if (data.Count > 0)
                    {
                        foreach (object[] row in data)
                        {
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void RemoveSelectRows(DataGridViewSelectedRowCollection rows)
        {
            if (rows != null || rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        this._excelProcessor.RemovePictureInRow(row.Index + 1, 0);
                        this._excelProcessor.RemoveRow(row.Index + 1, 0);
                        dataGridView1.Rows.Remove(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Close()
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
                videoSourcePlayer1.VideoSource = null;
            }
        }

        private void EnableController(bool enable)
        {
            cbxChooseDevice.Enabled = enable;
            cbxChooseResolution.Enabled = enable;
        }
    }
}