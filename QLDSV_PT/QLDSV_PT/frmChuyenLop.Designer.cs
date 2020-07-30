namespace QLDSV_PT
{
    partial class frmChuyenLop
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
            this.panel = new System.Windows.Forms.Panel();
            this.butonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.txtMaSVMoi = new System.Windows.Forms.TextBox();
            this.txtMaLopChuyenDen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTTSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditChuyenLop = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLDSV_PT.DS();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new QLDSV_PT.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new QLDSV_PT.DSTableAdapters.TableAdapterManager();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).BeginInit();
            this.gbTTSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.butonCancel);
            this.panel.Controls.Add(this.buttonOK);
            this.panel.Controls.Add(this.button_Check);
            this.panel.Controls.Add(this.txtMaSVMoi);
            this.panel.Controls.Add(this.txtMaLopChuyenDen);
            this.panel.Controls.Add(this.txtMaSV);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.gbTTSinhVien);
            this.panel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(12, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(924, 434);
            this.panel.TabIndex = 0;
            // 
            // butonCancel
            // 
            this.butonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonCancel.ForeColor = System.Drawing.Color.White;
            this.butonCancel.Location = new System.Drawing.Point(509, 316);
            this.butonCancel.Name = "butonCancel";
            this.butonCancel.Size = new System.Drawing.Size(103, 36);
            this.butonCancel.TabIndex = 5;
            this.butonCancel.Text = "Hủy";
            this.butonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(344, 316);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(103, 36);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Xác nhận";
            this.buttonOK.UseVisualStyleBackColor = false;
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Check.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(585, 206);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(68, 26);
            this.button_Check.TabIndex = 9;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = false;
            // 
            // txtMaSVMoi
            // 
            this.txtMaSVMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSVMoi.Location = new System.Drawing.Point(395, 254);
            this.txtMaSVMoi.Name = "txtMaSVMoi";
            this.txtMaSVMoi.Size = new System.Drawing.Size(168, 26);
            this.txtMaSVMoi.TabIndex = 7;
            // 
            // txtMaLopChuyenDen
            // 
            this.txtMaLopChuyenDen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLopChuyenDen.Location = new System.Drawing.Point(395, 206);
            this.txtMaLopChuyenDen.Name = "txtMaLopChuyenDen";
            this.txtMaLopChuyenDen.Size = new System.Drawing.Size(168, 26);
            this.txtMaLopChuyenDen.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSV.Location = new System.Drawing.Point(394, 151);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(169, 26);
            this.txtMaSV.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Sinh Viên Mới:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Lớp Chuyển Đến:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mã Sinh Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "CHUYỂN LỚP";
            // 
            // gbTTSinhVien
            // 
            this.gbTTSinhVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTSinhVien.Appearance.Options.UseFont = true;
            this.gbTTSinhVien.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTTSinhVien.AppearanceCaption.Options.UseFont = true;
            this.gbTTSinhVien.Controls.Add(this.txtMaLop);
            this.gbTTSinhVien.Controls.Add(this.txtTenSV);
            this.gbTTSinhVien.Controls.Add(this.label3);
            this.gbTTSinhVien.Controls.Add(this.label2);
            this.gbTTSinhVien.Controls.Add(this.lookUpEditChuyenLop);
            this.gbTTSinhVien.Controls.Add(this.label1);
            this.gbTTSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTTSinhVien.Location = new System.Drawing.Point(0, 0);
            this.gbTTSinhVien.Name = "gbTTSinhVien";
            this.gbTTSinhVien.Size = new System.Drawing.Size(924, 83);
            this.gbTTSinhVien.TabIndex = 12;
            this.gbTTSinhVien.Text = "Tra cứu sinh viên";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(727, 35);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(158, 26);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(449, 35);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Properties.ReadOnly = true;
            this.txtTenSV.Size = new System.Drawing.Size(158, 26);
            this.txtTenSV.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sinh viên:";
            // 
            // lookUpEditChuyenLop
            // 
            this.lookUpEditChuyenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "MASV", true));
            this.lookUpEditChuyenLop.Location = new System.Drawing.Point(147, 36);
            this.lookUpEditChuyenLop.Name = "lookUpEditChuyenLop";
            this.lookUpEditChuyenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditChuyenLop.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditChuyenLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditChuyenLop.Properties.DataSource = this.sINHVIENBindingSource;
            this.lookUpEditChuyenLop.Properties.DisplayMember = "MASV";
            this.lookUpEditChuyenLop.Properties.NullText = "";
            this.lookUpEditChuyenLop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditChuyenLop.Properties.ValueMember = "MASV";
            this.lookUpEditChuyenLop.Size = new System.Drawing.Size(156, 26);
            this.lookUpEditChuyenLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập MSSV:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV_PT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 459);
            this.Controls.Add(this.panel);
            this.Name = "frmChuyenLop";
            this.Text = "frmChuyenLop";
            this.Load += new System.EventHandler(this.frmChuyenLop_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTTSinhVien)).EndInit();
            this.gbTTSinhVien.ResumeLayout(false);
            this.gbTTSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChuyenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.GroupControl gbTTSinhVien;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditChuyenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.TextBox txtMaSVMoi;
        private System.Windows.Forms.TextBox txtMaLopChuyenDen;
        private DS dS;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}