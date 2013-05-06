using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CustomerService.DBUtility;

namespace CustomerService
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("客户服务管理系统", new Font("宋体", 15), new SolidBrush(Color.Black), 90, 20);
            g.DrawString("CustomerService", new Font("宋体", 12), new SolidBrush(Color.Black), 130, 50);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //获取配置文件中的登录名称列表
            List<string> lst = XMLHelper.GetList();

            cbxName.Items.AddRange(lst.ToArray());
            //获取上次记住的账号
            cbxName.Text = XMLHelper.GetRememberLoginName();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;

            //errorProvider1.Clear();
            //string name = cbxName.Text.Trim();
            //string pwd = txtPwd.Text.Trim();
            //if (string.IsNullOrEmpty(name))
            //{
            //    errorProvider1.SetError(cbxName, "账号不能为空!");
            //    return;
            //}

            //if (string.IsNullOrEmpty(pwd))
            //{
            //    errorProvider1.SetError(txtPwd, "密码不能为空!");
            //    return;
            //}

            //BLL.User bll = new BLL.User();
            //Model.User model = new Model.User();

            //try
            //{
            //    //model = bll.GetModel(name);
            //}
            //catch (Exception ex)
            //{
            //    string error = ex.Message;
            //    throw;
            //}

            //if (model == null)
            //{
            //    errorProvider1.SetError(cbxName, "没有该账号!");
            //    return;
            //}

            //pwd = CustomerService.DBUtility.DESEncrypt.Encrypt(pwd);

            //if (model.Pwd == pwd)
            //{
            //    //将账号保存在配置文件中
            //    if (chbxRemember.Checked)
            //    {
            //        List<string> lst = XMLHelper.GetList();
            //        //判断登录列表里是否有此账号
            //        if (!lst.Contains(name))
            //        {
            //            XMLHelper.Append(name);
            //        }
            //        //记住账号
            //        XMLHelper.SetRemember(name);
            //    }

            //    this.Close();
            //    this.DialogResult = DialogResult.OK;

            //    frmMain frm = (frmMain)this.Owner;
            //    //frm.Login = model;
            //}
            //else
            //{
            //    errorProvider1.SetError(txtPwd, "密码错误!");
            //}
        }
    }
}
