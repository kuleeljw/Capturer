using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capturer.Processor;

namespace Capturer
{
    public partial class CapturerForm : Form
    {
        private readonly VideoCapturerProcessor _videoCapturerProcessor = null;

        public CapturerForm()
        {
            this._videoCapturerProcessor = new VideoCapturerProcessor();

            InitializeComponent();
        }

        private void Capturer_Load(object sender, EventArgs e)
        {
            this.cbxChooseDevice.Items.AddRange(this._videoCapturerProcessor.DeviceNames);
            this.cbxChooseDevice.SelectedIndex = 0;
            if (this._videoCapturerProcessor.DeviceCount < 1)
            {
                btnBeginOrCancel.Enabled = false;
            }
        }

        private void Capturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseVideo();
        }

        private void cbxChooseDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._videoCapturerProcessor.DeviceCount < 1)
            {
                return;
            }
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
                return;
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

            if (btn.Text == "打开")
            {
                btn.Enabled = false;
                this.EnableController(false);

                this.CalcPlayerWidthAndHeight();

                try
                {
                    this.videoSourcePlayer1.VideoSource = this._videoCapturerProcessor.OpenCapturer();
                    this.videoSourcePlayer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.CloseVideo();
                }

                btn.Text = "关闭";
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;

                this.CloseVideo();

                btn.Text = "打开";
                btn.Enabled = true;
                this.EnableController(true);
            }
        }

        private void CloseVideo()
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

        private void CalcPlayerWidthAndHeight()
        {
            if (this.cbxChooseResolution == null || this.cbxChooseResolution.SelectedItem == null) return;

            string[] arr = this.cbxChooseResolution.SelectedItem.ToString().Split('x');
            if (arr == null || arr.Length < 2) return;

            double width = double.Parse(arr[0].Trim());
            double height = double.Parse(arr[1].Trim());
            double widthHeightRate = width / height;

            if (widthHeightRate == (double)this.videoSourcePlayer1.Width / (double)this.videoSourcePlayer1.Height) return;

            int targetWidth = (int)(this.videoSourcePlayer1.Height * widthHeightRate);
            this.Size = new Size(this.Size.Width + (targetWidth - this.Size.Width) + 16, this.Size.Height);
        }
    }
}
