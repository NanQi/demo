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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(Model.Customer model)
        {
            InitializeComponent();
            _model = model;
            _guid = model.parentGUID;
        }

        public frmCustomer(Guid guid)
        {
            InitializeComponent();
            _guid = guid;
        }

        Model.Customer _model;
        Guid _guid;

        private void llblMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.pnlMore.Visible)
            {
                return;
            }

            this.Height = 600;
            this.pnlMore.Visible = true;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.Height = 422;

            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            this.cbxCustomerGroup.Nodes.Add(bll.GetCustomerGroup());
            this.cbxCustomerGroup.Nodes[0].Toggle();
            GetCustomerGroup(_guid);

            //加载省列表
            cbxProvince.DataSource = DBUtility.XMLHelper.GetProvinces();
            cbxProvince.DisplayMember = "ProvinceName";
            cbxProvince.ValueMember = "ID";
            cbxProvince.SelectedValue = 27;

            cbxProvince_SelectedIndexChanged(null, null);
            cbxCity_SelectedIndexChanged(null, null);
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.cbxCity_SelectedIndexChanged);

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
        /// 新增信息初始化
        /// </summary>
        private void GetAdd()
        {
            GetCustomerNo();

            this.Text = "新增客户信息";
            this.btnSave.Visible = true;
            //默认赋值
            cbxIsGov.SelectedIndex = 0;
            cbxStage.SelectedIndex = 2;
            cbxType.SelectedIndex = 2;
            cbxLevel.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
        }
        /// <summary>
        /// 修改信息初始化
        /// </summary>
        private void GetUpdate()
        {
            this.Text = "编辑客户信息";
            BLL.Customer bll = new BLL.Customer();
            Model.Customer model = bll.GetModel(_model.GUID);
            this.llblAddService.Visible = true;
            this.llblService.Visible = true;

            //赋值
            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dt = bllArgument.GetList("type = '客户编号'").Tables[0];

            string str = dt.Rows[0][1].ToString();

            txtNO.Text = str + model.cNO;
            txtName.Text = model.cName;

            //获得所属客户组
            BLL.CustomerGroup bllGroup = new BLL.CustomerGroup();
            List<string> lst = new List<string>();
            bllGroup.GetSelected(ref lst, model.parentGUID);

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
                model.parentGUID.ToString(), true))[0];

            cbxIsGov.SelectedIndex = Convert.ToInt32(!model.isGov);
            txtTrade.Text = model.trade;
            txtMan.Text = model.cMan;
            txtTel.Text = model.Tel;
            txtFax.Text = model.fax;
            txtEmail.Text = model.email;
            cbxProvince.Text = model.province;
            cbxCity.Text = model.city;
            cbxDistrict.Text = model.district;
            txtQQ.Text = model.QQ;
            txtMode.Text = model.mode;
            txtScope.Text = model.scope;
            txtProduct.Text = model.product;
            txtAddress.Text = model.addresss;
            cbxStage.Text = model.cStage;
            cbxType.Text = model.cType;
            cbxLevel.Text = model.cLevel;
            cbxStatus.Text = model.cStatus;
            txtLink1.Text = model.link1;
            txtTel1.Text = model.tel1;
            txtLink2.Text = model.link2;
            txtTel2.Text = model.tel2;
        }
        /// <summary>
        /// 获取新增客户编号
        /// </summary>
        private void GetCustomerNo()
        {
            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dt = bllArgument.GetList("type = '客户编号'").Tables[0];

            string str = dt.Rows[0][1].ToString();

            BLL.Customer bllCustomer = new BLL.Customer();
            txtNO.Text = str + bllCustomer.GetMaxID();
        }
        /// <summary>
        /// 或许所属客户组
        /// </summary>
        /// <param name="guid"></param>
        private void GetCustomerGroup(Guid guid)
        {
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            List<string> lst = new List<string>();
            bll.GetSelected(ref lst, guid);

            StringBuilder sb = new StringBuilder();

            for (int i = lst.Count - 1; i > 0; i--)
            {
                sb.Append(lst[i]);
                sb.Append(this.cbxCustomerGroup.BranchSeparator);
            }

            sb.Append(lst[0]);

            this.cbxCustomerGroup.Text = sb.ToString();
            this.cbxCustomerGroup.SelectedNode = (this.cbxCustomerGroup.Nodes.Find(guid.ToString(), true))[0];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(this.txtNO.Text.Trim()))
            {
                errorProvider1.SetError(txtNO, "客户编号不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "客户名称不能为空!");
                return;
            }

            if (!this.cbxCustomerGroup.ValidateText())
            {
                errorProvider1.SetError(cbxCustomerGroup,
                    "必须选择所属客户组!");
                return;
            }

            BLL.Customer bll = new BLL.Customer();
            Model.Customer model = new Model.Customer();
            model.cNO = txtNO.Text.Substring(txtNO.Text.Length - 4);
            model.cName = txtName.Text.Trim();
            model.parentGUID = new Guid(this.cbxCustomerGroup.SelectedNode.Name);
            if (cbxIsGov.Text != "政府")
            {
                model.isGov = false;
            }
            else
            {
                model.isGov = true;
            }
            model.trade = txtTrade.Text.Trim();
            model.cMan = txtMan.Text.Trim();
            model.Tel = txtTel.Text.Trim();
            model.fax = txtFax.Text.Trim();
            model.email = txtEmail.Text.Trim();
            model.province = cbxProvince.Text;
            model.city = cbxCity.Text;
            model.district = cbxDistrict.Text;
            model.QQ = txtQQ.Text.Trim();
            model.mode = txtMode.Text.Trim();
            model.scope = txtScope.Text.Trim();
            model.product = txtProduct.Text.Trim();
            model.addresss = txtAddress.Text.Trim();
            model.cStage = cbxStage.Text;
            model.cType = cbxType.Text;
            model.cLevel = cbxLevel.Text;
            model.cStatus = cbxStatus.Text;
            model.link1 = txtLink1.Text.Trim();
            model.tel1 = txtTel1.Text.Trim();
            model.link2 = txtLink2.Text.Trim();
            model.tel2 = txtTel2.Text.Trim();

            bool flg = false;

            try
            {
                if (this.Text == "新增客户信息")
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
                frmCustomer frm = new frmCustomer(_guid);
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
                    is dockCustomer)
                {
                    dockCustomer dock = (dockCustomer)
                        frmMain.Main.DockPanelMain.Contents[i];
                    dock.GetData();
                }
            }
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCity.DataSource = DBUtility.XMLHelper.GetCities(
                Convert.ToInt32(this.cbxProvince.SelectedValue));
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "ID";
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDistrict.DataSource = DBUtility.XMLHelper.GetDistricts(
                   Convert.ToInt32(this.cbxCity.SelectedValue));
            cbxDistrict.DisplayMember = "DistrictName";
            cbxDistrict.ValueMember = "ID";

        }

        private void llblService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

            for (int i = 0; i < frmMain.Main.DockPanelMain.Contents.Count; i++)
            {
                if (frmMain.Main.DockPanelMain.Contents[i] is dockService)
                {
                    dockService dc =
                        (dockService)frmMain.Main.DockPanelMain.Contents[i];
                    if (dc.GUID == _model.GUID)
                    {
                        if (!(dc.GUID == Guid.Empty) &&
                            dc.TabText.Substring(5) !=
                             txtName.Text.Trim())
                        {
                            string str = "客户信息-";
                            dc.TabText = str + txtName.Text.Trim();
                        }

                        dc.Focus();
                        dc.GetData();
                        return;
                    }
                }
            }

            dockService dock = new dockService();
            if (!(_model.GUID == Guid.Empty))
            {
                dock.TabText += "-" + txtName.Text.Trim();
            }
            dock.GUID = _model.GUID;
            dock.Show(frmMain.Main.DockPanelMain);
        }

        private void llblAddService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmService frm = new frmService(_model.GUID);
            frm.ShowDialog(frmMain.Main);
        }
    }
}
