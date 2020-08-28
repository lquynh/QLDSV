namespace QLDSV_PT.Report
{
    partial class frmINPD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInPD = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_PT.DS();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsReportPD = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMONHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sINHVIENTableAdapter = new QLDSV_PT.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_PT.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV_PT.DSTableAdapters.LOPTableAdapter();
            this.sP_REPORT_PDTableAdapter = new QLDSV_PT.DSTableAdapters.SP_REPORT_PDTableAdapter();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(820, 128);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(37, 17);
            tENLabel.TabIndex = 29;
            tENLabel.Text = "TÊN";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(575, 127);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(34, 17);
            hOLabel.TabIndex = 27;
            hOLabel.Text = "HỌ ";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(29, 127);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(174, 17);
            mASVLabel.TabIndex = 25;
            mASVLabel.Text = "Chọn mã sinh viên cần tìm : ";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(156, 80);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(47, 17);
            tENLOPLabel.TabIndex = 24;
            tENLOPLabel.Text = "LỚP : ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBatDau);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnInPD);
            this.panelControl1.Controls.Add(tENLabel);
            this.panelControl1.Controls.Add(this.txtTen);
            this.panelControl1.Controls.Add(hOLabel);
            this.panelControl1.Controls.Add(this.txtHo);
            this.panelControl1.Controls.Add(mASVLabel);
            this.panelControl1.Controls.Add(this.cmbMaSV);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1032, 268);
            this.panelControl1.TabIndex = 0;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(159, 193);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(104, 44);
            this.btnBatDau.TabIndex = 34;
            this.btnBatDau.Text = "Tìm kiếm";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(468, 193);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 44);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInPD
            // 
            this.btnInPD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPD.Location = new System.Drawing.Point(308, 193);
            this.btnInPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInPD.Name = "btnInPD";
            this.btnInPD.Size = new System.Drawing.Size(113, 44);
            this.btnInPD.TabIndex = 32;
            this.btnInPD.Text = "In phiếu điểm";
            this.btnInPD.UseVisualStyleBackColor = true;
            this.btnInPD.Click += new System.EventHandler(this.btnInPD_Click);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(860, 123);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(152, 25);
            this.txtTen.TabIndex = 31;
            // 
            // txtHo
            // 
            this.txtHo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(610, 123);
            this.txtHo.Name = "txtHo";
            this.txtHo.ReadOnly = true;
            this.txtHo.Size = new System.Drawing.Size(187, 25);
            this.txtHo.TabIndex = 30;
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.bdsSV;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(209, 124);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(348, 25);
            this.cmbMaSV.TabIndex = 28;
            this.cmbMaSV.ValueMember = "MASV";
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bdsLOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(209, 76);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(348, 25);
            this.cmbLop.TabIndex = 26;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(209, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(348, 25);
            this.cmbKhoa.TabIndex = 23;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "KHOA :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsReportPD;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 268);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1032, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsReportPD
            // 
            this.bdsReportPD.DataMember = "SP_REPORT_PD";
            this.bdsReportPD.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMONHOC,
            this.colDIEM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMONHOC
            // 
            this.colMONHOC.FieldName = "MONHOC";
            this.colMONHOC.Name = "colMONHOC";
            this.colMONHOC.Visible = true;
            this.colMONHOC.VisibleIndex = 0;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 1;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_PT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sP_REPORT_PDTableAdapter
            // 
            this.sP_REPORT_PDTableAdapter.ClearBeforeFill = true;
            // 
            // frmINPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 474);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmINPD";
            this.Text = "frmINPD";
            this.Load += new System.EventHandler(this.frmINPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInPD;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOP;
        private System.Windows.Forms.BindingSource bdsReportPD;
        private DSTableAdapters.SP_REPORT_PDTableAdapter sP_REPORT_PDTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMONHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
    }
}