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
    public partial class frmINPD : DevExpress.XtraEditors.XtraForm
    {
        String masv = "";
        public frmINPD()
        {
            InitializeComponent();
        }

        private void frmINPD_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.Bds_Dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.MKhoa;

            if (Program.MGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            sP_REPORT_PDTableAdapter.Connection.ConnectionString = Program.connstr;
            btnInPD.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Program.ServerName = cmbKhoa.SelectedValue.ToString();
            }
            if (cmbKhoa.SelectedIndex != Program.MKhoa)
            {
                Program.MLogin = Program.RemoteLogin;
                Program.MPassword = Program.RemotePassword;
            }
            else
            {
                Program.MLogin = Program.MLoginDN;
                Program.MPassword = Program.PasswordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                dS.EnforceConstraints = false;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                sP_REPORT_PDTableAdapter.Connection.ConnectionString = Program.connstr;
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (masv.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    sP_REPORT_PDTableAdapter.Fill(dS.SP_REPORT_PD, masv);
                    if (bdsReportPD.Count == 0)
                    {
                        MessageBox.Show("Sinh viên chưa có điểm để in", "Thông báo !", MessageBoxButtons.OK);
                        btnInPD.Enabled = false;
                    }
                    else
                    {
                        btnInPD.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("NO STUDENT"))
                    {
                        MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo !", MessageBoxButtons.OK);
                        btnInPD.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void btnInPD_Click(object sender, EventArgs e)
        {
            INPD rpt = new INPD(masv);
            rpt.lblMSSV.Text += masv;
            rpt.lblHoTen.Text += txtHo.Text.Trim() + " " + txtTen.Text.Trim();
            rpt.lblLop.Text += cmbLop.Text.Trim();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                masv = cmbMaSV.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }
    }
}