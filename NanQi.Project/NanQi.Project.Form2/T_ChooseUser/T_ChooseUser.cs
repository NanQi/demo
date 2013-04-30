using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using NanQi.Framework.Presentation;

namespace NanQi.Project.Form2
{
    public partial class T_ChooseUser : NanQi.Framework.Control.NormalTradeWindow
    {
        public T_ChooseUser()
        {
            InitializeComponent();
            this.TradeClosed += T_ChooseUser_TradeClosed;
        }

        private void T_ChooseUser_Load(object sender, EventArgs e)
        {
            IEnumerable source = ViewState["UserList"] as IEnumerable;
            foreach (var item in source)
            {
                listView1.Items.Add(item.ToString());
            }
        }

        void T_ChooseUser_TradeClosed(object sender, TradeClosedEventArgs e)
        {
            e.ExportArgs = new Dictionary<string, object>();
            List<string> lst = new List<string>();

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                lst.Add(item.Text);
            }
            e.ExportArgs.Add("ChooseList", lst);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
