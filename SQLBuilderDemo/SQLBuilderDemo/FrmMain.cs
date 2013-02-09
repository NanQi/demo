using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SQLBuilderDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Add("±Ì(Table)");
            this.treeView1.Nodes.Add(" ”Õº(View)");

            TableData[] tables = LoadTestData.GetTestData();

            TreeNode tn;

            foreach (TableData table in tables)
            {
                tn = new TreeNode(table.ToString());
                tn.Name = table.ID.ToString();
                tn.Tag = table;
                this.treeView1.Nodes[0].Nodes.Add(tn);
            }

            this.treeView1.ExpandAll();
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode tn = e.Item as TreeNode;
            if ((e.Button == MouseButtons.Left) && (tn != null) && tn.Tag is TableData) 
            {
                treeView1.SelectedNode = tn;
                treeView1.DoDragDrop(tn, DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Link);
            } 
        }

        private void tablePanel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode tn = e.Data.GetData(typeof(TreeNode)) as TreeNode;

                FrmTable table;
                for (int i = 0; i < tablePanel1.Controls.Count; i++)
                {
                    if (tablePanel1.Controls[i] is FrmTable)
                    {
                        table = tablePanel1.Controls[i] as FrmTable;

                        if (table.Table.ID.ToString() == tn.Name)
                        {
                            e.Effect = DragDropEffects.None;
                            return;
                        }
                    }
                }

                e.Effect = DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tablePanel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                TreeNode tn = e.Data.GetData(typeof(TreeNode)) as TreeNode;

                if (tn != null && tn.Tag is TableData)
                {
                    FrmTable frm = new FrmTable(tn.Tag as TableData);
                    frm.MdiParent = this;
                    frm.Location = tablePanel1.PointToClient(new Point(e.X, e.Y));
                    this.tablePanel1.Controls.Add(frm);
                    frm.Show();
                }
            }
        }

    }
}