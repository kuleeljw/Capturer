namespace Capturer
{
    partial class CapturerForm
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
            this.tblPnlCapturer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCapturerController = new System.Windows.Forms.Panel();
            this.btnBeginOrCancel = new System.Windows.Forms.Button();
            this.cbxChooseResolution = new System.Windows.Forms.ComboBox();
            this.lblChooseResolution = new System.Windows.Forms.Label();
            this.cbxChooseDevice = new System.Windows.Forms.ComboBox();
            this.lblChooseDevice = new System.Windows.Forms.Label();
            this.pnlCapturer = new System.Windows.Forms.Panel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.tblPnlCapturer.SuspendLayout();
            this.pnlCapturerController.SuspendLayout();
            this.pnlCapturer.SuspendLayout();
            this.SuspendLayout();
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
            this.tblPnlCapturer.Size = new System.Drawing.Size(555, 493);
            this.tblPnlCapturer.TabIndex = 1;
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
            this.pnlCapturerController.Size = new System.Drawing.Size(553, 100);
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
            this.pnlCapturer.Size = new System.Drawing.Size(553, 390);
            this.pnlCapturer.TabIndex = 1;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.AutoSizeControl = true;
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(113, 72);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(322, 242);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // CapturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.tblPnlCapturer);
            this.Name = "CapturerForm";
            this.Text = "Capturer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Capturer_FormClosed);
            this.Load += new System.EventHandler(this.Capturer_Load);
            this.tblPnlCapturer.ResumeLayout(false);
            this.pnlCapturerController.ResumeLayout(false);
            this.pnlCapturerController.PerformLayout();
            this.pnlCapturer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnlCapturer;
        private System.Windows.Forms.Panel pnlCapturerController;
        private System.Windows.Forms.Button btnBeginOrCancel;
        private System.Windows.Forms.ComboBox cbxChooseResolution;
        private System.Windows.Forms.Label lblChooseResolution;
        private System.Windows.Forms.ComboBox cbxChooseDevice;
        private System.Windows.Forms.Label lblChooseDevice;
        private System.Windows.Forms.Panel pnlCapturer;
        internal AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}