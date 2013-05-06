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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //判断登陆是否成功
            if (!UserLogin())
            {
                //登录被取消退出系统
                System.Environment.Exit(0);
            }
        }

        #region 字段和属性

        private StringBuilder _sbSelect = null;

        private BindingManagerBase _bmb = null;

        private DataSet _dstPrint = null;

        private MyType _myType = MyType.Service;

        #endregion

        #region 动画

        private const int AW_CENTER = 0x0010;//从中间向四周
        private const int AW_HIDE = 0x10000;
        private const int AW_SLIDE = 0x40000;

        [DllImportAttribute("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //结束动画
            AnimateWindow(this.Handle, 300, 
                AW_SLIDE + AW_CENTER + AW_HIDE);
        }

        #endregion

        #region DataGridView有关

        /// <summary>
        /// 登陆窗体
        /// </summary>
        /// <returns></returns>
        private bool UserLogin()
        {
            frmLogin frmLogin = new frmLogin();
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
            this._dstPrint = new DataSet();

            this._sbSelect = new StringBuilder();

            LoadData(this._myType);

            this.btnLift_Click(sender, e);

            this.Select();
        }

        /// <summary>
        /// 获得排序方式
        /// </summary>
        /// <param name="tblName"></param>
        /// <returns></returns>
        private string GetSort(MyType myType)
        {
            string strSort = null;

            switch (myType)
            {
                case MyType.Service:
                    strSort = "维保到期时间, 所属区域 DESC, 具体位置 DESC";
                    break;
                case MyType.Lift:
                    break;
                case MyType.ErrorLift:
                    break;
                case MyType.ErrorList:
                    break;
                case MyType.Parts:
                    break;
                case MyType.Contract:
                    break;
                case MyType.Employee:
                    break;
                case MyType.Login:
                    break;
                default:
                    break;
            }

            //switch (tblName)
            //{
            //    case "Service":
            //        strSort = "维保到期时间, 所属区域 DESC, 具体位置 DESC";
            //        break;
            //    default:
            //        break;
            //}

            return strSort;
        }

        /// <summary>
        /// 设置DataGridView
        /// </summary>
        /// <param name="tblName"></param>
        private void SetGridView(MyType myType)
        {

            this._bmb = this.BindingContext[dgvInfo.DataSource];

            switch (myType)
            {
                case MyType.Service:
                    SetService();
                    break;
                case MyType.Lift:
                    SetLift();
                    break;
                case MyType.ErrorLift:
                    break;
                case MyType.ErrorList:
                    break;
                case MyType.Parts:
                    break;
                case MyType.Contract:
                    break;
                case MyType.Employee:
                    break;
                case MyType.Login:
                    break;
                default:
                    break;
            }

            //switch (tblName)
            //{
            //    case "Service":
            //        SetService();
            //        break;
            //    case "Lift":
            //        SetLift();
            //        break;
            //    default:
            //        break;
            //}
        }

        /// <summary>
        /// 设置DataView
        /// </summary>
        /// <param name="filter">筛选条件</param>
        /// <param name="sort">排序方式</param>
        private void SetDataView(
            ref DataView dvw, string filter, string sort)
        {
            dvw.RowFilter = filter;
            dvw.Sort = sort;
        }

        /// <summary>
        /// 打开维护计划表
        /// </summary>
        private void LoadData(MyType myType)
        {
            if (tsbExit.Visible)
            {
                tsbExit_Click(null, null);
            }
            if (tsbExitPrint.Visible)
            {
                tsbExitPrint_Click(null, null);
            }

            this._myType = myType;

            BLL.BaseBll bll = new BLL.BaseBll();

            DataTable dtbl = bll.GetViewInfo(myType.ToString());

            DataView dvw = new DataView(dtbl);
            SetDataView(ref dvw, "", GetSort(myType));

            //给dgv重新指定数据源
            dgvInfo.Columns.Clear();

            dgvInfo.DataSource = dvw;

            //展示查询到的记录数
            lblNumber.Text = dgvInfo.RowCount.ToString();

            //给字段名加载信息
            cbxColumnName.Items.Clear();

            for (int i = 0; i < dgvInfo.Columns.Count; i++)
            {
                cbxColumnName.Items.Add(dgvInfo.Columns[i].Name);
            }

            SetGridView(myType);
        }

        /// <summary>
        /// 设置维护计划表
        /// </summary>
        private void SetService()
        {
            pnlColor.Visible = true;

            //添加列
            DataGridViewLinkColumn errorLift =
    new DataGridViewLinkColumn();

            errorLift.HeaderText = "电梯维保";

            dgvInfo.Columns.Insert(8, errorLift);

            SortService();
        }

        /// <summary>
        /// 设置所有电梯表
        /// </summary>
        private void SetLift()
        {
            pnlColor.Visible = false;

            //添加列
            DataGridViewLinkColumn errorLift =
    new DataGridViewLinkColumn();

            errorLift.HeaderText = "电梯病历";

            dgvInfo.Columns.Insert(9, errorLift);

            SortLift();
        }

        /// <summary>
        /// 重新排序后处理维护计划表
        /// </summary>
        private void SortService()
        {
            //给新增列增加信息
            for (int i = 0; i < dgvInfo.RowCount; i++)
            {
                dgvInfo[8, i].Value = "点击立即维保";
            }

            //改变颜色
            for (int i = 0; i < dgvInfo.RowCount; i++)
            {
                DateTime dt = Convert.ToDateTime(
                    dgvInfo["维保到期时间", i].Value);

                if (dt.Date < DateTime.Now.Date)
                {
                    dgvInfo.Rows[i].DefaultCellStyle.BackColor =
                        Color.Red;
                }//超期的设置为红色
                else if (dt.Date == DateTime.Now.Date)
                {
                    dgvInfo.Rows[i].DefaultCellStyle.BackColor =
                        Color.Orange;
                }//到期的设置为橘黄色
                else
                {
                    dgvInfo.Rows[i].DefaultCellStyle.BackColor =
                        Color.LightYellow;
                }//预警的设置为亮黄色
            }
        }

        /// <summary>
        /// 重新排序后处理所有电梯表
        /// </summary>
        private void SortLift()
        {
            //给新增列增加信息
            for (int i = 0; i < dgvInfo.RowCount; i++)
            {
                dgvInfo[9, i].Value = "点击查看详情";
            }
        }

        #endregion

        #region 左侧菜单
        private void btnLift_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnLift.Dock = DockStyle.Top;
            btnPlan.Dock = DockStyle.Bottom;
            btnError.SendToBack();
            btnError.Dock = DockStyle.Bottom;
            btnContract.SendToBack();
            btnContract.Dock = DockStyle.Bottom;
            btnParts.SendToBack();
            btnParts.Dock = DockStyle.Bottom;
            btnEmployee.SendToBack();
            btnEmployee.Dock = DockStyle.Bottom;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("LiftAdd", "新增电梯", 4);
            lvwMenu.Items.Add("LiftAll", "所有电梯", 5);
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnPlan.Dock = DockStyle.Top;
            btnLift.SendToBack();
            btnLift.Dock = DockStyle.Top;
            btnError.Dock = DockStyle.Bottom;
            btnContract.SendToBack();
            btnContract.Dock = DockStyle.Bottom;
            btnParts.SendToBack();
            btnParts.Dock = DockStyle.Bottom;
            btnEmployee.SendToBack();
            btnEmployee.Dock = DockStyle.Bottom;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("PlanTime", "电梯维保", 12);
            lvwMenu.Items.Add("PlanYear", "年检提示", 8);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnError.Dock = DockStyle.Top;
            btnPlan.SendToBack();
            btnPlan.Dock = DockStyle.Top;
            btnLift.SendToBack();
            btnLift.Dock = DockStyle.Top;
            btnContract.SendToBack();
            btnContract.Dock = DockStyle.Bottom;
            btnParts.SendToBack();
            btnParts.Dock = DockStyle.Bottom;
            btnEmployee.SendToBack();
            btnEmployee.Dock = DockStyle.Bottom;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("ErrorLift", "电梯病历", 2);
            lvwMenu.Items.Add("ErrorList", "故障记录", 3);
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnContract.Dock = DockStyle.Top;
            btnError.SendToBack();
            btnError.Dock = DockStyle.Top;
            btnPlan.SendToBack();
            btnPlan.Dock = DockStyle.Top;
            btnLift.SendToBack();
            btnLift.Dock = DockStyle.Top;
            btnParts.SendToBack();
            btnParts.Dock = DockStyle.Bottom;
            btnEmployee.SendToBack();
            btnEmployee.Dock = DockStyle.Bottom;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("ContractAdd", "新增合同", 11);
            lvwMenu.Items.Add("ContractAll", "合同管理", 10);
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnParts.Dock = DockStyle.Top;
            btnContract.SendToBack();
            btnContract.Dock = DockStyle.Top;
            btnError.SendToBack();
            btnError.Dock = DockStyle.Top;
            btnPlan.SendToBack();
            btnPlan.Dock = DockStyle.Top;
            btnLift.SendToBack();
            btnLift.Dock = DockStyle.Top;
            btnEmployee.SendToBack();
            btnEmployee.Dock = DockStyle.Bottom;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("PartsAdd", "新增配件", 6);
            lvwMenu.Items.Add("PartsAll", "配件管理", 7);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lvwMenu.Dock = DockStyle.None;
            btnEmployee.Dock = DockStyle.Top;
            btnParts.SendToBack();
            btnParts.Dock = DockStyle.Top;
            btnContract.SendToBack();
            btnContract.Dock = DockStyle.Top;
            btnError.SendToBack();
            btnError.Dock = DockStyle.Top;
            btnPlan.SendToBack();
            btnPlan.Dock = DockStyle.Top;
            btnLift.SendToBack();
            btnLift.Dock = DockStyle.Top;
            lvwMenu.Dock = DockStyle.Fill;

            lvwMenu.Clear();
            lvwMenu.Items.Add("EmployeeAdd", "新增员工", 0);
            lvwMenu.Items.Add("EmployeeAll", "员工管理", 1);
        }

        #endregion

        /// <summary>
        /// 获得指定MyType的中文解释
        /// </summary>
        /// <param name="myType"></param>
        /// <returns></returns>
        private string GetTypeName(MyType myType)
        {
            string str = null;

            switch (myType)
            {
                case MyType.Service:
                    str = "维保计划";
                    break;
                case MyType.Lift:
                    str = "维保电梯";
                    break;
                case MyType.ErrorLift:
                    str = "电梯病例";
                    break;
                case MyType.ErrorList:
                    str = "故障记录";
                    break;
                case MyType.Parts:
                    str = "电梯零件";
                    break;
                case MyType.Contract:
                    str = "维保合同";
                    break;
                case MyType.Employee:
                    str = "维保员工";
                    break;
                case MyType.Login:
                    str = "登陆管理";
                    break;
                default:
                    break;
            }

            return str;

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel1Collapsed)
            {
                splitContainer2.Panel1Collapsed = false;

                this.btnSplit.BackgroundImage = global::Elevator_Manager.Properties.Resources.right;
            }
            else
            {
                splitContainer2.Panel1Collapsed = true;

                this.btnSplit.BackgroundImage = global::Elevator_Manager.Properties.Resources.left;
            }
        }

        private void lvwMenu_Click(object sender, EventArgs e)
        {
            if (lvwMenu.SelectedItems[0].Name == "LiftAdd")
            {
                frmLiftAdd frm = new frmLiftAdd();
                frm.ShowDialog();
            }
            else if (lvwMenu.SelectedItems[0].Name == "LiftAll")
            {
                LoadData(MyType.Lift);
            }
        }

        private void dgvInfo_Sorted(object sender, EventArgs e)
        {
            switch (this._myType)
            {
                case MyType.Service:
                    SortService();
                    break;
                case MyType.Lift:
                    SortLift();
                    break;
                case MyType.ErrorLift:
                    break;
                case MyType.ErrorList:
                    break;
                case MyType.Parts:
                    break;
                case MyType.Contract:
                    break;
                case MyType.Employee:
                    break;
                case MyType.Login:
                    break;
                default:
                    break;
            }


            //switch (this._tblName)
            //{
            //    case "Service":
            //        SortService();
            //        break;
            //    case "Lift":
            //        SortLift();
            //        break;
            //    default:
            //        break;
            //}


            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbxColumnName.Text.Trim().Length == 0 || 
                cbxOperator.Text.Length == 0 || 
                txtSelect.Text.Trim().Length == 0)
            {
                return;
            }

            if (cbxColumnName.Text.Contains("时间"))
            {
                DateTime dt;

                if (!DateTime.TryParse(txtSelect.Text.Trim(), out dt))
                {
                    return;
                }
            }

            StringBuilder sb = new StringBuilder(cbxColumnName.Text);

            switch (cbxOperator.Text)
            {
                case "等于" :
                    sb.AppendFormat(" = '{0}'", 
                        txtSelect.Text.Trim());
                    break;
                case "不等于":
                    sb.AppendFormat(" <> '{0}'",
                        txtSelect.Text.Trim());
                    break;
                case "大于":
                    sb.AppendFormat(" > '{0}'", 
                        txtSelect.Text.Trim());
                    break;
                case "小于":
                    sb.AppendFormat(" < '{0}'", 
                        txtSelect.Text.Trim());
                    break;
                case "大于等于":
                    sb.AppendFormat(" >= '{0}'", 
                        txtSelect.Text.Trim());
                    break;
                case "小于等于":
                    sb.AppendFormat(" <= '{0}'", 
                        txtSelect.Text.Trim());
                    break;
                case "模糊查询":
                    sb.AppendFormat(" LIKE '%{0}%'", 
                        txtSelect.Text.Trim());
                    break;
                default:
                    return;
            }

            BLL.BaseBll bll = new BLL.BaseBll();

            DataTable dtbl = bll.GetViewInfo(this._myType.ToString());

            DataView dvw = new DataView(dtbl);
            SetDataView(ref dvw, "", GetSort(this._myType));

            //判断是否选中过滤当前
            if (chbxNow.Checked)
            {
                this._sbSelect.AppendFormat(" AND {0}", sb.ToString());
                SetDataView(ref dvw, this._sbSelect.ToString(), 
                    GetSort(this._myType));
            }
            else
            {
                SetDataView(ref dvw, sb.ToString(),
                    GetSort(this._myType));
                this._sbSelect = sb;
            }
            //给dgv重新指定数据源
            dgvInfo.Columns.Clear();

            dgvInfo.DataSource = dvw;

            lblNumber.Text = dgvInfo.RowCount.ToString();

            SetGridView(this._myType);

            this.cbxOperator.Text = "";
            this.txtSelect.Text = "";
        }

        private void tsbAll_Click(object sender, EventArgs e)
        {
            LoadData(this._myType);
        }

        private void dgvInfo_CellContentClick(object sender, 
            DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void tsbSelect_Click(object sender, EventArgs e)
        {
            if (tsbExit.Visible)
            {
                return;
            }

            if (tsbExitPrint.Visible)
            {
                tsbExitPrint_Click(null, null);
            }


            gbxUp.Visible = false;
            dgvInfo.Visible = false;
            tsbExit.Visible = true;

            ucInfo frm = new ucInfo();
            gbxMiddle.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.tableLayoutPanel.RowCount = this.dgvInfo.ColumnCount;

            for (int i = 0; i < this.dgvInfo.ColumnCount - 1; i++)
            {
                Label lblName = new Label();
                lblName.Text = this.dgvInfo.Columns[i].Name;
                frm.tableLayoutPanel.Controls.Add(lblName);


                Label lblValue = new Label();
                lblValue.Text = this.dgvInfo[i, 0].Value.ToString();
                lblValue.Anchor = AnchorStyles.Left;
                frm.tableLayoutPanel.Controls.Add(lblValue);
                lblValue.DataBindings.Add("Text", 
                    this.dgvInfo.DataSource,lblName.Text);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            gbxMiddle.Controls[1].Dispose();

            dgvInfo.Visible = true;
            gbxUp.Visible = true;

            tsbExit.Visible = false;
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            this._bmb.Position -= 1;
        }

        private void tsbRight_Click(object sender, EventArgs e)
        {
            this._bmb.Position += 1;
        }

        private void tsbLeftEnd_Click(object sender, EventArgs e)
        {
            this._bmb.Position = 0;
        }

        private void tsbRightEnd_Click(object sender, EventArgs e)
        {
            this._bmb.Position = this._bmb.Count - 1;
        }

        private void tsbService_Click(object sender, EventArgs e)
        {
            LoadData(MyType.Service);
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            DataView dvw = (DataView)dgvInfo.DataSource;

            DataTable dtbl = dvw.ToTable(
                this._myType.ToString());

            if (this._dstPrint.Tables.Contains(this._myType.ToString()))
            {
                if (MessageBox.Show("是否替换报表中的" + 
                    this.GetTypeName(this._myType) + "表", "提示",
                    MessageBoxButtons.YesNo) == 
                    DialogResult.Yes)
                {
                    this._dstPrint.Tables.Remove(this._myType.ToString());
                    lvwPrint.Items.RemoveByKey(this._myType.ToString());
                    this._dstPrint.Tables.Add(dtbl);
                }
                else
                {
                    return;
                }
            }
            else
            {
                this._dstPrint.Tables.Add(dtbl);
            }

            lvwPrint.Items.Add(this._myType.ToString(),
                this.GetTypeName(this._myType) + "表", 
                this._myType.ToString());
        }

        private void lvwPrint_Click(object sender, EventArgs e)
        {
            if (tsbExit.Visible)
            {
                gbxMiddle.Controls[1].Dispose();
                tsbExit.Visible = false;
            }

            if (tsbExitPrint.Visible)
            {
                gbxMiddle.Controls[1].Dispose();
            }

            tsbExitPrint.Visible = true;
            tsbErrorListSelect.Visible = false;
            txtErrorListSelect.Visible = false;


            gbxUp.Visible = false;
            gbxDown.Visible = false;

            dgvInfo.Visible = false;

            string tblName = lvwPrint.SelectedItems[0].ImageKey;

            switch (tblName)
            {
                case "Service":
                    ucPrint ucService = new ucPrint(this._dstPrint.Tables[
                        lvwPrint.SelectedItems[0].Name], tblName);
                    gbxMiddle.Controls.Add(ucService);
                    ucService.Dock = DockStyle.Fill;
                    break;
                case "Lift":
                    ucPrint ucLift = new ucPrint(this._dstPrint.Tables[
                        lvwPrint.SelectedItems[0].Name], tblName);
                    gbxMiddle.Controls.Add(ucLift);
                    ucLift.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }

        private void tsbExitPrint_Click(object sender, EventArgs e)
        {
            gbxMiddle.Controls[1].Dispose();

            tsbExitPrint.Visible = false;
            tsbErrorListSelect.Visible = true;
            txtErrorListSelect.Visible = true;


            gbxUp.Visible = true;
            gbxDown.Visible = true;

            dgvInfo.Visible = true;
        }

        private void toolsUp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
