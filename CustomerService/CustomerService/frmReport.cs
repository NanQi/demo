using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CustomerService.Report;

namespace CustomerService
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnCustomerPie_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource =
                frmMain.Main.GetReport<rptCustomerPie>("Customer", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource =
                frmMain.Main.GetReport<rptServiceTotal>("Service", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

            rptServiceMonth rpt = (rptServiceMonth)frmMain.Main.GetReport<rptServiceMonth>("Service", "DATEDIFF(MONTH, '" + dt + "', 受理时间) = 0");
            //设置月份
            TextObject obj = (TextObject)rpt.Section1.ReportObjects["Text1"];
            obj.Text = dt.ToString("yyyy年MM月");
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
