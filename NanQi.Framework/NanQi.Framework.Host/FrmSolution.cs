using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NanQi.Framework.Control;
using NanQi.Framework.Presentation;

namespace NanQi.Framework.Host
{
    public partial class FrmSolution :ToolWindow
    {
        FrmMain _mainForm;

        public FrmSolution(FrmMain frm)
        {
            InitializeComponent();
            _mainForm = frm;
        }

        public void SetTreeNodes(IEnumerable<TreeNode> treeNodes)
        {
            treeView1.Nodes.Clear();

            foreach (var tn in treeNodes)
            {
                treeView1.Nodes.Add(tn);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            if (node == null) return;

            if (node.Tag != null)
            {
                TradeMenu trade = node.Tag as TradeMenu;
                if (trade == null) return;

                try
                {
                    if (!string.IsNullOrEmpty(trade.ActionName))
                    {
                        _mainForm.TradeContainer.OpenTrade(trade.ActionName);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(string.Format("无法打开交易 {0}", trade.ActionName));
                }
            }
        }
    }
}
