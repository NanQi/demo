using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

//添加新的命名空间
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    [DefaultEvent("PageIndexChanged"), DefaultProperty("RecordCount"), Description("分页控件")]
    public partial class WinFormPager : UserControl
    {
        #region Members
        private int _PageCount;
        private int _PageIndex = 1;
        private int _PageSize = 10;
        private int _RecordCount;
        private string PagerText = "总共{0}条记录,当前第{1}页,共{2}页,每页{3}条记录";

        public delegate void EventHandler(object sender, EventArgs e);

        [Description("更改页面索引事件"), Category("自定义事件")]
        public event EventHandler PageIndexChanged;

        private int PageCount
        {
            get
            {
                return this._PageCount;
            }
        }

        [DefaultValue(1), Category("自定义属性"), Description("当前显示的页数")]
        public int PageIndex
        {
            get
            {
                return this._PageIndex;
            }
            set
            {
                this._PageIndex = value;
            }
        }

        [DefaultValue(10), Description("每页显示的记录数"), Category("自定义属性")]
        public int PageSize
        {
            get
            {
                return this._PageSize;
            }
            set
            {
                if (value <= 1)
                {
                    value = 10;
                }
                this._PageSize = value;
            }
        }

        [Description("要分页的总记录数"), Category("自定义属性")]
        public int RecordCount
        {
            get
            {
                return this._RecordCount;
            }
            set
            {
                this._RecordCount = value;
            }
        }


        #endregion
        public WinFormPager()
        {
            InitializeComponent();
        }


        #region Methods

        protected int GetPageCount()
        {
            int num = 0;

            num = _RecordCount / _PageSize;

            if (_RecordCount % _PageSize != 0)
            {
                num++;
            }

            return num;
        }

        protected void SetBtnEnabled()
        {
            if (this._PageIndex == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnPrevious.Enabled = false;
                this.btnNext.Enabled =  true;
                this.btnLast.Enabled = true;
                //this.btnNext.Enabled = (this._PageCount <= 1) ? false : true;
                //this.btnLast.Enabled = (this._PageCount <= 1) ? false : true;
            }
            else if ((this._PageIndex > 1) && (this._PageIndex < this._PageCount))
            {
                this.btnFirst.Enabled = true;
                this.btnPrevious.Enabled = true;
                this.btnNext.Enabled = true;
                this.btnLast.Enabled = true;
            }
            else if (this._PageIndex == this._PageCount)
            {
                this.btnFirst.Enabled = true;
                this.btnPrevious.Enabled = true;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
        }
        private void SetPagerText()
        {
            string[] strArray = new string[] { this.RecordCount.ToString(), this.PageIndex.ToString(), this.PageCount.ToString(), this.PageSize.ToString() };
            this.lblPager.Text = string.Format(this.PagerText, (object[])strArray);
        }

        #endregion

        #region Events


        private void CustomEvent(object sender, EventArgs e)
        {
            txtToPageIndex.Text = _PageIndex.ToString();

            if (this.PageIndexChanged != null)
            {
                this.PageIndexChanged(sender, e);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this._PageIndex = 1;
            this.SetPagerText();
            this.SetBtnEnabled();
            this.CustomEvent(sender, e);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this._PageIndex = this._PageCount;
            this.SetPagerText();
            this.SetBtnEnabled();
            this.CustomEvent(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int num = this._PageIndex;
            try
            {
                int num2 = num + 1;
                if (num2 > this._PageCount)
                {
                    return;
                }
                this._PageIndex = num2;
                this.SetPagerText();
                this.SetBtnEnabled();
                this.CustomEvent(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int num = this._PageIndex;
            try
            {
                int num2 = num - 1;
                if (num2 <= 0)
                {
                    return;
                }
                this._PageIndex = num2;
                this.SetPagerText();
                this.SetBtnEnabled();
                this.CustomEvent(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void btnToPageIndex_Click(object sender, EventArgs e)
        {
            string text = this.txtToPageIndex.Text;
            int num = this._PageIndex;
            if (string.IsNullOrEmpty(text) || Convert.ToInt32(text) < 1)
            {
                num = 1;
                this.txtToPageIndex.Text = "1";
            }
            else
            {
                num = Convert.ToInt32(text);
                if (num > this._PageCount)
                {
                    num = this._PageCount;
                    this.txtToPageIndex.Text = this._PageCount.ToString();
                }
                else
                {
                    this._PageIndex = num;
                    this.SetPagerText();
                    this.SetBtnEnabled();
                    this.CustomEvent(sender, e);
                }
            }
        }

        private void WinFormPager_Load(object sender, EventArgs e)
        {
            this.SetBtnEnabled();
        }

        private void WinFormPager_Paint(object sender, PaintEventArgs e)
        {
            this._PageCount = this.GetPageCount();
            this.SetPagerText();

        }

        private void WinFormPager_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = Color.Transparent;
                    button.FlatAppearance.BorderColor = Color.White;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
            }
        }


        #endregion


        #region AutoGeneratee

        private void txtToPageIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txtToPageIndex_Enter(object sender, EventArgs e)
        {
            txtToPageIndex.TextAlign = HorizontalAlignment.Left;
        }

        private void txtToPageIndex_Leave(object sender, EventArgs e)
        {
            txtToPageIndex.TextAlign = HorizontalAlignment.Right;
        }
        #endregion



    }
}
