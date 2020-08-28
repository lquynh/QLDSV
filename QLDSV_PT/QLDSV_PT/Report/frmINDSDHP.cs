using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLDSV_PT.Report
{
    public partial class frmINDSDHP : DevExpress.XtraEditors.XtraForm
    {
        public frmINDSDHP()
        {
            InitializeComponent();
        }

        private void load_1()
        {
            string sql = "SELECT NIENKHOA FROM HOCPHI GROUP BY NIENKHOA";

            try
            {
                Program.MyReader = Program.ExecSqlDataReader(sql);

                DataTable dt = new DataTable();
                dt.Load(Program.MyReader);
                cmbNienKhoa.DataSource = dt;
                cmbNienKhoa.DisplayMember = "NIENKHOA";
                cmbNienKhoa.ValueMember = "NIENKHOA";
                cmbNienKhoa.SelectedIndex = 0;
                Program.MyReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi load dữ liệu");
            }
        }

        private void frmINDSDHP_Load(object sender, EventArgs e)
        {
            cmbHocKy.Items.Add(1);
            cmbHocKy.Items.Add(2);
            cmbHocKy.SelectedIndex = 0;
            load_1();
        }
        private void btnManHinh_Click(object sender, EventArgs e)
        {
            string malop = txtLop.Text.Trim();
            if (malop.Length < 5)
            {
                MessageBox.Show("Mã lớp phải nhiều hơn 5 kí tự ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nienkhoa = cmbNienKhoa.SelectedValue.ToString();
            string hocky = cmbHocKy.SelectedItem.ToString();

            this.sP_REPORT_DSDHPTableAdapter.Fill(dS.SP_REPORT_DSDHP, malop, nienkhoa, Int32.Parse(hocky));
            if (this.bdsReportDSDHP.Count == 0)
            {
                MessageBox.Show("Không có thông tin để hiển thị !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            string malop = txtLop.Text.Trim();
            if (malop.Length < 5)
            {
                MessageBox.Show("Mã lớp phải nhiều hơn 5 kí tự ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nienkhoa = cmbNienKhoa.SelectedValue.ToString();
            string hocky = cmbHocKy.SelectedItem.ToString();


            INDSDHP xpr = new INDSDHP(malop, nienkhoa, Int32.Parse(hocky));
            xpr.xrLabel3.Text = "Lớp : " + malop + " Học kỳ " + hocky + " Niên khóa : " + nienkhoa + "  ";
            ReportPrintTool print = new ReportPrintTool(xpr);
            print.ShowPreviewDialog();
        }       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}