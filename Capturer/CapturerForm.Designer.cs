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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturerForm));
            this.btnBeginOrCancel = new System.Windows.Forms.Button();
            this.cbxChooseResolution = new System.Windows.Forms.ComboBox();
            this.lblChooseResolution = new System.Windows.Forms.Label();
            this.cbxChooseDevice = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.lblChooseDevice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeginOrCancel
            // 
            this.btnBeginOrCancel.Location = new System.Drawing.Point(571, 3);
            this.btnBeginOrCancel.Name = "btnBeginOrCancel";
            this.btnBeginOrCancel.Size = new System.Drawing.Size(55, 28);
            this.btnBeginOrCancel.TabIndex = 10;
            this.btnBeginOrCancel.Text = "打开";
            this.btnBeginOrCancel.UseVisualStyleBackColor = true;
            this.btnBeginOrCancel.Click += new System.EventHandler(this.btnBeginOrCancel_Click);
            // 
            // cbxChooseResolution
            // 
            this.cbxChooseResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseResolution.Location = new System.Drawing.Point(372, 6);
            this.cbxChooseResolution.Name = "cbxChooseResolution";
            this.cbxChooseResolution.Size = new System.Drawing.Size(193, 23);
            this.cbxChooseResolution.TabIndex = 9;
            this.cbxChooseResolution.SelectedValueChanged += new System.EventHandler(this.cbxChooseResolution_SelectedIndexChanged);
            // 
            // lblChooseResolution
            // 
            this.lblChooseResolution.AutoSize = true;
            this.lblChooseResolution.Location = new System.Drawing.Point(299, 9);
            this.lblChooseResolution.Name = "lblChooseResolution";
            this.lblChooseResolution.Size = new System.Drawing.Size(67, 15);
            this.lblChooseResolution.TabIndex = 8;
            this.lblChooseResolution.Text = "分辨率：";
            // 
            // cbxChooseDevice
            // 
            this.cbxChooseDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseDevice.Location = new System.Drawing.Point(61, 6);
            this.cbxChooseDevice.Name = "cbxChooseDevice";
            this.cbxChooseDevice.Size = new System.Drawing.Size(224, 23);
            this.cbxChooseDevice.TabIndex = 7;
            this.cbxChooseDevice.SelectedValueChanged += new System.EventHandler(this.cbxChooseDevice_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblChooseDevice);
            this.panel1.Controls.Add(this.btnBeginOrCancel);
            this.panel1.Controls.Add(this.cbxChooseDevice);
            this.panel1.Controls.Add(this.cbxChooseResolution);
            this.panel1.Controls.Add(this.lblChooseResolution);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 38);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.videoSourcePlayer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 480);
            this.panel2.TabIndex = 12;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer1.Margin = new System.Windows.Forms.Padding(0);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(640, 480);
            this.videoSourcePlayer1.TabIndex = 8;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // lblChooseDevice
            // 
            this.lblChooseDevice.AutoSize = true;
            this.lblChooseDevice.Location = new System.Drawing.Point(3, 10);
            this.lblChooseDevice.Name = "lblChooseDevice";
            this.lblChooseDevice.Size = new System.Drawing.Size(52, 15);
            this.lblChooseDevice.TabIndex = 5;
            this.lblChooseDevice.Text = "设备：";
            // 
            // CapturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapturerForm";
            this.Text = "Capturer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Capturer_FormClosed);
            this.Load += new System.EventHandler(this.Capturer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeginOrCancel;
        private System.Windows.Forms.ComboBox cbxChooseResolution;
        private System.Windows.Forms.Label lblChooseResolution;
        private System.Windows.Forms.ComboBox cbxChooseDevice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label lblChooseDevice;
    }
}