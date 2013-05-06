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
    public partial class frmCustomerGroup : Form
    {
        public frmCustomerGroup()
        {
            InitializeComponent();
        }

        public frmCustomerGroup(Model.CustomerGroup model)
        {
            InitializeComponent();
            _model = model;
        }

        Model.CustomerGroup _model;

        private void frmAddCustomerGroup_Load(object sender, EventArgs e)
        {
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            this.cbxTreeCustomerGroup.Nodes.Add(bll.GetCustomerGroup());
            this.cbxTreeCustomerGroup.Nodes[0].Toggle();
            if (this._model != null)
            {
                GetUpdate();
            }
        }

        private void GetUpdate()
        {
            this.Text = "编辑客户组";
            txtName.Text = _model.cName;
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            List<string> lst = new List<string>();
            bll.GetParentSelected(ref lst, _model.GUID);

            StringBuilder sb = new StringBuilder();

            for (int i = lst.Count - 1; i > 0; i--)
            {
                sb.Append(lst[i]);
                sb.Append(this.cbxTreeCustomerGroup.BranchSeparator);
            }

            sb.Append(lst[0]);

            this.cbxTreeCustomerGroup.Text = sb.ToString();
            this.cbxTreeCustomerGroup.SelectedNode = bll.GetParentSelectedNode(this.cbxTreeCustomerGroup.Nodes, _model.GUID);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "客户组名称不能为空!");
                return;
            }

            if (!this.cbxTreeCustomerGroup.ValidateText())
            {
                errorProvider1.SetError(cbxTreeCustomerGroup, 
                    "必须选择所属客户组!");
                return;
            }

            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            Model.CustomerGroup model = new Model.CustomerGroup();
            model.cName = txtName.Text.Trim();
            model.parentGUID = new Guid(this.cbxTreeCustomerGroup.SelectedNode.Name);

            bool flg = false;

            try
            {
                if (this.Text == "新增客户组")
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

            this.Close();
            frmMain.Main.DockCustomerGroup.GetData();
        }

    }
}
