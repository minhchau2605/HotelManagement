namespace QuanLyKhachSan.GUI
{
    partial class DatPhong_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cb_khachhang = new System.Windows.Forms.ComboBox();
            this.dtp_ngaydi = new System.Windows.Forms.DateTimePicker();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_ngayhentra = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayden = new System.Windows.Forms.DateTimePicker();
            this.txt_tiencoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_manv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mapt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_LpDat = new DevExpress.XtraEditors.TextEdit();
            this.txt_soluong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ClearAll = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ClearOne = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddOne = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddAll = new DevExpress.XtraEditors.SimpleButton();
            this.list_datphong = new System.Windows.Forms.ListBox();
            this.list_phong = new System.Windows.Forms.ListBox();
            this.cb_loaiphong = new System.Windows.Forms.ComboBox();
            this.ckb_trangthai = new System.Windows.Forms.CheckBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_thanhtoan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_dspt = new System.Windows.Forms.DataGridView();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythuephong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhentra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiencoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tiencoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mapt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LpDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dspt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cb_khachhang);
            this.groupControl1.Controls.Add(this.dtp_ngaydi);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.dtp_ngaydat);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dtp_ngayhentra);
            this.groupControl1.Controls.Add(this.dtp_ngayden);
            this.groupControl1.Controls.Add(this.txt_tiencoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_manv);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_mapt);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 252);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin đặt phòng";
            // 
            // cb_khachhang
            // 
            this.cb_khachhang.FormattingEnabled = true;
            this.cb_khachhang.Location = new System.Drawing.Point(96, 76);
            this.cb_khachhang.Name = "cb_khachhang";
            this.cb_khachhang.Size = new System.Drawing.Size(138, 21);
            this.cb_khachhang.TabIndex = 19;
            this.cb_khachhang.SelectedIndexChanged += new System.EventHandler(this.cb_khachhang_SelectedIndexChanged);
            // 
            // dtp_ngaydi
            // 
            this.dtp_ngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaydi.Location = new System.Drawing.Point(96, 189);
            this.dtp_ngaydi.Name = "dtp_ngaydi";
            this.dtp_ngaydi.Size = new System.Drawing.Size(138, 21);
            this.dtp_ngaydi.TabIndex = 17;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(28, 195);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 13);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Ngày đi:";
            // 
            // dtp_ngaydat
            // 
            this.dtp_ngaydat.Enabled = false;
            this.dtp_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaydat.Location = new System.Drawing.Point(96, 104);
            this.dtp_ngaydat.Name = "dtp_ngaydat";
            this.dtp_ngaydat.Size = new System.Drawing.Size(138, 21);
            this.dtp_ngaydat.TabIndex = 11;
            this.dtp_ngaydat.Value = new System.DateTime(2014, 12, 17, 15, 43, 37, 0);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(28, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Ngày đặt:";
            // 
            // dtp_ngayhentra
            // 
            this.dtp_ngayhentra.Enabled = false;
            this.dtp_ngayhentra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayhentra.Location = new System.Drawing.Point(96, 162);
            this.dtp_ngayhentra.Name = "dtp_ngayhentra";
            this.dtp_ngayhentra.Size = new System.Drawing.Size(138, 21);
            this.dtp_ngayhentra.TabIndex = 5;
            // 
            // dtp_ngayden
            // 
            this.dtp_ngayden.Enabled = false;
            this.dtp_ngayden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayden.Location = new System.Drawing.Point(96, 133);
            this.dtp_ngayden.Name = "dtp_ngayden";
            this.dtp_ngayden.Size = new System.Drawing.Size(138, 21);
            this.dtp_ngayden.TabIndex = 4;
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.Enabled = false;
            this.txt_tiencoc.Location = new System.Drawing.Point(96, 221);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiencoc.Properties.Appearance.Options.UseFont = true;
            this.txt_tiencoc.Size = new System.Drawing.Size(138, 20);
            this.txt_tiencoc.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(28, 224);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tiền cọc:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(28, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ngày hẹn trả:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(28, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ngày đến:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(28, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã KH:";
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(96, 50);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Properties.Appearance.Options.UseFont = true;
            this.txt_manv.Size = new System.Drawing.Size(138, 20);
            this.txt_manv.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(28, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã NV:";
            // 
            // txt_mapt
            // 
            this.txt_mapt.Enabled = false;
            this.txt_mapt.Location = new System.Drawing.Point(96, 22);
            this.txt_mapt.Name = "txt_mapt";
            this.txt_mapt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mapt.Properties.Appearance.Options.UseFont = true;
            this.txt_mapt.Size = new System.Drawing.Size(138, 20);
            this.txt_mapt.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã PT:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.txt_LpDat);
            this.groupControl4.Controls.Add(this.txt_soluong);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.btn_ClearAll);
            this.groupControl4.Controls.Add(this.btn_ClearOne);
            this.groupControl4.Controls.Add(this.btn_AddOne);
            this.groupControl4.Controls.Add(this.btn_AddAll);
            this.groupControl4.Controls.Add(this.list_datphong);
            this.groupControl4.Controls.Add(this.list_phong);
            this.groupControl4.Controls.Add(this.cb_loaiphong);
            this.groupControl4.Controls.Add(this.ckb_trangthai);
            this.groupControl4.Location = new System.Drawing.Point(267, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(358, 252);
            this.groupControl4.TabIndex = 7;
            this.groupControl4.Text = "Chi tiết đặt phòng";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(208, 31);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(102, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Danh sách phòng đặt";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(17, 31);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(112, 13);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Danh sách phòng trống";
            // 
            // txt_LpDat
            // 
            this.txt_LpDat.Enabled = false;
            this.txt_LpDat.Location = new System.Drawing.Point(208, 61);
            this.txt_LpDat.Name = "txt_LpDat";
            this.txt_LpDat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LpDat.Properties.Appearance.Options.UseFont = true;
            this.txt_LpDat.Size = new System.Drawing.Size(136, 20);
            this.txt_LpDat.TabIndex = 18;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Location = new System.Drawing.Point(286, 218);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Properties.Appearance.Options.UseFont = true;
            this.txt_soluong.Size = new System.Drawing.Size(58, 20);
            this.txt_soluong.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(208, 221);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Tổng số lượng:";
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearAll.Appearance.Options.UseFont = true;
            this.btn_ClearAll.Enabled = false;
            this.btn_ClearAll.Location = new System.Drawing.Point(164, 176);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(35, 20);
            this.btn_ClearAll.TabIndex = 15;
            this.btn_ClearAll.Text = "|<";
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_ClearOne
            // 
            this.btn_ClearOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearOne.Appearance.Options.UseFont = true;
            this.btn_ClearOne.Enabled = false;
            this.btn_ClearOne.Location = new System.Drawing.Point(164, 150);
            this.btn_ClearOne.Name = "btn_ClearOne";
            this.btn_ClearOne.Size = new System.Drawing.Size(35, 20);
            this.btn_ClearOne.TabIndex = 14;
            this.btn_ClearOne.Text = "<";
            this.btn_ClearOne.Click += new System.EventHandler(this.btn_ClearOne_Click);
            // 
            // btn_AddOne
            // 
            this.btn_AddOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOne.Appearance.Options.UseFont = true;
            this.btn_AddOne.Enabled = false;
            this.btn_AddOne.Location = new System.Drawing.Point(164, 125);
            this.btn_AddOne.Name = "btn_AddOne";
            this.btn_AddOne.Size = new System.Drawing.Size(35, 20);
            this.btn_AddOne.TabIndex = 13;
            this.btn_AddOne.Text = ">";
            this.btn_AddOne.Click += new System.EventHandler(this.btn_AddOne_Click);
            // 
            // btn_AddAll
            // 
            this.btn_AddAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAll.Appearance.Options.UseFont = true;
            this.btn_AddAll.Enabled = false;
            this.btn_AddAll.Location = new System.Drawing.Point(164, 99);
            this.btn_AddAll.Name = "btn_AddAll";
            this.btn_AddAll.Size = new System.Drawing.Size(35, 20);
            this.btn_AddAll.TabIndex = 12;
            this.btn_AddAll.Text = ">|";
            this.btn_AddAll.Click += new System.EventHandler(this.btn_AddAll_Click);
            // 
            // list_datphong
            // 
            this.list_datphong.FormattingEnabled = true;
            this.list_datphong.Location = new System.Drawing.Point(208, 88);
            this.list_datphong.Name = "list_datphong";
            this.list_datphong.Size = new System.Drawing.Size(136, 121);
            this.list_datphong.TabIndex = 11;
            // 
            // list_phong
            // 
            this.list_phong.FormattingEnabled = true;
            this.list_phong.Location = new System.Drawing.Point(17, 88);
            this.list_phong.Name = "list_phong";
            this.list_phong.Size = new System.Drawing.Size(136, 121);
            this.list_phong.TabIndex = 10;
            // 
            // cb_loaiphong
            // 
            this.cb_loaiphong.FormattingEnabled = true;
            this.cb_loaiphong.Location = new System.Drawing.Point(17, 60);
            this.cb_loaiphong.Name = "cb_loaiphong";
            this.cb_loaiphong.Size = new System.Drawing.Size(136, 21);
            this.cb_loaiphong.TabIndex = 9;
            this.cb_loaiphong.SelectedIndexChanged += new System.EventHandler(this.cb_loaiphong_SelectedIndexChanged);
            // 
            // ckb_trangthai
            // 
            this.ckb_trangthai.AutoSize = true;
            this.ckb_trangthai.Enabled = false;
            this.ckb_trangthai.Location = new System.Drawing.Point(17, 220);
            this.ckb_trangthai.Name = "ckb_trangthai";
            this.ckb_trangthai.Size = new System.Drawing.Size(148, 17);
            this.ckb_trangthai.TabIndex = 7;
            this.ckb_trangthai.Text = "Trạng thái (đã trả phòng)";
            this.ckb_trangthai.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_thanhtoan);
            this.groupControl2.Controls.Add(this.btn_luu);
            this.groupControl2.Controls.Add(this.btn_sua);
            this.groupControl2.Controls.Add(this.btn_them);
            this.groupControl2.Location = new System.Drawing.Point(629, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(143, 252);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Tác vụ";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(26, 204);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(91, 30);
            this.btn_thanhtoan.TabIndex = 3;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(26, 150);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(91, 30);
            this.btn_luu.TabIndex = 2;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(26, 95);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 30);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(26, 40);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(91, 30);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgv_dspt);
            this.groupControl3.Location = new System.Drawing.Point(4, 261);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(771, 257);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Bảng danh sách";
            // 
            // dgv_dspt
            // 
            this.dgv_dspt.AllowUserToAddRows = false;
            this.dgv_dspt.AllowUserToDeleteRows = false;
            this.dgv_dspt.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dspt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dspt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapt,
            this.makh,
            this.manv,
            this.ngaylapphieu,
            this.ngaythuephong,
            this.ngayhentra,
            this.tiencoc,
            this.SoLuong,
            this.trangthai});
            this.dgv_dspt.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dspt.Location = new System.Drawing.Point(0, 23);
            this.dgv_dspt.Name = "dgv_dspt";
            this.dgv_dspt.Size = new System.Drawing.Size(769, 229);
            this.dgv_dspt.TabIndex = 0;
            this.dgv_dspt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dspt_CellClick);
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã PT";
            this.mapt.Name = "mapt";
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // ngaylapphieu
            // 
            this.ngaylapphieu.DataPropertyName = "ngaylapp";
            this.ngaylapphieu.HeaderText = "Ngày Lập";
            this.ngaylapphieu.Name = "ngaylapphieu";
            // 
            // ngaythuephong
            // 
            this.ngaythuephong.DataPropertyName = "ngaythuep";
            this.ngaythuephong.HeaderText = "Ngày Thuê ";
            this.ngaythuephong.Name = "ngaythuephong";
            // 
            // ngayhentra
            // 
            this.ngayhentra.DataPropertyName = "ngayhentr";
            this.ngayhentra.HeaderText = "Ngày Hẹn Trả";
            this.ngayhentra.Name = "ngayhentra";
            // 
            // tiencoc
            // 
            this.tiencoc.DataPropertyName = "tiendatcoc";
            this.tiencoc.HeaderText = "Tiền Cọc";
            this.tiencoc.Name = "tiencoc";
            this.tiencoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tiencoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng Phòng Thuê";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng Thái";
            this.trangthai.Name = "trangthai";
            // 
            // DatPhong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Name = "DatPhong_GUI";
            this.Size = new System.Drawing.Size(775, 521);
            this.Load += new System.EventHandler(this.DatPhong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tiencoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mapt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LpDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dspt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtp_ngaydat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dtp_ngayhentra;
        private System.Windows.Forms.DateTimePicker dtp_ngayden;
        private DevExpress.XtraEditors.TextEdit txt_tiencoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_manv;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_mapt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit txt_LpDat;
        private DevExpress.XtraEditors.TextEdit txt_soluong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_ClearAll;
        private DevExpress.XtraEditors.SimpleButton btn_ClearOne;
        private DevExpress.XtraEditors.SimpleButton btn_AddOne;
        private DevExpress.XtraEditors.SimpleButton btn_AddAll;
        private System.Windows.Forms.ListBox list_datphong;
        private System.Windows.Forms.ListBox list_phong;
        private System.Windows.Forms.ComboBox cb_loaiphong;
        private System.Windows.Forms.CheckBox ckb_trangthai;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_thanhtoan;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgv_dspt;
        private System.Windows.Forms.DateTimePicker dtp_ngaydi;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.ComboBox cb_khachhang;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythuephong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhentra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiencoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthai;
    }
}
