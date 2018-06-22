namespace Capturer
{
    partial class ExcelPadFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelPadFrom));
            this.fileChoosePicture = new System.Windows.Forms.OpenFileDialog();
            this.ctxGridCellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxGridCellMenuBtnSnapshot = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGridCellMenuBtnChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileChooseExcel = new System.Windows.Forms.OpenFileDialog();
            this.tblPnlExcel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlExcellContoller = new System.Windows.Forms.Panel();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.cbxFIlePath = new System.Windows.Forms.ComboBox();
            this.btnOpenCaptuer = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenExcelFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnCurrentDatetime = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ctxGridCellMenu.SuspendLayout();
            this.tblPnlExcel.SuspendLayout();
            this.pnlExcellContoller.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxGridCellMenu
            // 
            this.ctxGridCellMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxGridCellMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxGridCellMenuBtnSnapshot,
            this.ctxGridCellMenuBtnChoose});
            this.ctxGridCellMenu.Name = "ctxGridCellMenu";
            this.ctxGridCellMenu.Size = new System.Drawing.Size(153, 60);
            // 
            // ctxGridCellMenuBtnSnapshot
            // 
            this.ctxGridCellMenuBtnSnapshot.Name = "ctxGridCellMenuBtnSnapshot";
            this.ctxGridCellMenuBtnSnapshot.Size = new System.Drawing.Size(152, 28);
            this.ctxGridCellMenuBtnSnapshot.Text = "拍照";
            this.ctxGridCellMenuBtnSnapshot.Click += new System.EventHandler(this.ctxGridCellMenuBtnSnapshot_Click);
            // 
            // ctxGridCellMenuBtnChoose
            // 
            this.ctxGridCellMenuBtnChoose.Name = "ctxGridCellMenuBtnChoose";
            this.ctxGridCellMenuBtnChoose.Size = new System.Drawing.Size(152, 28);
            this.ctxGridCellMenuBtnChoose.Text = "选择图片";
            this.ctxGridCellMenuBtnChoose.Click += new System.EventHandler(this.ctxGridCellMenuBtnChoose_Click);
            // 
            // tblPnlExcel
            // 
            this.tblPnlExcel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblPnlExcel.ColumnCount = 1;
            this.tblPnlExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlExcel.Controls.Add(this.pnlExcellContoller, 0, 0);
            this.tblPnlExcel.Controls.Add(this.panel1, 0, 1);
            this.tblPnlExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlExcel.Location = new System.Drawing.Point(0, 0);
            this.tblPnlExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblPnlExcel.Name = "tblPnlExcel";
            this.tblPnlExcel.RowCount = 3;
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 812F));
            this.tblPnlExcel.Size = new System.Drawing.Size(1620, 952);
            this.tblPnlExcel.TabIndex = 2;
            // 
            // pnlExcellContoller
            // 
            this.pnlExcellContoller.Controls.Add(this.btnPrint);
            this.pnlExcellContoller.Controls.Add(this.btnSaveAll);
            this.pnlExcellContoller.Controls.Add(this.cbxFIlePath);
            this.pnlExcellContoller.Controls.Add(this.btnOpenCaptuer);
            this.pnlExcellContoller.Controls.Add(this.btnSaveAs);
            this.pnlExcellContoller.Controls.Add(this.btnSave);
            this.pnlExcellContoller.Controls.Add(this.btnOpenExcelFile);
            this.pnlExcellContoller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcellContoller.Location = new System.Drawing.Point(1, 1);
            this.pnlExcellContoller.Margin = new System.Windows.Forms.Padding(0);
            this.pnlExcellContoller.Name = "pnlExcellContoller";
            this.pnlExcellContoller.Size = new System.Drawing.Size(1618, 67);
            this.pnlExcellContoller.TabIndex = 2;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(644, 20);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(94, 33);
            this.btnSaveAll.TabIndex = 12;
            this.btnSaveAll.Text = "全部保存";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // cbxFIlePath
            // 
            this.cbxFIlePath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFIlePath.FormattingEnabled = true;
            this.cbxFIlePath.Location = new System.Drawing.Point(3, 20);
            this.cbxFIlePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFIlePath.Name = "cbxFIlePath";
            this.cbxFIlePath.Size = new System.Drawing.Size(460, 28);
            this.cbxFIlePath.TabIndex = 11;
            this.cbxFIlePath.SelectedIndexChanged += new System.EventHandler(this.cbxFIlePath_SelectedIndexChanged);
            // 
            // btnOpenCaptuer
            // 
            this.btnOpenCaptuer.BackColor = System.Drawing.Color.Violet;
            this.btnOpenCaptuer.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCaptuer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenCaptuer.Location = new System.Drawing.Point(923, 3);
            this.btnOpenCaptuer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenCaptuer.Name = "btnOpenCaptuer";
            this.btnOpenCaptuer.Size = new System.Drawing.Size(135, 60);
            this.btnOpenCaptuer.TabIndex = 10;
            this.btnOpenCaptuer.Text = "来，拍个照";
            this.btnOpenCaptuer.UseVisualStyleBackColor = false;
            this.btnOpenCaptuer.Click += new System.EventHandler(this.btnOpenCaptuer_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(745, 20);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(80, 33);
            this.btnSaveAs.TabIndex = 9;
            this.btnSaveAs.Text = "另存";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(557, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenExcelFile
            // 
            this.btnOpenExcelFile.Location = new System.Drawing.Point(470, 20);
            this.btnOpenExcelFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenExcelFile.Name = "btnOpenExcelFile";
            this.btnOpenExcelFile.Size = new System.Drawing.Size(80, 33);
            this.btnOpenExcelFile.TabIndex = 7;
            this.btnOpenExcelFile.Text = "打开";
            this.btnOpenExcelFile.UseVisualStyleBackColor = true;
            this.btnOpenExcelFile.Click += new System.EventHandler(this.btnOpenExcelFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddRow);
            this.panel1.Controls.Add(this.btnCurrentDatetime);
            this.panel1.Controls.Add(this.btnRemoveRow);
            this.panel1.Controls.Add(this.btnChoosePicture);
            this.panel1.Controls.Add(this.btnSnapshot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1612, 52);
            this.panel1.TabIndex = 3;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(565, -1);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(90, 48);
            this.btnAddRow.TabIndex = 14;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnCurrentDatetime
            // 
            this.btnCurrentDatetime.Location = new System.Drawing.Point(380, -1);
            this.btnCurrentDatetime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrentDatetime.Name = "btnCurrentDatetime";
            this.btnCurrentDatetime.Size = new System.Drawing.Size(169, 48);
            this.btnCurrentDatetime.TabIndex = 12;
            this.btnCurrentDatetime.Text = "置入当前时间";
            this.btnCurrentDatetime.UseVisualStyleBackColor = true;
            this.btnCurrentDatetime.Click += new System.EventHandler(this.btnCurrentDatetime_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(652, -1);
            this.btnRemoveRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(90, 48);
            this.btnRemoveRow.TabIndex = 13;
            this.btnRemoveRow.Text = "-";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(190, -1);
            this.btnChoosePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(191, 48);
            this.btnChoosePicture.TabIndex = 11;
            this.btnChoosePicture.Text = "选择图片置入单元格";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(0, -1);
            this.btnSnapshot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(191, 48);
            this.btnSnapshot.TabIndex = 10;
            this.btnSnapshot.Text = "拍照置入单元格";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPrint.Font = new System.Drawing.Font("YouYuan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Location = new System.Drawing.Point(843, 3);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 59);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ExcelPadFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 952);
            this.Controls.Add(this.tblPnlExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExcelPadFrom";
            this.Text = "ExcelPad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelPadFrom_FormClosing);
            this.Load += new System.EventHandler(this.ExcelPadFrom_Load);
            this.ctxGridCellMenu.ResumeLayout(false);
            this.tblPnlExcel.ResumeLayout(false);
            this.pnlExcellContoller.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fileChoosePicture;
        private System.Windows.Forms.ContextMenuStrip ctxGridCellMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxGridCellMenuBtnChoose;
        private System.Windows.Forms.ToolStripMenuItem ctxGridCellMenuBtnSnapshot;
        private System.Windows.Forms.OpenFileDialog fileChooseExcel;
        private System.Windows.Forms.TableLayoutPanel tblPnlExcel;
        private System.Windows.Forms.Panel pnlExcellContoller;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenExcelFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnCurrentDatetime;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.Button btnOpenCaptuer;
        private System.Windows.Forms.ComboBox cbxFIlePath;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnPrint;
    }
}