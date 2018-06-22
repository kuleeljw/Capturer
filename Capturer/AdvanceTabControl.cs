using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturer
{
    public class AdvanceTabControl : TabControl
    {
        private const int CLOSE_SIZE = 15;

        public event EventHandler TabPagePreClosing;

        public AdvanceTabControl()
            : base()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.SizeMode = TabSizeMode.Normal;
            this.Padding =new Point(15,5);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = GetTabRect(e.Index);
            if (e.Index == this.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.AliceBlue; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色 

            }

            g.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(Color.Black), new PointF(r.X, r.Y + 5));//PointF选项卡标题的位置 

            //再画一个矩形框  
            using (Pen p = new Pen(Color.White))
            {
                r.Offset(r.Width - CLOSE_SIZE, 3);
                r.Width = CLOSE_SIZE;
                r.Height = CLOSE_SIZE;
                g.DrawRectangle(p, r);
            }

            //填充矩形框  
            using (Brush b = new SolidBrush(Color.White))
            {
                g.FillRectangle(b, r);
            }

            //画关闭符号  
            using (Pen objpen = new Pen(Color.Black))
            {
                //"\"线  
                Point p1 = new Point(r.X + 3, r.Y + 3);
                Point p2 = new Point(r.X + r.Width - 3, r.Y + r.Height - 3);
                g.DrawLine(objpen, p1, p2);

                //"/"线  
                Point p3 = new Point(r.X + 3, r.Y + r.Height - 3);
                Point p4 = new Point(r.X + r.Width - 3, r.Y + 3);
                g.DrawLine(objpen, p3, p4);
            }

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point point = e.Location;
            Rectangle r = GetTabRect(this.SelectedIndex);
            r.Offset(r.Width - CLOSE_SIZE, 0);
            r.Width = CLOSE_SIZE;
            r.Height = CLOSE_SIZE;
            if (r.Contains(point))
            {
                dynamic tag = this.SelectedTab.Tag;
                if (tag.UnSaved)
                {
                    DialogResult dialogResult = MessageBox.Show("当前文档没有保存，是否保存后再退出？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TabPagePreClosing?.Invoke(this, new EventArgs());
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                this.TabPages.RemoveAt(this.SelectedIndex);
            }
        }
    }
}
