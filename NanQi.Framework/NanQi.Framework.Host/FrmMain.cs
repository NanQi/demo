using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NanQi.Framework.Presentation;
using System.ComponentModel.Composition;

namespace NanQi.Framework.Host
{
    [Export(typeof(IMain))]
    public partial class FrmMain : Form, IMain
    {
        FrmSolution _frmSolution;

        public FrmMain()
        {
            InitializeComponent();

            _frmSolution = new FrmSolution(this);
            _frmSolution.Show(this.tradeContainer1);
        }

        public TradeContainer TradeContainer
        {
            get { return tradeContainer1; }
        }

        public void LoadMenu(IEnumerable<TradeMenu> menuSource)
        {
            List<TreeNode> lstTreeNode = new List<TreeNode>();

            foreach (var category in menuSource)
            {
                TreeNode tn = new TreeNode(category.Title);
                tn.Tag = category;

                lstTreeNode.Add(tn);

                if (category.Children != null)
                {
                    LoadTreeNode(category, tn);
                }
            }

            _frmSolution.SetTreeNodes(lstTreeNode);
        }

        void LoadTreeNode(TradeMenu category, TreeNode parentTreeNode)
        {
            foreach (var trade in category.Children)
            {
                TreeNode tn = new TreeNode(trade.Title);
                tn.Tag = trade;
                parentTreeNode.Nodes.Add(tn);

                if (trade.Children != null)
                {
                    LoadTreeNode(trade, tn);
                }

            }
        }


    }
}
