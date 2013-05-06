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
    public partial class dockService : DockContent
    {
        public dockService()
        {
            InitializeComponent();
        }

        public Guid GUID
        {
            get;
            set;
        }

        private void dockService_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string where = "";

            if (!(GUID == Guid.Empty))
            {
                 where= "customerGUID = '" + GUID + "'";
            }

            BLL.ViewOperator bll = new BLL.ViewOperator();
            DataTable dt = bll.GetList(
                "V_Service",
                "服务编号",
                winFormPager1.PageSize,
                winFormPager1.PageIndex,
                where).Tables[0];

            winFormPager1.RecordCount = bll.GetListCount("V_Service", where);

            BLL.Argument bllArgument = new BLL.Argument();
            DataTable dtbl = bllArgument.GetList("type = '服务编号'").Tables[0];

            string strNO = dtbl.Rows[0][1].ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][1] = strNO + dt.Rows[i][1];
            }

            this.dataGridView1.DataSource = dt;

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
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

            Model.Service model = new Model.Service();
            model.GUID = new Guid(this.dataGridView1[0,
                this.dataGridView1.CurrentRow.Index].Value.ToString());
            frmService frm = new frmService(model);
            frm.ShowDialog(frmMain.Main);
        }
    }
}
