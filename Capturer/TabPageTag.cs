using Capturer.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capturer
{
    class TabPageTag
    {
        public string FileName { get; set; }
        public bool UnSaved { get; set; }
        public ExcelProcessor ExcelProcessor { get; set; }

        public TabPageTag(string fileName, bool unSaved, ExcelProcessor excelProcessor)
        {
            this.FileName = fileName;
            this.UnSaved = unSaved;
            this.ExcelProcessor = excelProcessor;
        }
    }
}
