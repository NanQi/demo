using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace CustomerService
{
    public class LineTextBox : TextBox
    {

        public const int WM_PAINT = 0x000F;

        /// <summary>
        /// 当一个编辑型控件将要被绘制时发送此消息给它的父窗口；通过响应这条消息，所有者窗口可以通过使用给定的相关显示设备的句柄来设置编辑框的文本和背景颜色
        /// </summary>
        public const int WM_CTLCOLOREDIT = 0x0133;

        /// <summary>
        /// 获得焦点
        /// </summary>
        public const int WM_SETFOCUS = 0x007;
        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        public LineTextBox()
        {
            //this.BorderStyle=BorderStyle.None;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_CTLCOLOREDIT:
                    goto case WM_PAINT;
                case WM_PAINT:
                    IntPtr hDC = GetWindowDC(this.Handle);
                    //检查获取对象是否成功
                    if (hDC.ToInt32() != 0)
                    {
                        using (Graphics g = Graphics.FromHdc(hDC))
                        {
                            DrawBottomLine(g);
                            g.Dispose();
                        }// end using

                    }// end if
                    //返回结果 
                    m.Result = IntPtr.Zero;
                    //释放资源
                    ReleaseDC(m.HWnd, hDC);
                    break;
            }// end swithc
        }

        private void DrawBottomLine(Graphics g)
        {
            Pen p = new Pen(this.BackColor, 2);
            g.DrawRectangle(p, 1, 1, this.Width - 2, this.Height - 2);
            p = new Pen(Color.FromArgb(0, 0, 0), 1);
            g.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
            p.Dispose();
        }


    }
}
