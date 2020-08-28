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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        string maKhoa = "";
        Int32 vitri = 0;
        Boolean isEditing = true;

        Int32 vitriSV = 0;
        Boolean isEditingSV = true;

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            cmbKhoa.DataSource = Program.Bds_Dskhoa;
            cmbKhoa.DisplayMember = "TENKHOA";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.MKhoa;
            if (Program.MGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
                btnThemSV.Enabled = btnGhiSV.Enabled = btnXoaSV.Enabled = btnPhucHoiSV.Enabled = btnChuyenLopSV.Enabled = false;
            }

            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            maKhoa = ((DataRowView)bdsKHOA[0])["MAKH"].ToString().Trim();

            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);

            txtMaLop.ReadOnly = txtMaSV.ReadOnly = true;
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
                try
                {
                    dS.EnforceConstraints = false;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; // lấy data của Site tương ứng
                    this.lOPTableAdapter.Fill(this.dS.LOP);

                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    maKhoa = ((DataRowView)bdsKHOA[0])["MAKH"].ToString().Trim();

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                    this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dIEMTableAdapter.Fill(this.dS.DIEM);
                }
                catch (Exception) { }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lấy vị trí hiện tại trên gridcontrol
            vitri = bdsLOP.Position;
            isEditing = false;

            bdsLOP.AddNew();

            gcClass.Enabled = false;
            txtKhoa.Text = maKhoa;
            txtMaLop.ReadOnly = false;
            txtMaLop.Focus();

            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaLop.Focus();
            }
            else if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenLop.Focus();
            }
            else
            {
                if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
                String str_sp = "dbo.SP_CHECKTRUNGMALOP";
                Program.Sqlcmd = Program.Conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = txtMaLop.Text;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@Ret"].Value.ToString();
                if (ret == "1" && isEditing == false)
                {
                    MessageBox.Show("Mã lớp đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        bdsLOP.EndEdit(); // kết thúc quá trình hiệu chỉnh
                        bdsLOP.ResetCurrentItem(); // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực
                        this.lOPTableAdapter.Update(this.dS.LOP); // đẩy dl vừa ghi tạm về CSDL -> adapter (liên quan đến database)

                        gcClass.Enabled = true;
                        btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                        txtMaLop.ReadOnly = true;
                        isEditing = true;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("UNIQUE KEY"))
                        {
                            MessageBox.Show("Tên lớp bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi ghi Lớp. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLOP.Count == 0)
            {
                return;
            }
            else
            {
                if (bdsSV.Count > 0)
                {
                    MessageBox.Show("Lớp đang có sinh viên học, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Lớp ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsLOP.RemoveCurrent();
                            this.lOPTableAdapter.Update(this.dS.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Lớp. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }


        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            if (isEditing == false)
            {
                bdsLOP.Position = vitri;
                gcClass.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                txtMaLop.ReadOnly = true;
                isEditing = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        //BTN SINH VIÊN
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            vitriSV = bdsSV.Position;
            isEditingSV = false;

            bdsSV.AddNew();

            txtMaLopSV.Text = txtMaLop.Text;
            checkeditNam.Checked = false;
            checkeditNghiHoc.Checked = false;
            txtMaSV.ReadOnly = false;
            txtMaSV.Focus();

            sINHVIENDataGridView.Enabled = false;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnChuyenLopSV.Enabled = false;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaSV.Focus();
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtHo.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTen.Focus();
            }
            else if (txtNoiSinh.Text.Trim() == "")
            {
                MessageBox.Show("Nơi sinh không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtNoiSinh.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (dateeditNgaySinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ngày sinh !", "Thông báo !", MessageBoxButtons.OK);
            }
            else
            {
                if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
                String str_sp = "dbo.SP_CHECKTRUNGMASV";
                Program.Sqlcmd = Program.Conn.CreateCommand();
                Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.Sqlcmd.CommandText = str_sp;
                Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = txtMaSV.Text;
                Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.Sqlcmd.ExecuteNonQuery();
                String ret = Program.Sqlcmd.Parameters["@RET"].Value.ToString();
                if (ret == "1" && isEditingSV == false)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        bdsSV.EndEdit(); // kết thúc quá trình hiệu chỉnh
                        bdsSV.ResetCurrentItem(); // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN); // đẩy dl vừa ghi tạm về CSDL -> adapter (liên quan đến database)

                        isEditingSV = true;
                        sINHVIENDataGridView.Enabled = true;
                        btnThemSV.Enabled = btnXoaSV.Enabled = btnChuyenLopSV.Enabled = true;
                        txtMaSV.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi Sinh viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsSV.Count == 0)
            {
                return;
            }
            else
            {
                if (bdsDIEMSV.Count > 0)
                {
                    MessageBox.Show("Sinh viên đã có điểm, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Sinh viên này ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsSV.RemoveCurrent();
                            this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Sinh viên. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnPhucHoiSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            if (isEditingSV == false)
            {
                bdsSV.Position = vitriSV;
                isEditingSV = true;
                sINHVIENDataGridView.Enabled = true;
                btnThemSV.Enabled = btnXoaSV.Enabled = btnChuyenLopSV.Enabled = true;
                txtMaSV.ReadOnly = true;
            }
        }

        private void btnChuyenLopSV_Click(object sender, EventArgs e)
        {

        }
    }
}