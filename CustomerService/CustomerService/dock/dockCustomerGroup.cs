using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CustomerService
{
    public partial class dockCustomerGroup : DockContent
    {
        public dockCustomerGroup()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < frmMain.Main.DockPanelMain.Contents.Count; i++)
            {
                if (frmMain.Main.DockPanelMain.Contents[i] is dockCustomer)
                {
                    dockCustomer dc =
                        (dockCustomer)frmMain.Main.DockPanelMain.Contents[i];
                    if (dc.GUID.ToString() == e.Node.Name)
                    {
                        if (!(dc.GUID == Guid.Empty) && 
                            dc.TabText.Substring(5) != 
                             e.Node.Text)
                        {
                            string str = "客户信息-";
                            dc.TabText = str + e.Node.Text;
                        }

                        dc.Focus();
                        dc.GetData();
                        return;
                    }
                }
            }

            dockCustomer dock = new dockCustomer();
            if (!(e.Node.Name == Guid.Empty.ToString()))
            {
                dock.TabText += "-" + e.Node.Text;
            }
            dock.GUID = new Guid(e.Node.Name);
            dock.Show(frmMain.Main.DockPanelMain);
        }

        private void dockCustomerGroup_Load(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Items[0].Visible = false;
            this.contextMenuStrip1.Items[1].Visible = false;
            GetData();
        }

        public void GetData()
        {
            this.treeView1.Nodes.Clear();
            BLL.CustomerGroup bll = new BLL.CustomerGroup();
            this.treeView1.Nodes.Add(bll.GetCustomerGroup());
            this.treeView1.Nodes[0].Toggle();
        }

        private void 新增客户组1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerGroup frm = new frmCustomerGroup();
            frm.ShowDialog(frmMain.Main);
        }

        private void 修改客户组2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.CustomerGroup model = new Model.CustomerGroup();
            model.GUID = new Guid(this.treeView1.SelectedNode.Name);
            model.cName = this.treeView1.SelectedNode.Text;

            frmCustomerGroup frm = new frmCustomerGroup(model);
            frm.ShowDialog(frmMain.Main);
        }

        private void 删除客户组3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认删除?", "删除确认",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                BLL.CustomerGroup bll = new BLL.CustomerGroup();

                bool flg = false;

                try
                {
                    flg = bll.Delete(new Guid(this.treeView1.SelectedNode.Name));
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

                GetData();
            }
        }

        private void 新增客户信息1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer(new Guid(this.treeView1.SelectedNode.Name));
            frm.ShowDialog(frmMain.Main);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.treeView1.SelectedNode == null)
            {
                return;
            }

            if (this.treeView1.SelectedNode.Nodes.Count != 0)
            {
                this.contextMenuStrip1.Items[0].Visible = false;
                this.contextMenuStrip1.Items[1].Visible = false;
            }
            else
            {
                this.contextMenuStrip1.Items[0].Visible = true;
                this.contextMenuStrip1.Items[1].Visible = true;
            }
        }
    }
}
