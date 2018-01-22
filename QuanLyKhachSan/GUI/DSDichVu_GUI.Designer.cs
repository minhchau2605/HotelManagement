namespace QuanLyKhachSan.GUI
{
    partial class DSDichVu_GUI
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.txt_madv = new DevExpress.XtraEditors.TextEdit();
            this.txt_tendv = new DevExpress.XtraEditors.TextEdit();
            this.txt_donvitinh = new DevExpress.XtraEditors.TextEdit();
            this.txt_gia = new DevExpress.XtraEditors.TextEdit();
            this.dgv_dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_madv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_donvitinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgv_dv);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 325);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dịch vụ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_gia);
            this.groupControl2.Controls.Add(this.txt_donvitinh);
            this.groupControl2.Controls.Add(this.txt_tendv);
            this.groupControl2.Controls.Add(this.txt_madv);
            this.groupControl2.Controls.Add(this.btn_xoa);
            this.groupControl2.Controls.Add(this.btn_luu);
            this.groupControl2.Controls.Add(this.btn_sua);
            this.groupControl2.Controls.Add(this.btn_them);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(437, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(402, 325);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã DV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên DV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(271, 69);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(271, 119);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(271, 169);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(271, 219);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_madv
            // 
            this.txt_madv.Enabled = false;
            this.txt_madv.Location = new System.Drawing.Point(88, 71);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(100, 20);
            this.txt_madv.TabIndex = 8;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Enabled = false;
            this.txt_tendv.Location = new System.Drawing.Point(88, 121);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(100, 20);
            this.txt_tendv.TabIndex = 9;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(88, 171);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(100, 20);
            this.txt_donvitinh.TabIndex = 10;
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Location = new System.Drawing.Point(88, 221);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(100, 20);
            this.txt_gia.TabIndex = 11;
            // 
            // dgv_dv
            // 
            this.dgv_dv.AllowUserToAddRows = false;
            this.dgv_dv.AllowUserToDeleteRows = false;
            this.dgv_dv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_dv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dv.Location = new System.Drawing.Point(5, 23);
            this.dgv_dv.Name = "dgv_dv";
            this.dgv_dv.Size = new System.Drawing.Size(418, 297);
            this.dgv_dv.TabIndex = 0;
            this.dgv_dv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dv_CellClick);
            // 
            // DSDichVu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DSDichVu_GUI";
            this.Size = new System.Drawing.Size(842, 333);
            this.Load += new System.EventHandler(this.DSDichVu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_madv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_donvitinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txt_gia;
        private DevExpress.XtraEditors.TextEdit txt_donvitinh;
        private DevExpress.XtraEditors.TextEdit txt_tendv;
        private DevExpress.XtraEditors.TextEdit txt_madv;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_dv;
    }
}
