namespace QuanLyKhachSan
{
    partial class MainForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_qtv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_doi_mk = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ds_phong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dat_phong = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dsnv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dsdichvu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_goidichvu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tiennghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dskh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.rp_he_thong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_he_thong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_ql_phong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpb_ql_phong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbp_kh = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpg_dichvuks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_nhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbg_nhanvien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_baocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpg_bao_cao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl_Main = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_qtv,
            this.btn_doi_mk,
            this.btn_dangxuat,
            this.btn_ds_phong,
            this.btn_dat_phong,
            this.btn_dsnv,
            this.btn_dsdichvu,
            this.btn_goidichvu,
            this.btn_tiennghi,
            this.btn_dskh,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rp_he_thong,
            this.rp_ql_phong,
            this.rp_nhanvien,
            this.rp_baocao});
            this.ribbon.Size = new System.Drawing.Size(938, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_qtv
            // 
            this.btn_qtv.Caption = "QUẢN TRỊ VIÊN";
            this.btn_qtv.Glyph = global::QuanLyKhachSan.Properties.Resources.User;
            this.btn_qtv.Id = 8;
            this.btn_qtv.Name = "btn_qtv";
            this.btn_qtv.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_doi_mk
            // 
            this.btn_doi_mk.Caption = "ĐỔI MẬT KHẨU";
            this.btn_doi_mk.Glyph = global::QuanLyKhachSan.Properties.Resources.password;
            this.btn_doi_mk.Id = 9;
            this.btn_doi_mk.Name = "btn_doi_mk";
            this.btn_doi_mk.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "ĐĂNG XUẤT";
            this.btn_dangxuat.Glyph = global::QuanLyKhachSan.Properties.Resources.exit;
            this.btn_dangxuat.Id = 10;
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dangxuat_ItemClick);
            // 
            // btn_ds_phong
            // 
            this.btn_ds_phong.Caption = "DANH SÁCH PHÒNG";
            this.btn_ds_phong.Glyph = global::QuanLyKhachSan.Properties.Resources.themphong;
            this.btn_ds_phong.Id = 11;
            this.btn_ds_phong.Name = "btn_ds_phong";
            this.btn_ds_phong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_ds_phong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ds_phong_ItemClick);
            // 
            // btn_dat_phong
            // 
            this.btn_dat_phong.Caption = "ĐẶT PHÒNG";
            this.btn_dat_phong.Glyph = global::QuanLyKhachSan.Properties.Resources.datphong;
            this.btn_dat_phong.Id = 12;
            this.btn_dat_phong.Name = "btn_dat_phong";
            this.btn_dat_phong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dat_phong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dat_phong_ItemClick);
            // 
            // btn_dsnv
            // 
            this.btn_dsnv.Caption = "DANH SÁCH NHÂN VIÊN";
            this.btn_dsnv.Glyph = global::QuanLyKhachSan.Properties.Resources.themnv;
            this.btn_dsnv.Id = 13;
            this.btn_dsnv.Name = "btn_dsnv";
            this.btn_dsnv.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dsnv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dsnv_ItemClick);
            // 
            // btn_dsdichvu
            // 
            this.btn_dsdichvu.Caption = "DANH SÁCH DỊCH VỤ";
            this.btn_dsdichvu.Glyph = global::QuanLyKhachSan.Properties.Resources.money_bag_icon;
            this.btn_dsdichvu.Id = 14;
            this.btn_dsdichvu.Name = "btn_dsdichvu";
            this.btn_dsdichvu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dsdichvu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dsdichvu_ItemClick);
            // 
            // btn_goidichvu
            // 
            this.btn_goidichvu.Caption = "YÊU CẦU DỊCH VỤ";
            this.btn_goidichvu.Glyph = global::QuanLyKhachSan.Properties.Resources.build_order_icon;
            this.btn_goidichvu.Id = 15;
            this.btn_goidichvu.Name = "btn_goidichvu";
            this.btn_goidichvu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_goidichvu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_goidichvu_ItemClick);
            // 
            // btn_tiennghi
            // 
            this.btn_tiennghi.Caption = "TIỆN NGHI PHÒNG";
            this.btn_tiennghi.Glyph = global::QuanLyKhachSan.Properties.Resources.air_conditionec_room_convenient_interior_512;
            this.btn_tiennghi.Id = 16;
            this.btn_tiennghi.Name = "btn_tiennghi";
            this.btn_tiennghi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_tiennghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_tiennghi_ItemClick);
            // 
            // btn_dskh
            // 
            this.btn_dskh.Caption = "DANH SÁCH KHÁCH HÀNG";
            this.btn_dskh.Glyph = global::QuanLyKhachSan.Properties.Resources.themnvkh1;
            this.btn_dskh.Id = 17;
            this.btn_dskh.Name = "btn_dskh";
            this.btn_dskh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_dskh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dskh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DANH SÁCH KHÁCH HÀNG";
            this.barButtonItem1.Glyph = global::QuanLyKhachSan.Properties.Resources.dskh;
            this.barButtonItem1.Id = 18;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "DANH SÁCH NHÂN VIÊN";
            this.barButtonItem2.Glyph = global::QuanLyKhachSan.Properties.Resources.dsnvkh;
            this.barButtonItem2.Id = 19;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // rp_he_thong
            // 
            this.rp_he_thong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_he_thong});
            this.rp_he_thong.Name = "rp_he_thong";
            this.rp_he_thong.Text = "HỆ THỐNG";
            // 
            // rpg_he_thong
            // 
            this.rpg_he_thong.ItemLinks.Add(this.btn_qtv);
            this.rpg_he_thong.ItemLinks.Add(this.btn_doi_mk);
            this.rpg_he_thong.ItemLinks.Add(this.btn_dangxuat);
            this.rpg_he_thong.Name = "rpg_he_thong";
            this.rpg_he_thong.Text = "HỆ THỐNG";
            // 
            // rp_ql_phong
            // 
            this.rp_ql_phong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpb_ql_phong,
            this.rbp_kh,
            this.rpg_dichvuks});
            this.rp_ql_phong.Name = "rp_ql_phong";
            this.rp_ql_phong.Text = "PHÒNG KHÁCH SẠN";
            // 
            // rpb_ql_phong
            // 
            this.rpb_ql_phong.ItemLinks.Add(this.btn_ds_phong);
            this.rpb_ql_phong.ItemLinks.Add(this.btn_dat_phong);
            this.rpb_ql_phong.ItemLinks.Add(this.btn_tiennghi);
            this.rpb_ql_phong.Name = "rpb_ql_phong";
            this.rpb_ql_phong.Text = "QUẢN LÝ PHÒNG";
            // 
            // rbp_kh
            // 
            this.rbp_kh.ItemLinks.Add(this.btn_dskh);
            this.rbp_kh.Name = "rbp_kh";
            this.rbp_kh.Text = "KHÁCH HÀNG";
            // 
            // rpg_dichvuks
            // 
            this.rpg_dichvuks.ItemLinks.Add(this.btn_dsdichvu);
            this.rpg_dichvuks.ItemLinks.Add(this.btn_goidichvu);
            this.rpg_dichvuks.Name = "rpg_dichvuks";
            this.rpg_dichvuks.Text = "DỊCH VỤ KHÁCH SẠN";
            // 
            // rp_nhanvien
            // 
            this.rp_nhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbg_nhanvien});
            this.rp_nhanvien.Name = "rp_nhanvien";
            this.rp_nhanvien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // rbg_nhanvien
            // 
            this.rbg_nhanvien.ItemLinks.Add(this.btn_dsnv);
            this.rbg_nhanvien.Name = "rbg_nhanvien";
            this.rbg_nhanvien.Text = "NHÂN VIÊN";
            // 
            // rp_baocao
            // 
            this.rp_baocao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpg_bao_cao});
            this.rp_baocao.Name = "rp_baocao";
            this.rp_baocao.Text = "BÁO CÁO";
            // 
            // rpg_bao_cao
            // 
            this.rpg_bao_cao.ItemLinks.Add(this.barButtonItem1);
            this.rpg_bao_cao.ItemLinks.Add(this.barButtonItem2);
            this.rpg_bao_cao.Name = "rpg_bao_cao";
            this.rpg_bao_cao.Text = "BÁO CÁO";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 697);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(938, 31);
            // 
            // xtraTabControl_Main
            // 
            this.xtraTabControl_Main.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl_Main.Location = new System.Drawing.Point(0, 149);
            this.xtraTabControl_Main.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.xtraTabControl_Main.Name = "xtraTabControl_Main";
            this.xtraTabControl_Main.Size = new System.Drawing.Size(938, 547);
            this.xtraTabControl_Main.TabIndex = 3;
            this.xtraTabControl_Main.CloseButtonClick += new System.EventHandler(this.xtraTabControl_Main_CloseButtonClick);
            this.xtraTabControl_Main.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl_Main_ControlAdded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 728);
            this.Controls.Add(this.xtraTabControl_Main);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Khách Sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_he_thong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_he_thong;
        private DevExpress.XtraBars.BarButtonItem btn_qtv;
        private DevExpress.XtraBars.BarButtonItem btn_doi_mk;
        private DevExpress.XtraBars.BarButtonItem btn_dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_ql_phong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpb_ql_phong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_nhanvien;
        private DevExpress.XtraBars.BarButtonItem btn_ds_phong;
        private DevExpress.XtraBars.BarButtonItem btn_dat_phong;
        private DevExpress.XtraBars.BarButtonItem btn_dsnv;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbg_nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_baocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_bao_cao;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_Main;
        private DevExpress.XtraBars.BarButtonItem btn_dsdichvu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpg_dichvuks;
        private DevExpress.XtraBars.BarButtonItem btn_goidichvu;
        private DevExpress.XtraBars.BarButtonItem btn_tiennghi;
        private DevExpress.XtraBars.BarButtonItem btn_dskh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbp_kh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}