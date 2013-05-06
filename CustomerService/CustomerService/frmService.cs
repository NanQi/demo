using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerService
{
    public partial class frmService : Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        public frmService(Model.Service model)
        {
            InitializeComponent();
            BLL.Service bllService = new BLL.Service();
            Model.Service modelService = bllService.GetModel(model.GUID);

            _model = modelService;
            _guid = _model.customer;
        }

        public frmService(Guid guid)
        {
            InitializeComponent();
            _guid = guid;
        }

        Model.Service _model;
        Guid _guid;

        private void frmService_Load(object sender, EventArgs e)
        {
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            this.cbxCustomerGroup.Nodes.Add(bll.GetCustomerGroup());
            this.cbxCustomerGroup.Nodes[0].Toggle();
            if (_guid != Guid.Empty)
            {
                GetCustomerGroup(_guid);
            }

            if (this._model != null)
            {
                GetUpdate();
            }
            else
            {
                GetAdd();
            }
        }

        /// <summary>
        /// 或许所属客户组
        /// </summary>
        /// <param name="guid"></param>
        private void GetCustomerGroup(Guid guid)
        {
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            List<string> lst = new List<string>();
            BLL.Customer bllCustomer = new BLL.Customer();
            Model.Customer modelCustomer = bllCustomer.GetModel(guid);

            bll.GetSelected(ref lst, modelCustomer.parentGUID);

            StringBuilder sb = new StringBuilder();

            for (int i = lst.Count - 1; i > 0; i--)
            {
                sb.Append(lst[i]);
                sb.Append(this.cbxCustomerGroup.BranchSeparator);
            }

            sb.Append(lst[0]);

            this.cbxCustomerGroup.Text = sb.ToString();
            this.cbxCustomerGroup.SelectedNode = (this.cbxCustomerGroup.Nodes.Find(modelCustomer.parentGUID.ToString(), true))[0];
        }

        /// <summary>
        /// 获取新增服务编号
        /// </summary>
        private void GetServiceNo()
        {
            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dt = bllArgument.GetList("type = '服务编号'").Tables[0];

            string str = dt.Rows[0][1].ToString();

            BLL.Service bllService = new BLL.Service();
            txtNO.Text = str + bllService.GetMaxID();
        }

        private void GetCustomerGroupAndSelected(Guid guid)
        {
            //获得所属客户组
            BLL.Customer bllCustomer = new BLL.Customer();
            BLL.CustomerGroup bllGroup = new BLL.CustomerGroup();

            Model.Customer modelCustomer = new Model.Customer();
            modelCustomer = bllCustomer.GetModel(guid);

            List<string> lst = new List<string>();
            bllGroup.GetSelected(ref lst, modelCustomer.parentGUID);

            StringBuilder sb = new StringBuilder();

            for (int i = lst.Count - 1; i > 0; i--)
            {
                sb.Append(lst[i]);
                sb.Append(this.cbxCustomerGroup.BranchSeparator);
            }

            sb.Append(lst[0]);

            this.cbxCustomerGroup.Text = sb.ToString();
            this.cbxCustomerGroup.SelectedNode =
                (this.cbxCustomerGroup.Nodes.Find(
                modelCustomer.parentGUID.ToString(), true))[0];

            cbxCustomerGroup_Leave(null, null);

            cbxName.SelectedValue = guid.ToString();
        }

        /// <summary>
        /// 新增信息初始化
        /// </summary>
        private void GetAdd()
        {
            GetServiceNo();
            if (_guid != Guid.Empty)
            {
                GetCustomerGroupAndSelected(_guid);
            }

            this.Text = "新增服务记录";
            this.btnSave.Visible = true;
            //默认赋值
            cbxType.SelectedIndex = 0;
            cbxEvaluate.SelectedIndex = 1;
            cbxPayStatus.SelectedIndex = 0;
            cbxTraffic.SelectedIndex = 0;
            //TODO employee
            cbxEmployee.SelectedIndex = 0;
        }
        /// <summary>
        /// 修改信息初始化
        /// </summary>
        private void GetUpdate()
        {
            this.Text = "编辑服务记录";
            BLL.Service bll = new BLL.Service();
            Model.Service model = bll.GetModel(_model.GUID);

            //赋值
            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dt = bllArgument.GetList("type = '服务编号'").Tables[0];

            string str = dt.Rows[0][1].ToString();

            txtNO.Text = str + model.sNO;
            dtpAccept.Value = model.acceptDate ?? DateTime.Now;

            if (_guid != Guid.Empty)
            {
                GetCustomerGroupAndSelected(_guid);
            }
            cbxType.Text = model.type;

            //服务内容
            if (!string.IsNullOrEmpty(model.content) &&
                model.content.Contains('ス'))
            {
                string[] content = model.content.Split('ス');

                if (content.Length == 2)
                {
                    txtFault.Text = content[0];
                    txtSolution.Text = content[1];
                }
            }

            txtResult.Text = model.result;
            cbxEvaluate.Text = model.evaluate;
            txtMaterial.Text = model.material;
            txtMaterialMoney.Text = 
                string.Format("{0:F2}", model.materialMoney);
            txtServiceMoney.Text =
                string.Format("{0:F2}", model.serviceMoney);
            txtSum.Text = 
                string.Format("{0:F2}", 
                model.materialMoney + model.serviceMoney);
            cbxPayStatus.Text = model.payStatus;
            dtpSolution.Value = model.solutionDate ?? DateTime.Now;
            cbxTraffic.Text = model.traffic;
            cbxEmployee.Text = model.employee;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(this.txtNO.Text.Trim()))
            {
                errorProvider1.SetError(txtNO, "服务编号不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.cbxName.Text.Trim()))
            {
                errorProvider1.SetError(cbxName, "客户名称不能为空!");
                return;
            }

            BLL.Service bll = new BLL.Service();
            Model.Service model = new Model.Service();
            model.sNO = txtNO.Text.Substring(txtNO.Text.Length - 4);
            model.customer = new Guid(cbxName.SelectedValue.ToString());
            model.acceptDate = dtpAccept.Value;
            model.solutionDate = dtpSolution.Value;
            model.type = cbxType.Text;
            model.content = txtFault.Text.Trim() + "ス" +
                txtSolution.Text.Trim();
            model.result = txtResult.Text.Trim();
            model.evaluate = cbxEvaluate.Text;
            model.material = txtMaterial.Text.Trim();

            decimal material = 0;

            if (string.IsNullOrEmpty(txtMaterialMoney.Text.Trim()) || decimal.TryParse(txtMaterialMoney.Text.Trim(),
                out material))
            {
                model.materialMoney = material;
            }
            else
            {
                errorProvider1.SetError(txtMaterialMoney,
                    "请输入正确的金额!");
                return;
            }

            decimal service = 0;

            if (string.IsNullOrEmpty(txtServiceMoney.Text.Trim()) ||decimal.TryParse(txtServiceMoney.Text.Trim(),
                out service))
            {
                model.serviceMoney = service;
            }
            else
            {
                errorProvider1.SetError(txtServiceMoney,
                    "请输入正确的金额!");
                return;
            }

            model.payStatus = cbxPayStatus.Text;
            model.traffic = cbxTraffic.Text;
            model.employee = cbxEmployee.Text;

            bool flg = false;

            try
            {
                if (this.Text == "新增服务记录")
                {
                    flg = bll.Add(model);
                }
                else
                {
                    model.GUID = _model.GUID;
                    flg = bll.Update(model);
                }

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("系统出错,请重试!");
                return;
            }

            if (flg)
            {
                MessageBox.Show("操作成功!");
            }
            else
            {
                MessageBox.Show("操作失败!");
            }

            if (((Control)sender).Name == "btnSave")
            {
                this.Close();
                this.Dispose();
                frmService frm = new frmService(_guid);
                frm.ShowDialog(frmMain.Main);
            }
            else
            {
                this.Close();
            }

            //刷新激活的窗体
            for (int i = 0; i < frmMain.Main.DockPanelMain.Contents.Count; i++)
            {
                if (frmMain.Main.DockPanelMain.Contents[i]
                    is dockService)
                {
                    dockService dock = (dockService)
                        frmMain.Main.DockPanelMain.Contents[i];
                    dock.GetData();
                }
            }
        }

        private void cbxCustomerGroup_Leave(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();

            string where = "";

            if (cbxCustomerGroup.SelectedNode.Name !=
                Guid.Empty.ToString() &&
                cbxCustomerGroup.SelectedNode.Name != null)
            {
                GetWhere(ref lst, new Guid(cbxCustomerGroup.SelectedNode.Name));
                where = string.Format("parentGUID in ({0})",
                    string.Join(",", lst.ToArray()));
            }

            BLL.ViewOperator bll = new BLL.ViewOperator();
            DataTable dt = bll.GetList("V_Customer", where).Tables[0];

            cbxName.DataSource = dt;
            cbxName.DisplayMember = "客户名称";
            cbxName.ValueMember = "GUID";
        }

        /// <summary>
        /// 获取条件
        /// </summary>
        /// <returns></returns>
        private void GetWhere(ref List<string> lst, Guid guid)
        {
            lst.Add(string.Format("'{0}'", guid));

            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            Model.CustomerGroup model = new Model.CustomerGroup();

            DataTable dt = bll.GetList(string.Format("parentGUID = '{0}'", guid)).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GetWhere(ref lst, new Guid(dt.Rows[i][0].ToString()));
            }
        }
    }
}
