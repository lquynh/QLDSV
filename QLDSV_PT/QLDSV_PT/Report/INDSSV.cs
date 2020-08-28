using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_PT.Report
{
    public partial class INDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        private string mlop;

        public INDSSV(string malopx)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_DSSVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_REPORT_DSSVTableAdapter1.Fill(ds1.SP_REPORT_DSSV, malopx);
        }
    }
}
