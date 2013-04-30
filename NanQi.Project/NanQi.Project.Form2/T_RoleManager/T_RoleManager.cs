using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NanQi.Project.Form2
{
    public partial class T_RoleManager : NanQi.Framework.Control.NormalTradeWindow
    {
        public T_RoleManager()
        {
            InitializeComponent();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            FrmDialog frm = new FrmDialog();
            frm.ShowDialog(this);
        }
    }
}
