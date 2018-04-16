using MagZamotane4.Core;
using System;
using System.Collections.Generic;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace MagZamotane4
{
    public partial class frmPrint : MetroFramework.Forms.MetroForm
    {
        List<Product> _list;

        public frmPrint(List<Product> list)
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
            _list = list;
        }

        private ReportDocument cry = new ReportDocument();

        private void frmPrint_Load(object sender, EventArgs e)
        {
            cry.Load(Directory.GetCurrentDirectory() + @"\rpt\CrystalReport2.rpt");
            cry.SetDataSource(_list);
            crystalReportViewer.ReportSource = cry;
        }
    }
}
