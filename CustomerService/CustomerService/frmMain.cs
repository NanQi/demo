using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CustomerService.Report;

namespace CustomerService
{
    public partial class frmMain : Form
    {
        private frmMain()
        {
            InitializeComponent();
            //判断登陆是否成功
            if (!UserLogin())
            {
                //登录被取消退出系统
                System.Environment.Exit(0);
            }
            Init();
        }

        #region 字段

        List<IDockContent> lstDockContent = new List<IDockContent>();
        dockCustomerGroup _customerGroup = new dockCustomerGroup();
        private static frmMain _main = new frmMain();

        #endregion
        #region 属性

        /// <summary>
        /// 获取主界面的DockPanel
        /// </summary>
        public DockPanel DockPanelMain
        {
            get
            {
                return dockPanel1;
            }
        }

        /// <summary>
        /// 获取主界面的客户组
        /// </summary>
        public dockCustomerGroup DockCustomerGroup
        {
            get
            {
                return _customerGroup;
            }
        }

        /// <summary>
        /// 单态
        /// </summary>
        public static frmMain Main
        {
            get
            {
                return _main;
            }
        }

        #endregion
        

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            //加载
            _customerGroup.Show(this.dockPanel1);
            dockCustomer customer = new dockCustomer();
            customer.Show(this.dockPanel1);


            //菜单栏
            tsmiAddCustomerGroup.Click += (sender, e) =>
                (new frmCustomerGroup()).ShowDialog(this);
            tsmiAddCustomer.Click += (sender, e) =>
                (new frmCustomer()).ShowDialog(this);
            tsmiAddService.Click += (sender, e) =>
                (new frmService()).ShowDialog(this);

            //报表菜单
            tsmiReportCustomerInfo.Click += (sender, e) =>
                (new frmPrint(GetReport<rptCustomerInfo>("Customer", ""))).ShowDialog(this);
            tsmiReportCustomerPie.Click += (sender, e) =>
                (new frmPrint(GetReport<rptCustomerPie>("Customer", ""))).ShowDialog(this);
            tsmiReportServiceInfo.Click += (sender, e) =>
                (new frmPrint(GetReport<rptServiceInfo>("Service", ""))).ShowDialog(this);
            tsmiReportServiceMonth.Click += (sender, e) =>
            {
                rptServiceMonth rpt = (rptServiceMonth)GetReport<rptServiceMonth>("Service", "DATEDIFF(MONTH, '"+DateTime.Now+"', 受理时间) = 0");
                //设置月份
                TextObject obj = (TextObject)rpt.Section1.ReportObjects["Text1"];
                obj.Text = DateTime.Now.ToString("yyyy年MM月");
                frmPrint frm = new frmPrint(rpt);
                frm.ShowDialog(this);
            };
            tsmiReportServiceTotal.Click += (sender, e) =>
                (new frmPrint(GetReport<rptServiceTotal>("Service", ""))).ShowDialog(this);

            tsmiOption.Click += (sender, e) =>
                (new frmOption()).ShowDialog(this);
            

            //状态栏时间
            tmr.Tick += (sender, e) => tsslblTime.Text = 
                DateTime.Now.ToString("当前时间:yyyy-MM-dd HH:mm:ss");
            tmr.Start();

            //工具栏、客户组、状态栏隐藏和现实
            tsmiTools.Click += (sender, e) =>
                toolStrip1.Visible = tsmiTools.Checked;

            tsmiCustomerGroup.Click += (sender, e) =>
                _customerGroup.IsHidden = !tsmiCustomerGroup.Checked;

            _customerGroup.VisibleChanged += (sender, e) =>
                tsmiCustomerGroup.Checked = !_customerGroup.IsHidden;

            tsmiStatus.Click += (sender, e) =>
                statusStrip1.Visible = tsmiStatus.Checked;
            //搜索故障解决方案效果
            tstSulotion.Enter += (sender, e) =>
            {
                if (tstSulotion.ForeColor == Color.Gray)
                {
                    tstSulotion.Text = string.Empty;
                    tstSulotion.ForeColor = Color.Black;
                }
            };
            tstSulotion.Leave += (sender, e) =>
            {
                if (tstSulotion.Text.Trim().Length == 0)
                {
                    tstSulotion.Text = "在此输入故障现象";
                    tstSulotion.ForeColor = Color.Gray;
                }
            };

