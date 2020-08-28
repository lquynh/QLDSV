namespace QLDSV_PT.Report
{
    partial class frmINDSDHP
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnManHinh = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnMayIn = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.dS = new QLDSV_PT.DS();
            this.bdsReportDSDHP = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORT_DSDHPTableAdapter = new QLDSV_PT.DSTableAdapters.SP_REPORT_DSDHPTableAdapter();
            this.tableAdapterManager = new QLDSV_PT.DSTableAdapters.TableAdapterManager();
            this.sP_REPORT_DSDHPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportDSDHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DSDHPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnManHinh);
            this.panelControl1.Controls.Add(this.txtLop);
            this.panelControl1.Controls.Add(this.btnMayIn);
            this.panelControl1.Controls.Add(this.cmbHocKy);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbNienKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(949, 203);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(568, 119);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 40);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnManHinh
            // 
            this.btnManHinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManHinh.Location = new System.Drawing.Point(388, 119);
            this.btnManHinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(115, 40);
            this.btnManHinh.TabIndex = 29;
            this.btnManHinh.Text = "Màn hình";
            this.btnManHinh.UseVisualStyleBackColor = true;
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(81, 32);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(199, 25);
            this.txtLop.TabIndex = 28;
            // 
            // btnMayIn
            // 
            this.btnMayIn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayIn.Location = new System.Drawing.Point(199, 119);
            this.btnMayIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnMayIn.Name = "btnMayIn";
            this.btnMayIn.Size = new System.Drawing.Size(123, 40);
            this.btnMayIn.TabIndex = 27;
            this.btnMayIn.Text = "Máy in";
            this.btnMayIn.UseVisualStyleBackColor = true;
            this.btnMayIn.Click += new System.EventHandler(this.btnMayIn_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(702, 32);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(199, 25);
            this.cmbHocKy.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "HỌC KỲ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "NIÊN KHÓA : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "LỚP : ";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(405, 32);
            this.cmbNienKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(199, 25);
            this.cmbNienKhoa.TabIndex = 22;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsReportDSDHP
            // 
            this.bdsReportDSDHP.DataMember = "SP_REPORT_DSDHP";
            this.bdsReportDSDHP.DataSource = this.dS;
            // 
            // sP_REPORT_DSDHPTableAdapter
            // 
            this.sP_REPORT_DSDHPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_PT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_REPORT_DSDHPGridControl
            // 
            this.sP_REPORT_DSDHPGridControl.DataSource = this.bdsReportDSDHP;
            this.sP_REPORT_DSDHPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_REPORT_DSDHPGridControl.Location = new System.Drawing.Point(0, 203);
            this.sP_REPORT_DSDHPGridControl.MainView = this.gridView1;
            this.sP_REPORT_DSDHPGridControl.Name = "sP_REPORT_DSDHPGridControl";
            this.sP_REPORT_DSDHPGridControl.Size = new System.Drawing.Size(949, 220);
            this.sP_REPORT_DSDHPGridControl.TabIndex = 12;
            this.sP_REPORT_DSDHPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_REPORT_DSDHPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmINDSDHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 516);
            this.Controls.Add(this.sP_REPORT_DSDHPGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmINDSDHP";
            this.Text = "frmINDSDHP";
            this.Load += new System.EventHandler(this.frmINDSDHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsReportDSDHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DSDHPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnManHinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnMayIn;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsReportDSDHP;
        private DSTableAdapters.SP_REPORT_DSDHPTableAdapter sP_REPORT_DSDHPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_REPORT_DSDHPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}