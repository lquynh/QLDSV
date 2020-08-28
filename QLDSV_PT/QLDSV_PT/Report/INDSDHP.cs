using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV_PT.Report
{
    public partial class INDSDHP : DevExpress.XtraReports.UI.XtraReport
    {
        public INDSDHP(string malopx, string nienkhoa, int hocky)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_REPORT_DSDHPTableAdapter1.Fill(ds1.SP_REPORT_DSDHP, malopx, nienkhoa, hocky);
        }

    }
}
