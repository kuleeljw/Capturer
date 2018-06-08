namespace Capturer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblPnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlCapturer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCapturerController = new System.Windows.Forms.Panel();
            this.btnBeginOrCancel = new System.Windows.Forms.Button();
            this.cbxChooseResolution = new System.Windows.Forms.ComboBox();
            this.lblChooseResolution = new System.Windows.Forms.Label();
            this.cbxChooseDevice = new System.Windows.Forms.ComboBox();
            this.lblChooseDevice = new System.Windows.Forms.Label();
            this.pnlCapturer = new System.Windows.Forms.Panel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.tblPnlExcel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlExcellContoller = new System.Windows.Forms.Panel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenExcelFile = new System.Windows.Forms.Button();
            this.txtFIlePath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnCurrentDatetime = new System.Windows.Forms.Button();
            this.btnRemoveRow = new System.Windows.Forms.Button();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileChoosePicture = new System.Windows.Forms.OpenFileDialog();
            this.ctxGridCellMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxGridCellMenuBtnSnapshot = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxGridCellMenuBtnChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.fileChooseExcel = new System.Windows.Forms.OpenFileDialog();
            this.tblPnlMain.SuspendLayout();
            this.tblPnlCapturer.SuspendLayout();
            this.pnlCapturerController.SuspendLayout();
            this.pnlCapturer.SuspendLayout();
            this.tblPnlExcel.SuspendLayout();
            this.pnlExcellContoller.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ctxGridCellMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPnlMain
            // 
            this.tblPnlMain.ColumnCount = 2;
            this.tblPnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tblPnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMain.Controls.Add(this.tblPnlCapturer, 0, 0);
            this.tblPnlMain.Controls.Add(this.tblPnlExcel, 1, 0);
            this.tblPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblPnlMain.Name = "tblPnlMain";
            this.tblPnlMain.RowCount = 1;
            this.tblPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlMain.Size = new System.Drawing.Size(1440, 714);
            this.tblPnlMain.TabIndex = 0;
            // 
            // tblPnlCapturer
            // 
            this.tblPnlCapturer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblPnlCapturer.ColumnCount = 1;
            this.tblPnlCapturer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlCapturer.Controls.Add(this.pnlCapturerController, 0, 0);
            this.tblPnlCapturer.Controls.Add(this.pnlCapturer, 0, 1);
            this.tblPnlCapturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlCapturer.Location = new System.Drawing.Point(0, 0);
            this.tblPnlCapturer.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnlCapturer.Name = "tblPnlCapturer";
            this.tblPnlCapturer.RowCount = 2;
            this.tblPnlCapturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblPnlCapturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlCapturer.Size = new System.Drawing.Size(700, 714);
            this.tblPnlCapturer.TabIndex = 0;
            // 
            // pnlCapturerController
            // 
            this.pnlCapturerController.Controls.Add(this.btnBeginOrCancel);
            this.pnlCapturerController.Controls.Add(this.cbxChooseResolution);
            this.pnlCapturerController.Controls.Add(this.lblChooseResolution);
            this.pnlCapturerController.Controls.Add(this.cbxChooseDevice);
            this.pnlCapturerController.Controls.Add(this.lblChooseDevice);
            this.pnlCapturerController.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCapturerController.Location = new System.Drawing.Point(1, 1);
            this.pnlCapturerController.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCapturerController.Name = "pnlCapturerController";
            this.pnlCapturerController.Size = new System.Drawing.Size(698, 100);
            this.pnlCapturerController.TabIndex = 0;
            // 
            // btnBeginOrCancel
            // 
            this.btnBeginOrCancel.Location = new System.Drawing.Point(422, 17);
            this.btnBeginOrCancel.Name = "btnBeginOrCancel";
            this.btnBeginOrCancel.Size = new System.Drawing.Size(110, 67);
            this.btnBeginOrCancel.TabIndex = 4;
            this.btnBeginOrCancel.Text = "打开摄像头";
            this.btnBeginOrCancel.UseVisualStyleBackColor = true;
            this.btnBeginOrCancel.Click += new System.EventHandler(this.btnBeginOrCancel_Click);
            // 
            // cbxChooseResolution
            // 
            this.cbxChooseResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseResolution.Location = new System.Drawing.Point(111, 61);
            this.cbxChooseResolution.Name = "cbxChooseResolution";
            this.cbxChooseResolution.Size = new System.Drawing.Size(279, 23);
            this.cbxChooseResolution.TabIndex = 3;
            this.cbxChooseResolution.SelectedIndexChanged += new System.EventHandler(this.cbxChooseResolution_SelectedIndexChanged);
            // 
            // lblChooseResolution
            // 
            this.lblChooseResolution.AutoSize = true;
            this.lblChooseResolution.Location = new System.Drawing.Point(8, 64);
            this.lblChooseResolution.Name = "lblChooseResolution";
            this.lblChooseResolution.Size = new System.Drawing.Size(97, 15);
            this.lblChooseResolution.TabIndex = 2;
            this.lblChooseResolution.Text = "选择分辨率：";
            // 
            // cbxChooseDevice
            // 
            this.cbxChooseDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseDevice.Location = new System.Drawing.Point(111, 17);
            this.cbxChooseDevice.Name = "cbxChooseDevice";
            this.cbxChooseDevice.Size = new System.Drawing.Size(279, 23);
            this.cbxChooseDevice.TabIndex = 1;
            this.cbxChooseDevice.SelectedIndexChanged += new System.EventHandler(this.cbxChooseDevice_SelectedIndexChanged);
            // 
            // lblChooseDevice
            // 
            this.lblChooseDevice.AutoSize = true;
            this.lblChooseDevice.Location = new System.Drawing.Point(23, 20);
            this.lblChooseDevice.Name = "lblChooseDevice";
            this.lblChooseDevice.Size = new System.Drawing.Size(82, 15);
            this.lblChooseDevice.TabIndex = 0;
            this.lblChooseDevice.Text = "选择设备：";
            // 
            // pnlCapturer
            // 
            this.pnlCapturer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCapturer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCapturer.Controls.Add(this.videoSourcePlayer1);
            this.pnlCapturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCapturer.Location = new System.Drawing.Point(1, 102);
            this.pnlCapturer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCapturer.Name = "pnlCapturer";
            this.pnlCapturer.Size = new System.Drawing.Size(698, 611);
            this.pnlCapturer.TabIndex = 1;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.AutoSizeControl = true;
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(186, 182);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // tblPnlExcel
            // 
            this.tblPnlExcel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblPnlExcel.ColumnCount = 1;
            this.tblPnlExcel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlExcel.Controls.Add(this.pnlExcellContoller, 0, 0);
            this.tblPnlExcel.Controls.Add(this.panel1, 0, 1);
            this.tblPnlExcel.Controls.Add(this.dataGridView1);
            this.tblPnlExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlExcel.Location = new System.Drawing.Point(703, 3);
            this.tblPnlExcel.Name = "tblPnlExcel";
            this.tblPnlExcel.RowCount = 3;
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblPnlExcel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 609F));
            this.tblPnlExcel.Size = new System.Drawing.Size(734, 708);
            this.tblPnlExcel.TabIndex = 1;
            // 
            // pnlExcellContoller
            // 
            this.pnlExcellContoller.Controls.Add(this.btnSaveAs);
            this.pnlExcellContoller.Controls.Add(this.btnSave);
            this.pnlExcellContoller.Controls.Add(this.btnOpenExcelFile);
            this.pnlExcellContoller.Controls.Add(this.txtFIlePath);
            this.pnlExcellContoller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcellContoller.Location = new System.Drawing.Point(1, 1);
            this.pnlExcellContoller.Margin = new System.Windows.Forms.Padding(0);
            this.pnlExcellContoller.Name = "pnlExcellContoller";
            this.pnlExcellContoller.Size = new System.Drawing.Size(732, 50);
            this.pnlExcellContoller.TabIndex = 2;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(572, 15);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(71, 25);
            this.btnSaveAs.TabIndex = 9;
            this.btnSaveAs.Text = "另存";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenExcelFile
            // 
            this.btnOpenExcelFile.Location = new System.Drawing.Point(418, 15);
            this.btnOpenExcelFile.Name = "btnOpenExcelFile";
            this.btnOpenExcelFile.Size = new System.Drawing.Size(71, 25);
            this.btnOpenExcelFile.TabIndex = 7;
            this.btnOpenExcelFile.Text = "打开";
            this.btnOpenExcelFile.UseVisualStyleBackColor = true;
            this.btnOpenExcelFile.Click += new System.EventHandler(this.btnOpenExcelFile_Click);
            // 
            // txtFIlePath
            // 
            this.txtFIlePath.Enabled = false;
            this.txtFIlePath.Location = new System.Drawing.Point(4, 15);
            this.txtFIlePath.Name = "txtFIlePath";
            this.txtFIlePath.Size = new System.Drawing.Size(409, 25);
            this.txtFIlePath.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddRow);
            this.panel1.Controls.Add(this.btnCurrentDatetime);
            this.panel1.Controls.Add(this.btnRemoveRow);
            this.panel1.Controls.Add(this.btnChoosePicture);
            this.panel1.Controls.Add(this.btnSnapshot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 39);
            this.panel1.TabIndex = 3;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(502, -1);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(80, 36);
            this.btnAddRow.TabIndex = 14;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnCurrentDatetime
            // 
            this.btnCurrentDatetime.Location = new System.Drawing.Point(338, -1);
            this.btnCurrentDatetime.Name = "btnCurrentDatetime";
            this.btnCurrentDatetime.Size = new System.Drawing.Size(150, 36);
            this.btnCurrentDatetime.TabIndex = 12;
            this.btnCurrentDatetime.Text = "置入当前时间";
            this.btnCurrentDatetime.UseVisualStyleBackColor = true;
            this.btnCurrentDatetime.Click += new System.EventHandler(this.btnCurrentDatetime_Click);
            // 
            // btnRemoveRow
            // 
            this.btnRemoveRow.Location = new System.Drawing.Point(580, -1);
            this.btnRemoveRow.Name = "btnRemoveRow";
            this.btnRemoveRow.Size = new System.Drawing.Size(80, 36);
            this.btnRemoveRow.TabIndex = 13;
            this.btnRemoveRow.Text = "-";
            this.btnRemoveRow.UseVisualStyleBackColor = true;
            this.btnRemoveRow.Click += new System.EventHandler(this.btnRemoveRow_Click);
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(169, -1);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(170, 36);
            this.btnChoosePicture.TabIndex = 11;
            this.btnChoosePicture.Text = "选择图片置入单元格";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosebtnChoosePicture_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(0, -1);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(170, 36);
            this.btnSnapshot.TabIndex = 10;
            this.btnSnapshot.Text = "拍照置入单元格";
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(4, 101);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(726, 603);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // ctxGridCellMenu
            // 
            this.ctxGridCellMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxGridCellMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxGridCellMenuBtnSnapshot,
            this.ctxGridCellMenuBtnChoose});
            this.ctxGridCellMenu.Name = "ctxGridCellMenu";
            this.ctxGridCellMenu.Size = new System.Drawing.Size(143, 52);
            // 
            // ctxGridCellMenuBtnSnapshot
            // 
            this.ctxGridCellMenuBtnSnapshot.Name = "ctxGridCellMenuBtnSnapshot";
            this.ctxGridCellMenuBtnSnapshot.Size = new System.Drawing.Size(142, 24);
            this.ctxGridCellMenuBtnSnapshot.Text = "拍照";
            this.ctxGridCellMenuBtnSnapshot.Click += new System.EventHandler(this.ctxGridCellMenuBtnSnapshot_Click);
            // 
            // ctxGridCellMenuBtnChoose
            // 
            this.ctxGridCellMenuBtnChoose.Name = "ctxGridCellMenuBtnChoose";
            this.ctxGridCellMenuBtnChoose.Size = new System.Drawing.Size(142, 24);
            this.ctxGridCellMenuBtnChoose.Text = "选择图片";
            this.ctxGridCellMenuBtnChoose.Click += new System.EventHandler(this.ctxGridCellMenuBtnChoose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 714);
            this.Controls.Add(this.tblPnlMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tblPnlMain.ResumeLayout(false);
            this.tblPnlCapturer.ResumeLayout(false);
            this.pnlCapturerController.ResumeLayout(false);
            this.pnlCapturerController.PerformLayout();
            this.pnlCapturer.ResumeLayout(false);
            this.tblPnlExcel.ResumeLayout(false);
            this.pnlExcellContoller.ResumeLayout(false);
            this.pnlExcellContoller.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ctxGridCellMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlMain;
        private System.Windows.Forms.TableLayoutPanel tblPnlCapturer;
        private System.Windows.Forms.Panel pnlCapturerController;
        private System.Windows.Forms.Button btnBeginOrCancel;
        private System.Windows.Forms.ComboBox cbxChooseResolution;
        private System.Windows.Forms.Label lblChooseResolution;
        private System.Windows.Forms.ComboBox cbxChooseDevice;
        private System.Windows.Forms.Label lblChooseDevice;
        private System.Windows.Forms.Panel pnlCapturer;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.OpenFileDialog fileChoosePicture;
        private System.Windows.Forms.ContextMenuStrip ctxGridCellMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxGridCellMenuBtnChoose;
        private System.Windows.Forms.ToolStripMenuItem ctxGridCellMenuBtnSnapshot;
        private System.Windows.Forms.TableLayoutPanel tblPnlExcel;
        private System.Windows.Forms.Panel pnlExcellContoller;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenExcelFile;
        private System.Windows.Forms.TextBox txtFIlePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnCurrentDatetime;
        private System.Windows.Forms.Button btnRemoveRow;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog fileChooseExcel;
    }
}