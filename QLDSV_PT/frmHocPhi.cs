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

        public string xnienkhoa = "";
        public string xhocky = "";

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

        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
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
    }
}