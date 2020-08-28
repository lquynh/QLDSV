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
using System.Globalization;

namespace QLDSV_PT
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        List<int> sohocky = new List<int>();
        List<string> sonienkhoa = new List<string>();
        public frmHocPhi()
        {
            sohocky.Add(1);
            sohocky.Add(2);
            sohocky.Add(3);
            InitializeComponent();
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            cmbHocKy.DataSource = sohocky;
            cmbHocKy.SelectedIndex = 0;
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            string currentyear = datevalue.Year.ToString();
            int oldyear = int.Parse(currentyear) - 10;
            for (int i = 0; i < 13; i++)
            {
                string tmp = oldyear + " - " + (oldyear + 1);
                oldyear = oldyear + 1;
                sonienkhoa.Add(tmp);
            }
            cmbnienkhoa.DataSource = sonienkhoa;

            cmbnienkhoa.SelectedIndex = 10;
            btnsearch.Enabled = btndelete.Enabled = btnsave.Enabled = btnadd.Enabled = btnupdate.Enabled = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void bonnut(bool flag)
        {
            btndelete.Enabled = flag;
            btnsave.Enabled = flag;
            btnadd.Enabled = flag;
            btnupdate.Enabled = flag;

            hpmssv1.ReadOnly = flag;
        }

        void tableRefresh(string mssv)
        {
            string strLenh = "EXEC SP_HOCPHI '" + mssv + "' ";

            Program.MyReader = Program.ExecSqlDataReader(strLenh);

            if (Program.MyReader == null) return;

            DataTable dt = new DataTable();
            try
            {
                dt.Load(Program.MyReader);
                hphoten.Text = dt.Rows[0]["HOTEN"].ToString();
                hplop.Text = dt.Rows[0]["LOP"].ToString();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;


                // dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].DataPropertyName = "NIENKHOA";
                dataGridView1.Columns[1].DataPropertyName = "HOCKY";
                dataGridView1.Columns[2].DataPropertyName = "HOCPHI";
                dataGridView1.Columns[3].DataPropertyName = "SOTIENDADONG";
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {
                MessageBox.Show("Mã số sinh viên không tồn tại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bonnut(false);
            }


            Program.MyReader.Close();
        }

        private void btnsearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hpmssv1.ReadOnly = false;
            btnTim.Enabled = true;
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hphocphi.ReadOnly = hpstdd.ReadOnly = false;
            btnsave.Enabled = true;
            btnupdate.Enabled = btndelete.Enabled = false;

            hphocphi.Text = "";
            hpstdd.Text = "";
        }

        private void btnupdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mssv = hpmssv1.Text.Trim();
            string nienkhoa = cmbnienkhoa.SelectedValue.ToString().Trim();
            string hocky = cmbHocKy.SelectedValue.ToString();   //hphocky.Text.Trim();
            string hocphi = hphocphi.Text.Trim();
            string sotien = hpstdd.Text.Trim();

            hocphi = hocphi.Replace(",", "");
            sotien = sotien.Replace(",", "");


            if (int.Parse(hocphi) < 100000 || int.Parse(sotien) < 100000)
            {
                MessageBox.Show("Số tiền phải lớn hơn 100,000 ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(sotien) > int.Parse(hocphi))
            {
                MessageBox.Show("Không được nhập quá học phí ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE HOCPHI SET HOCPHI = '" + hocphi + "', SOTIENDADONG = '" + sotien + "' WHERE MASV = '" + mssv + "' and HOCKY = '" + hocky + "' and NIENKHOA = '" + nienkhoa + "'";
            try
            {
                Program.MyReader = Program.ExecSqlDataReader(sql);
                if (Program.MyReader.RecordsAffected == 1)
                {
                    MessageBox.Show("Chỉnh sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại ! Bạn không được sửa Niên Khóa và Học Kỳ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Program.MyReader.Close();

                tableRefresh(mssv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không được sửa Niên Khóa và Học Kỳ " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string xnienkhoa = "";
        public string xhocky = "";

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mssv = hpmssv1.Text.Trim();
            string nienkhoa = xnienkhoa;
            string hocky = xhocky;



            string sql = "DELETE FROM HOCPHI WHERE MASV='" + mssv + "' and NIENKHOA='" + nienkhoa + "' and HOCKY='" + hocky + "'";

            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Program.MyReader = Program.ExecSqlDataReader(sql);
                    if (Program.MyReader.RecordsAffected == 1)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Program.MyReader.Close();

                    tableRefresh(mssv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại ! Đã có lỗi xảy ra " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private int kiemtrahocphi(string mssv, string nienkhoa)
        {
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            String str_sp = "dbo.CHECKDONGHOCPHI";
            Program.Sqlcmd = Program.Conn.CreateCommand();
            Program.Sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.Sqlcmd.CommandText = str_sp;
            Program.Sqlcmd.Parameters.Add("@MASV", SqlDbType.VarChar).Value = mssv;
            Program.Sqlcmd.Parameters.Add("@NIENKHOA", SqlDbType.VarChar).Value = nienkhoa;
            Program.Sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.Sqlcmd.ExecuteNonQuery();
            String ret = Program.Sqlcmd.Parameters["@Ret"].Value.ToString();
            if (ret == "1")
            {
                return 1; //đã có hoc phi lan 1
            }
            else if (ret == "0")
            {
                return 0; //chưa có 
            }
            return 2;
        }


        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mssv = hpmssv1.Text.Trim();
            string nienkhoa = cmbnienkhoa.SelectedValue.ToString().Trim();
            string hocky = cmbHocKy.SelectedValue.ToString(); //hphocky.Text.Trim();
            string hocphi = hphocphi.Text.Trim();
            string sotien = hpstdd.Text.Trim();

            hocphi = hocphi.Replace(",", "");
            sotien = sotien.Replace(",", "");
            if (int.Parse(hocphi) < 100000 || int.Parse(sotien) < 100000)
            {
                MessageBox.Show("Số tiền phải lớn hơn 100,000 ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(sotien) > int.Parse(hocphi))
            {
                MessageBox.Show("Không được nhập quá học phí ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (mssv.Length == 0 || nienkhoa.Length == 0 || hocky.Length == 0 || hocphi.Length == 0 || sotien.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (int.Parse(hocky) == 2 || int.Parse(hocky) == 3)
            {


                if (kiemtrahocphi(mssv, nienkhoa) == 1)
                {

                }
                else if (kiemtrahocphi(mssv, nienkhoa) == 0)
                {
                    MessageBox.Show("Chưa đóng tiền học kỳ 1 ");
                    return;
                }
            }

            btnupdate.Enabled = true;
            btndelete.Enabled = true;

            int n = dataGridView1.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                string hk = dataGridView1.Rows[i].Cells["HOCKY"].Value.ToString().Trim();
                //  MessageBox.Show(hk);
                string nk = dataGridView1.Rows[i].Cells["NIENKHOA"].Value.ToString().Trim();
                if (String.Compare(nienkhoa, nk, true) == 0 && String.Compare(hocky, hk, true) == 0)
                {
                    MessageBox.Show("Sinh viên đã đóng học phí cho học kỳ này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }



            string strLenh = "EXEC HOCPHIINSERT '" + mssv + "','" + nienkhoa + "','" + hocky + "','" + hocphi + "','" + sotien + "' ";
            try
            {
                Program.MyReader = Program.ExecSqlDataReader(strLenh);
                if (Program.MyReader == null) return;
                //   MessageBox.Show(Program.MyReader.RecordsAffected.ToString());
                if (Program.MyReader.RecordsAffected == 1)
                {
                    btnsave.Enabled = false;
                    MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Program.MyReader.Close();
                tableRefresh(mssv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới thất bại !" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    string nienkhoa = dataGridView1.Rows[e.RowIndex].Cells["NIENKHOA"].FormattedValue.ToString();
                    string hocky = dataGridView1.Rows[e.RowIndex].Cells["HOCKY"].FormattedValue.ToString();
                    string hocphi = dataGridView1.Rows[e.RowIndex].Cells["HOCPHI"].FormattedValue.ToString();
                    string stdd = dataGridView1.Rows[e.RowIndex].Cells["SOTIENDADONG"].FormattedValue.ToString();
                    xnienkhoa = nienkhoa;
                    xhocky = hocky;

                    if (int.Parse(hocky) == 0)
                    {

                    }
                    else
                    {
                        cmbHocKy.Text = hocky;
                    }
                    if (nienkhoa.Length == 1)
                    {

                    }
                    else
                    {
                        cmbnienkhoa.Text = nienkhoa;
                    }

                    hphocphi.Text = hocphi;
                    hpstdd.Text = stdd;
                }
            }
            catch { }
        }
    



        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string mssv = hpmssv1.Text.Trim();

            if (mssv.Length < 4)
            {
                MessageBox.Show("Mã số sinh viên phải nhiều hơn 4 kí tự", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bonnut(true);
            btnsave.Enabled = false;

            tableRefresh(mssv);
        }

        private void hphocphi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(hphocphi.Text, System.Globalization.NumberStyles.AllowThousands);
                hphocphi.Text = String.Format(culture, "{0:N0}", value);
                hphocphi.Select(hphocphi.Text.Length, 0);
            }
            catch { }
        }

        private void hphocphi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void hpstdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void hpstdd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(hpstdd.Text, System.Globalization.NumberStyles.AllowThousands);
                hpstdd.Text = String.Format(culture, "{0:N0}", value);
                hpstdd.Select(hpstdd.Text.Length, 0);
            }
            catch { }
        }
    }
}