using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elevator_Manager
{
    public partial class ucPrint : UserControl
    {
        public ucPrint()
        {
            InitializeComponent();
        }

        public ucPrint(DataTable dtbl, string tblName)
        {
            InitializeComponent();
            this._dtbl = dtbl;
            this._tblName = tblName;
        }

        #region 字段和属性

        private DataTable _dtbl;
        private string _tblName;

        #endregion

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            switch (this._tblName)
            {
                case "Service":
                    Service service = new Service();
                    service.SetDataSource(this._dtbl);
                    this.crystalReportViewer1.ReportSource = service;
                    break;
                case "Lift":
                    Lift lift = new Lift();
                    lift.SetDataSource(this._dtbl);
                    this.crystalReportViewer1.ReportSource = lift;
                    break;
                default:
                    break;
            }
        }
    }
}
