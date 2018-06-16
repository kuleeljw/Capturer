using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;

namespace Capturer.Processor
{
    public class VideoCapturerProcessor
    {
        private FilterInfoCollection _videoDevices = null;
        private VideoCaptureDevice _currentVideoDevice = null;
        private VideoCapabilities[] _videoCapabilities = null;
        private VideoCapabilities _currentVideoCapabilities = null;

        public VideoCapturerProcessor()
        {
            this._videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        /// <summary>
        /// 所有设备的名称
        /// </summary>
        public string[] DeviceNames
        {
            get
            {
                List<string> result = new List<string>();

                if (this._videoDevices.Count < 1)
                {
                    result.Add("找不到录制设备");
                }
                else
                {
                    foreach (FilterInfo item in this._videoDevices)
                    {
                        result.Add(item.Name);
                    }
                }

                return result.ToArray();
            }
        }

        /// <summary>
        /// 设备数量
        /// </summary>
        public int DeviceCount
        {
            get
            {
                return this._videoDevices.Count;
            }
        }

        public void ChooseDevice(int index)
        {
            if(this.DeviceCount < 1)
            {
                throw new Exception("没有设备");
            }
            this._currentVideoDevice = new VideoCaptureDevice(this._videoDevices[index].MonikerString);
            this._videoCapabilities = _currentVideoDevice.VideoCapabilities;
        }

        public void ChooseCapabilities(int index)
        {
            this._currentVideoCapabilities = this._videoCapabilities[index];
        }

        /// <summary>
        /// 获取可以用的分辨率
        /// </summary>
        /// <param name="deviceIndex"></param>
        /// <returns></returns>
        public IList<int[]> GetAvailableResolution()
        {
            if (this._currentVideoDevice == null)
            {
                throw new Exception("没有选择设备");
            }

            List<int[]> result = new List<int[]>();

            if (this._videoCapabilities != null && this._videoCapabilities.Length > 0)
            {
                int count = 0;
                foreach (VideoCapabilities item in this._videoCapabilities)
                {
                    result.Add(new[] { count, item.FrameSize.Width, item.FrameSize.Height });
                    count++;
                }
            }

            return result;
        }

        public VideoCaptureDevice OpenCapturer()
        {
            if (this._currentVideoDevice == null)
            {
                throw new Exception("没有选择设备");
            }

            if (this._currentVideoCapabilities != null)
            {
                this._currentVideoDevice.VideoResolution = this._currentVideoCapabilities;
            }

            return this._currentVideoDevice;
        }
    }
}
