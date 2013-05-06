using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Elevator_Manager
{
    public partial class frmLogin : Form
    {
        #region 动画

        private const int AW_HOR_NEGATIVE = 0x0002;//从右向左显示
        private const int AW_HIDE = 0x10000;
        private const int AW_SLIDE = 0x40000;

        [DllImportAttribute("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //结束动画
            AnimateWindow(this.Handle, 300, 
                AW_SLIDE + AW_HOR_NEGATIVE + AW_HIDE);
        }

        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //设置窗体动画
            AnimateWindow(this.Handle, 300,
                AW_SLIDE + AW_HOR_NEGATIVE);
        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
