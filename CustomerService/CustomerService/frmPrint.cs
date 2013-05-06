using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CustomerService
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public frmPrint(ReportClass rpt)
        {
            InitializeComponent();
            this._rpt = rpt;
        }

        ReportClass _rpt;

        private void frmPrint_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = this._rpt;
        }
    }
}
