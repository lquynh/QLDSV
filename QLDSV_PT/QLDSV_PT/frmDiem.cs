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

namespace QLDSV_PT
{
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        List<int> check = new List<int>();
        List<int> soLanThi = new List<int>();
        int lanthi;

        public frmDiem()
        {
            soLanThi.Add(1);
            soLanThi.Add(2);
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.Bds_Dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.MKhoa;

            if (Program.MGroup == Program.NhomQuyen[1])
            {
                cmbKhoa.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = true;
            }

            btnGhi.Enabled = btnCapNhat.Enabled = false;

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cmbLanThi.DataSource = soLanThi;
            cmbLanThi.SelectedIndex = 0;
            sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
        }


        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLop.Text = txtMonHoc.Text = "";
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;     // lấy data của Site tương ứng
                this.lOPTableAdapter.Fill(dS.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                this.sP_LAYDIEMSINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            }
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMonHoc.Text = cmbMonHoc.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLop.Text = cmbLop.SelectedValue.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void btnBatDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Lớp", "Thông báo !", MessageBoxButtons.OK);
            }
            else if (txtMonHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Môn học", "Thông báo !", MessageBoxButtons.OK);
            }
            else
            {
                this.check = new List<int>();
                lanthi = int.Parse(cmbLanThi.SelectedValue.ToString());
                MessageBox.Show("Mã lớp: " + txtLop.Text.Trim() + ", Mã môn học: " + txtMonHoc.Text.Trim() + ", Lần thi: " + lanthi,
                                                "Xác nhận", MessageBoxButtons.OK);
                try
                {
                    if (lanthi == 1)
                    {
                        sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanthi);
                        if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanthi) == 0)
                        {
                            btnGhi.Enabled = true;
                            btnCapNhat.Enabled = false;
                            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                            {
                                ((DataRowView)bdsSPDIEMSV[i])["DIEM"] = 0;
                            }
                        }
                        else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanthi) == 1)
                        {
                            if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 2) == 0)
                            {
                                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                                {
                                    if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                                    {
                                        check.Add(1);
                                    }
                                    else
                                    {
                                        check.Add(0);
                                    }
                                }
                                btnGhi.Enabled = false;
                                btnCapNhat.Enabled = true;
                            }
                            else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 2) == 1)
                            {
                                btnGhi.Enabled = false;
                                btnCapNhat.Enabled = false;
                            }
                        }
                    }
                    else if (lanthi == 2)
                    {
                        sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanthi);
                        if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 1) == 0)
                        {
                            MessageBox.Show("Sinh viên chưa có điểm lần 1 cho môn học này. Vui lòng nhập điểm lần 1 cho môn học này !", "Thông báo !", MessageBoxButtons.OK);
                            btnGhi.Enabled = false;
                            btnCapNhat.Enabled = false;
                            return;
                        }
                        else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, 1) == 1)
                        {
                            sP_LAYDIEMSINHVIENTableAdapter.Fill(dS.SP_LAYDIEMSINHVIEN, txtLop.Text, txtMonHoc.Text, lanthi);
                            if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanthi) == 0)
                            {
                                btnGhi.Enabled = true;
                                btnCapNhat.Enabled = false;
                                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                                {
                                    ((DataRowView)bdsSPDIEMSV[i])["DIEM"] = 0;
                                }
                            }
                            else if (kiemtradiemtheolan(txtLop.Text, txtMonHoc.Text, lanthi) == 1)
                            {
                                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                                {
                                    if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                                    {
                                        check.Add(1);
                                    }
                                    else
                                    {
                                        check.Add(0);
                                    }
                                }
                                btnGhi.Enabled = false;
                                btnCapNhat.Enabled = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("NO STUDENTS"))
                    {
                        MessageBox.Show("Lớp hiện không có sinh viên. Vui lòng chọn lớp khác", "Thông báo !", MessageBoxButtons.OK);
                        btnCapNhat.Enabled = btnGhi.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
            {
                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "")
                {
                    MessageBox.Show("Điểm không được bỏ trống", "Thông báo !", MessageBoxButtons.OK);
                    bdsSPDIEMSV.Position = i;
                    check = true;
                    break;
                }
                else
                {
                    float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                    if (diem < 0 || diem > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 - 10");
                        bdsSPDIEMSV.Position = i;
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                {
                    float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                    if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
                    String str_sp = "dbo.SP_INSERTDIEM";
                    Program.Sqlcmd = Program.Conn.CreateCommand();
                    Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.Sqlcmd.CommandText = str_sp;
                    Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString();
                    Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMonHoc.Text;
                    Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lanthi;
                    Program.Sqlcmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                    Program.Sqlcmd.ExecuteNonQuery();
                    Program.Conn.Close();
                    this.check.Add(0);
                }
                MessageBox.Show("Ghi điểm hoàn tất", "Thông báo !", MessageBoxButtons.OK);
                btnGhi.Enabled = false;
                btnCapNhat.Enabled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = false;
            for (int i = 0; i < bdsSPDIEMSV.Count; i++)
            {
                if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() == "" && this.check[i] == 0)
                {
                    MessageBox.Show("Điểm không được bỏ trống", "Thông báo !", MessageBoxButtons.OK);
                    bdsSPDIEMSV.Position = i;
                    check = true;
                    break;
                }
                else
                {
                    if (((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() != "")
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (diem < 0 || diem > 10)
                        {
                            MessageBox.Show("Điểm phải >= 0 hoặc <= 10. Vui lòng kiểm tra lại !");
                            bdsSPDIEMSV.Position = i;
                            check = true;
                            break;
                        }
                    }
                }
            }
            if (!check)
            {
                for (int i = 0; i < bdsSPDIEMSV.Count; i++)
                {
                    if (this.check[i] == 0) //update cho sv cũ
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
                        String str_sp = "dbo.SP_UPDATEDIEM";
                        Program.Sqlcmd = Program.Conn.CreateCommand();
                        Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.Sqlcmd.CommandText = str_sp;
                        Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString();
                        Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMonHoc.Text;
                        Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lanthi;
                        Program.Sqlcmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                        Program.Sqlcmd.ExecuteNonQuery();
                        Program.Conn.Close();
                    }
                    else if (this.check[i] == 1 && ((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString() != "") //ghi cho sv mới chuyển lớp qua
                    {
                        float diem = float.Parse(((DataRowView)bdsSPDIEMSV[i])["DIEM"].ToString());
                        if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
                        String str_sp = "dbo.SP_INSERTDIEM";
                        Program.Sqlcmd = Program.Conn.CreateCommand();
                        Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.Sqlcmd.CommandText = str_sp;
                        Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = ((DataRowView)bdsSPDIEMSV[i])["MASV"].ToString();
                        Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMonHoc.Text;
                        Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lanthi;
                        Program.Sqlcmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                        Program.Sqlcmd.ExecuteNonQuery();
                        Program.Conn.Close();
                        this.check[i] = 0;
                    }
                }
                MessageBox.Show("Cập nhật điểm hoàn tất", "Thông báo !", MessageBoxButtons.OK);
            }
        }

        private int kiemtradiemtheolan(string malop, string mamh, int lan)
        {
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            String str_sp = "dbo.SP_KIEMTRADIEMTHEOLAN";
            Program.Sqlcmd = Program.Conn.CreateCommand();
            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.Sqlcmd.CommandText = str_sp;
            Program.Sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = malop;
            Program.Sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = mamh;
            Program.Sqlcmd.Parameters.Add("@LAN", SqlDbType.Int).Value = lan;
            //Program.Sqlcmd.Parameters.Add("@LOAI", SqlDbType.NChar).Value = "A";
            Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.Sqlcmd.ExecuteNonQuery();
            String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có điểm
            }
            else if (ret == "0")
            {
                return 0; //chưa có điểm
            }
            return 0;
        }
    }
}