            //加载布局
            //string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"xml\DockPanel.xml ");

            //if (File.Exists(path))
            //{
            //    dockPanel1.LoadFromXml(path, persistString =>
            //    {
            //        if (persistString ==
            //            typeof(dockCustomerGroup).ToString())
            //        {
            //            return _customerGroup;
            //        }
            //        else
            //        {
            //            return null;
            //        }
            //    });
            //}

        }

        /// <summary>
        /// 登陆窗体
        /// </summary>
        /// <returns></returns>
        private bool UserLogin()
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.Owner = this;
            try
            {
                DialogResult result = frmLogin.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                frmLogin.Dispose();
            }
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmiCloseAll_Click(object sender, EventArgs e)
        {
            for (int i = this.dockPanel1.Contents.Count - 1; i >= 0 ; i--)
            {
                if (this.dockPanel1.Contents[i] is DockContent)
                {
                    DockContent dock = 
                        (DockContent)this.dockPanel1.Contents[i];
                    if (!dock.Equals(_customerGroup))
                    {
                        dock.Close();
                    }
                }
            }
        }

        private void tsbCustomer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dockPanel1.Contents.Count; i++)
            {
                if (frmMain.Main.DockPanelMain.Contents[i] is dockCustomer)
                {
                    dockCustomer dc =
                        (dockCustomer)this.dockPanel1.Contents[i];
                    if (dc.GUID.ToString() == Guid.Empty.ToString())
                    {
                        dc.Focus();
                        dc.GetData();
                        return;
                    }
                }
            }

            dockCustomer dock = new dockCustomer();
            dock.Show(this.dockPanel1);
        }

        private void tsbService_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dockPanel1.Contents.Count; i++)
            {
                if (frmMain.Main.DockPanelMain.Contents[i] is dockService)
                {
                    dockService dc =
                        (dockService)this.dockPanel1.Contents[i];
                    if (dc.GUID.ToString() == Guid.Empty.ToString())
                    {
                        dc.Focus();
                        dc.GetData();
                        return;
                    }
                }
            }

            dockService dock = new dockService();
            dock.Show(this.dockPanel1);
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.ShowDialog(this);
        }

        private void tsbSulotion_Click(object sender, EventArgs e)
        {
            dockSolution dock = new dockSolution();
            dock.Show(this.dockPanel1);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //BLL.LoadData bll = new BLL.LoadData();
            //bll.Load();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出?", "关闭询问", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            //else
            //{
            //    this.dockPanel1.SaveAsXml(@"xml\DockPanel.xml");
            //}
        }

        /// <summary>
        /// 给定报表类型和类型字符串(Service或Customer)返回报表
        /// </summary>
        /// <typeparam name="T">报表类型</typeparam>
        /// <param name="strType">类型字符串</param>
        /// <returns></returns>
        public ReportClass GetReport<T>(string strType, string where) where T:new()
        {
            Type type = typeof(T);

            ReportClass rpt;

            if (type.IsSubclassOf(typeof(ReportClass)))
            {
                rpt = new T() as ReportClass;
            }
            else
            {
                throw new Exception("所给类型不是ReportClass的子类");
            }

            string tblName = "V_Customer";
            string fldName = "客户编号";

            if (strType != "Customer")
            {
                tblName = "V_Service";
                fldName = "服务编号";
            }

            if (where == "")
            {
                where = "1 = 1";
            }

            BLL.ViewOperator bll = new BLL.ViewOperator();
            DataSet dst = bll.GetList(tblName,
                where + " ORDER BY " + fldName);
            dst.Tables[0].TableName = tblName;

            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dtbl = bllArgument.GetList("type = '" + fldName + "'").Tables[0];

            string strNO = dtbl.Rows[0][1].ToString();

            for (int i = 0; i < dst.Tables[0].Rows.Count; i++)
            {
                dst.Tables[0].Rows[i][1] = strNO + dst.Tables[0].Rows[i][1];
            }

            rpt.SetDataSource(dst);

            return rpt;
        }
    }
}
