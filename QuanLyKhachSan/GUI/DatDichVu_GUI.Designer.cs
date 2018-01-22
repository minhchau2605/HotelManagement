namespace QuanLyKhachSan.GUI
{
    partial class DatDichVu_GUI
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
            this.dgv_dsdv = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_dvsd = new System.Windows.Forms.DataGridView();
            this.txt_mahddv = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dichvu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cb_phong = new System.Windows.Forms.ComboBox();
            this.txt_donvi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.dgv_hddv = new System.Windows.Forms.DataGridView();
            this.btn_datdv = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dongia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_taohddv = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dvsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahddv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dichvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_donvi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hddv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dongia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_dsdv);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(159, 459);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dịch Vụ";
            // 
            // dgv_dsdv
            // 
            this.dgv_dsdv.AllowUserToAddRows = false;
            this.dgv_dsdv.AllowUserToDeleteRows = false;
            this.dgv_dsdv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dsdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsdv.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_dsdv.Location = new System.Drawing.Point(0, 23);
            this.dgv_dsdv.Name = "dgv_dsdv";
            this.dgv_dsdv.Size = new System.Drawing.Size(159, 436);
            this.dgv_dsdv.TabIndex = 1;
            this.dgv_dsdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsdv_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_taohddv);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.txt_dichvu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.cb_phong);
            this.groupControl2.Controls.Add(this.txt_donvi);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.nud_soluong);
            this.groupControl2.Controls.Add(this.dgv_hddv);
            this.groupControl2.Controls.Add(this.btn_datdv);
            this.groupControl2.Controls.Add(this.dtp_ngaydat);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txt_dongia);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(166, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(633, 459);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông Tin";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgv_dvsd);
            this.groupControl3.Controls.Add(this.txt_mahddv);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(190, 206);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(443, 248);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "Dịch vụ sử dụng";
            // 
            // dgv_dvsd
            // 
            this.dgv_dvsd.AllowUserToAddRows = false;
            this.dgv_dvsd.AllowUserToDeleteRows = false;
            this.dgv_dvsd.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dvsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dvsd.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_dvsd.Location = new System.Drawing.Point(0, 49);
            this.dgv_dvsd.Name = "dgv_dvsd";
            this.dgv_dvsd.Size = new System.Drawing.Size(443, 194);
            this.dgv_dvsd.TabIndex = 22;
            // 
            // txt_mahddv
            // 
            this.txt_mahddv.Enabled = false;
            this.txt_mahddv.Location = new System.Drawing.Point(192, 23);
            this.txt_mahddv.Name = "txt_mahddv";
            this.txt_mahddv.Size = new System.Drawing.Size(108, 20);
            this.txt_mahddv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã HDDV";
            // 
            // txt_dichvu
            // 
            this.txt_dichvu.Enabled = false;
            this.txt_dichvu.Location = new System.Drawing.Point(69, 80);
            this.txt_dichvu.Name = "txt_dichvu";
            this.txt_dichvu.Size = new System.Drawing.Size(100, 20);
            this.txt_dichvu.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Dịch Vụ";
            // 
            // cb_phong
            // 
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.Location = new System.Drawing.Point(69, 118);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.Size = new System.Drawing.Size(100, 21);
            this.cb_phong.TabIndex = 15;
            this.cb_phong.SelectedIndexChanged += new System.EventHandler(this.cb_phong_SelectedIndexChanged);
            // 
            // txt_donvi
            // 
            this.txt_donvi.Enabled = false;
            this.txt_donvi.Location = new System.Drawing.Point(69, 239);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(100, 20);
            this.txt_donvi.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 242);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Đơn Vị";
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(69, 198);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(100, 21);
            this.nud_soluong.TabIndex = 12;
            // 
            // dgv_hddv
            // 
            this.dgv_hddv.AllowUserToAddRows = false;
            this.dgv_hddv.AllowUserToDeleteRows = false;
            this.dgv_hddv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_hddv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hddv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_hddv.Location = new System.Drawing.Point(193, 23);
            this.dgv_hddv.Name = "dgv_hddv";
            this.dgv_hddv.Size = new System.Drawing.Size(440, 177);
            this.dgv_hddv.TabIndex = 11;
            this.dgv_hddv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hddv_CellClick);
            // 
            // btn_datdv
            // 
            this.btn_datdv.Location = new System.Drawing.Point(9, 339);
            this.btn_datdv.Name = "btn_datdv";
            this.btn_datdv.Size = new System.Drawing.Size(75, 23);
            this.btn_datdv.TabIndex = 10;
            this.btn_datdv.Text = "Đặt Dịch Vụ";
            this.btn_datdv.Click += new System.EventHandler(this.btn_datdv_Click);
            // 
            // dtp_ngaydat
            // 
            this.dtp_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaydat.Location = new System.Drawing.Point(69, 277);
            this.dtp_ngaydat.Name = "dtp_ngaydat";
            this.dtp_ngaydat.Size = new System.Drawing.Size(100, 21);
            this.dtp_ngaydat.TabIndex = 9;
            this.dtp_ngaydat.Value = new System.DateTime(2017, 11, 8, 0, 0, 0, 0);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 283);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ngày Đặt";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 200);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số Lượng";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(69, 157);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(100, 20);
            this.txt_dongia.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Giá";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Phòng";
            // 
            // btn_taohddv
            // 
            this.btn_taohddv.Location = new System.Drawing.Point(94, 339);
            this.btn_taohddv.Name = "btn_taohddv";
            this.btn_taohddv.Size = new System.Drawing.Size(75, 23);
            this.btn_taohddv.TabIndex = 20;
            this.btn_taohddv.Text = "Thanh Toán";
            this.btn_taohddv.Click += new System.EventHandler(this.btn_taohddv_Click);
            // 
            // DatDichVu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DatDichVu_GUI";
            this.Size = new System.Drawing.Size(802, 465);
            this.Load += new System.EventHandler(this.DatDichVu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dvsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahddv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dichvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_donvi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hddv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dongia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_dsdv;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_dongia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtp_ngaydat;
        private DevExpress.XtraEditors.SimpleButton btn_datdv;
        private System.Windows.Forms.DataGridView dgv_hddv;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private DevExpress.XtraEditors.TextEdit txt_donvi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cb_phong;
        private DevExpress.XtraEditors.TextEdit txt_dichvu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txt_mahddv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dvsd;
        private DevExpress.XtraEditors.SimpleButton btn_taohddv;
    }
}
