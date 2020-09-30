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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        Int32 vitri = 0;
        bool isEditing = true;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (Program.MGroup == "KHOA")
            {
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            }
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);

            txtMaMH.ReadOnly = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isEditing = false;
            vitri = bdsMONHOC.Position;         //lấy vi tri của row hiện tại, tính từ 0
            gcMonHoc.Enabled = false;

            bdsMONHOC.AddNew();             // thao tác chuẩn bị thêm 1 new item/row 

            txtMaMH.ReadOnly = false;
            txtMaMH.Focus();

            //custom từng nút lệnh
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtMaMH.Focus();
            }
            else if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được bỏ trống !", "Thông báo !", MessageBoxButtons.OK);
                txtTenMH.Focus();
            }
            else
            {
                try
                {
                    bdsMONHOC.EndEdit();        // kết thúc quá trình hiệu chỉnh, gửi dl về dataset
                    bdsMONHOC.ResetCurrentItem();       // lấy dl của textbox control bên dưới đẩy lên gridcontrol đòng bộ 2 khu vực(ko còn ở dạng tạm nữa mà chính thức ghi vào dataset)
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);         // cập nhật dl từ dataset về database thông qua tableadapter

                    gcMonHoc.Enabled = true;
                    btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
                    txtMaMH.ReadOnly = true;
                    isEditing = true;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Mã môn học bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else if (ex.Message.Contains("UNIQUE KEY"))
                    {
                        MessageBox.Show("Tên môn học bị trùng. Vui lòng kiểm tra lại !", "Thông báo !", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();         //bỏ qua các dl đang chỉnh sửa trong row, chỉ có tác dụng khi dl chưa ghi vào dataset
            if (isEditing == false)
            {
                bdsMONHOC.Position = vitri;
                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                gcMonHoc.Enabled = true;
                txtMaMH.ReadOnly = true;
            }
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMONHOC.Count == 0)
            {
                return;
            }
            else
            {
                if (bdsDIEM.Count > 0)
                {
                    MessageBox.Show("Môn học hiện đang có điểm sinh viên, không thể xóa !", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    DialogResult ds = MessageBox.Show("Bạn chắc chắn muốn xóa Môn học ?", "Thông báo !", MessageBoxButtons.YesNo);
                    if (ds == DialogResult.Yes)
                    {
                        try
                        {
                            bdsMONHOC.RemoveCurrent();          //xóa row đang chọn ra khỏi dataset
                            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                            this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                            //this.bdsMONHOC.ResetCurrentItem();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học. " + ex.Message, "Thông báo !", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}