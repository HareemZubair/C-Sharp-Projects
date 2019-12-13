using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace database
{
    public partial class crystal : Form
    {

        ReportDocument RD = new ReportDocument();
        public crystal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RD.Load(Application.StartupPath + "//CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = RD;
            crystalReportViewer1.Refresh();
        }

        private void crystal_Load(object sender, EventArgs e)
        {
            RD.Load(Application.StartupPath + "//CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = RD;
            crystalReportViewer1.Refresh();
        }
    }
}
