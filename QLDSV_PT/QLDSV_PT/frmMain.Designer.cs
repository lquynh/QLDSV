namespace QLDSV_PT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Class = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Subject = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Student = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Mark = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Change = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Fee = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_InDSThi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TabbedManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_InPD = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_InBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_InBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_InHPL = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedManager)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_Class,
            this.btn_Subject,
            this.btn_Student,
            this.btn_Mark,
            this.btn_Change,
            this.btn_Fee,
            this.btn_InDSSV,
            this.btn_InDSThi,
            this.btn_TaoTK,
            this.btn_DangXuat,
            this.btn_InPD,
            this.btn_InBDMH,
            this.btn_InBDTK,
            this.btn_InHPL});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ribbon.MaxItemId = 38;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1102, 147);
            // 
            // btn_Class
            // 
            this.btn_Class.Caption = "LỚP";
            this.btn_Class.Id = 1;
            this.btn_Class.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Class.ImageOptions.Image")));
            this.btn_Class.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Class.ImageOptions.LargeImage")));
            this.btn_Class.LargeWidth = 90;
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Class_ItemClick);
            // 
            // btn_Subject
            // 
            this.btn_Subject.Caption = "MÔN HỌC";
            this.btn_Subject.Id = 2;
            this.btn_Subject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Subject.ImageOptions.Image")));
            this.btn_Subject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Subject.ImageOptions.LargeImage")));
            this.btn_Subject.LargeWidth = 90;
            this.btn_Subject.Name = "btn_Subject";
            this.btn_Subject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Subject_ItemClick);
            // 
            // btn_Student
            // 
            this.btn_Student.Caption = "SINH VIÊN";
            this.btn_Student.Id = 3;
            this.btn_Student.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Student.ImageOptions.Image")));
            this.btn_Student.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Student.ImageOptions.LargeImage")));
            this.btn_Student.LargeWidth = 90;
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Student_ItemClick);
            // 
            // btn_Mark
            // 
            this.btn_Mark.Caption = "ĐIỂM";
            this.btn_Mark.Id = 4;
            this.btn_Mark.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mark.ImageOptions.Image")));
            this.btn_Mark.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Mark.ImageOptions.LargeImage")));
            this.btn_Mark.LargeWidth = 90;
            this.btn_Mark.Name = "btn_Mark";
            this.btn_Mark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Mark_ItemClick);
            // 
            // btn_Change
            // 
            this.btn_Change.Caption = "CHUYỂN LỚP";
            this.btn_Change.Id = 5;
            this.btn_Change.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Change.ImageOptions.Image")));
            this.btn_Change.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Change.ImageOptions.LargeImage")));
            this.btn_Change.LargeWidth = 90;
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Change_ItemClick);
            // 
            // btn_Fee
            // 
            this.btn_Fee.Caption = "HỌC PHÍ";
            this.btn_Fee.Id = 6;
            this.btn_Fee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fee.ImageOptions.Image")));
            this.btn_Fee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Fee.ImageOptions.LargeImage")));
            this.btn_Fee.LargeWidth = 90;
            this.btn_Fee.Name = "btn_Fee";
            this.btn_Fee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Fee_ItemClick);
            // 
            // btn_InDSSV
            // 
            this.btn_InDSSV.Caption = "DANH SÁCH SINH VIÊN";
            this.btn_InDSSV.Id = 7;
            this.btn_InDSSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InDSSV.ImageOptions.Image")));
            this.btn_InDSSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InDSSV.ImageOptions.LargeImage")));
            this.btn_InDSSV.LargeWidth = 90;
            this.btn_InDSSV.Name = "btn_InDSSV";
            // 
            // btn_InDSThi
            // 
            this.btn_InDSThi.Caption = "DANH SÁCH THI";
            this.btn_InDSThi.Id = 13;
            this.btn_InDSThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InDSThi.ImageOptions.Image")));
            this.btn_InDSThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InDSThi.ImageOptions.LargeImage")));
            this.btn_InDSThi.LargeWidth = 90;
            this.btn_InDSThi.Name = "btn_InDSThi";
            // 
            // btn_TaoTK
            // 
            this.btn_TaoTK.Caption = "TẠO TÀI KHOẢN";
            this.btn_TaoTK.Id = 21;
            this.btn_TaoTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoTK.ImageOptions.Image")));
            this.btn_TaoTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TaoTK.ImageOptions.LargeImage")));
            this.btn_TaoTK.LargeWidth = 90;
            this.btn_TaoTK.Name = "btn_TaoTK";
            this.btn_TaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaoTK_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "ĐĂNG XUẤT";
            this.btn_DangXuat.Id = 22;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.LargeWidth = 90;
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup14});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QUẢN LÝ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Class);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Subject);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Student);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_Mark);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_Change);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.btn_Fee);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_InDSSV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_InDSThi);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "TÀI KHOẢN";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btn_TaoTK);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // TabbedManager
            // 
            this.TabbedManager.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMAGV,
            this.tsslHOTEN,
            this.tsslNHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 617);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1102, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMAGV
            // 
            this.tsslMAGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslMAGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tsslMAGV.Name = "tsslMAGV";
            this.tsslMAGV.Size = new System.Drawing.Size(41, 19);
            this.tsslMAGV.Text = "MAGV";
            // 
            // tsslHOTEN
            // 
            this.tsslHOTEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslHOTEN.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslHOTEN.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslHOTEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tsslHOTEN.Name = "tsslHOTEN";
            this.tsslHOTEN.Size = new System.Drawing.Size(49, 19);
            this.tsslHOTEN.Text = "HOTEN";
            // 
            // tsslNHOM
            // 
            this.tsslNHOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tsslNHOM.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslNHOM.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.tsslNHOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tsslNHOM.Name = "tsslNHOM";
            this.tsslNHOM.Size = new System.Drawing.Size(49, 19);
            this.tsslNHOM.Text = "NHOM";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_InPD);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // btn_InPD
            // 
            this.btn_InPD.Caption = "PHIẾU ĐIỂM";
            this.btn_InPD.Id = 34;
            this.btn_InPD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InPD.ImageOptions.Image")));
            this.btn_InPD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InPD.ImageOptions.LargeImage")));
            this.btn_InPD.LargeWidth = 90;
            this.btn_InPD.Name = "btn_InPD";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_InBDMH);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // btn_InBDMH
            // 
            this.btn_InBDMH.Caption = "BẢNG ĐIỂM MÔN HỌC";
            this.btn_InBDMH.Id = 35;
            this.btn_InBDMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InBDMH.ImageOptions.Image")));
            this.btn_InBDMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InBDMH.ImageOptions.LargeImage")));
            this.btn_InBDMH.LargeWidth = 90;
            this.btn_InBDMH.Name = "btn_InBDMH";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_InBDTK);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // btn_InBDTK
            // 
            this.btn_InBDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.btn_InBDTK.Id = 36;
            this.btn_InBDTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InBDTK.ImageOptions.Image")));
            this.btn_InBDTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InBDTK.ImageOptions.LargeImage")));
            this.btn_InBDTK.LargeWidth = 90;
            this.btn_InBDTK.Name = "btn_InBDTK";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btn_InHPL);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // btn_InHPL
            // 
            this.btn_InHPL.Caption = "HỌC PHÍ LỚP";
            this.btn_InHPL.Id = 37;
            this.btn_InHPL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_InHPL.ImageOptions.Image")));
            this.btn_InHPL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_InHPL.ImageOptions.LargeImage")));
            this.btn_InHPL.LargeWidth = 90;
            this.btn_InHPL.Name = "btn_InHPL";
            // 
            // frmMain
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedManager)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Class;
        private DevExpress.XtraBars.BarButtonItem btn_Subject;
        private DevExpress.XtraBars.BarButtonItem btn_Student;
        private DevExpress.XtraBars.BarButtonItem btn_Mark;
        private DevExpress.XtraBars.BarButtonItem btn_Change;
        private DevExpress.XtraBars.BarButtonItem btn_Fee;
        private DevExpress.XtraBars.BarButtonItem btn_InDSSV;
        private DevExpress.XtraBars.BarButtonItem btn_InDSThi;
        private DevExpress.XtraBars.BarButtonItem btn_TaoTK;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabbedManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslMAGV;
        public System.Windows.Forms.ToolStripStatusLabel tsslHOTEN;
        public System.Windows.Forms.ToolStripStatusLabel tsslNHOM;
        private DevExpress.XtraBars.BarButtonItem btn_InPD;
        private DevExpress.XtraBars.BarButtonItem btn_InBDMH;
        private DevExpress.XtraBars.BarButtonItem btn_InBDTK;
        private DevExpress.XtraBars.BarButtonItem btn_InHPL;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}