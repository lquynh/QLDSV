using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_PT.Report
{
    public partial class INPD : DevExpress.XtraReports.UI.XtraReport
    {
        public INPD(string MASV)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            sP_REPORT_PDTableAdapter1.Connection.ConnectionString = Program.connstr;
            sP_REPORT_PDTableAdapter1.Fill(ds1.SP_REPORT_PD, MASV);
        }
    }
}
