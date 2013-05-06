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
    public partial class dockCustomer : DockContent
    {
        public dockCustomer()
        {
            InitializeComponent();
        }

        public Guid GUID
        {
            get;
            set;
        }

        private void dockCustomer_Load(object sender, EventArgs e)
        {
            GetData();
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

        public void GetData()
        {
            List<string> lst = new List<string>();

            string where = "";

            if (GUID != Guid.Empty)
            {
                GetWhere(ref lst, GUID);
                where = string.Format("parentGUID in ({0})",
                    string.Join(",", lst.ToArray()));
            }

            BLL.ViewOperator bll = new BLL.ViewOperator();
            DataTable dt = bll.GetList(
                "V_Customer", 
                "客户编号",
                winFormPager1.PageSize, 
                winFormPager1.PageIndex, 
                where).Tables[0];

            winFormPager1.RecordCount = bll.GetListCount("V_Customer", where);

            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dtbl = bllArgument.GetList("type = '客户编号'").Tables[0];

            string strNO = dtbl.Rows[0][1].ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
			{
                dt.Rows[i][1] = strNO + dt.Rows[i][1];
			}

            this.dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
        }

        private void winFormPager1_PageIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Model.Customer model = new Model.Customer();
            model.GUID = new Guid(this.dataGridView1[0, 
                this.dataGridView1.CurrentRow.Index].Value.ToString());
            frmCustomer frm = new frmCustomer(model);
            frm.ShowDialog(frmMain.Main);
        }
    }
}
