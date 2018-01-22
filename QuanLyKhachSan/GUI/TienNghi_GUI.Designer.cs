namespace QuanLyKhachSan.GUI
{
    partial class TienNghi_GUI
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_tentn = new System.Windows.Forms.TextBox();
            this.txt_matn = new System.Windows.Forms.TextBox();
            this.dgv_tiennghi = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_xoatn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suatn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_tnphong = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btn_luutn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiennghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tnphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_tentn);
            this.groupControl1.Controls.Add(this.txt_matn);
            this.groupControl1.Controls.Add(this.dgv_tiennghi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 213);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tiện nghi";
            // 
            // txt_tentn
            // 
            this.txt_tentn.Enabled = false;
            this.txt_tentn.Location = new System.Drawing.Point(281, 165);
            this.txt_tentn.Name = "txt_tentn";
            this.txt_tentn.Size = new System.Drawing.Size(100, 21);
            this.txt_tentn.TabIndex = 7;
            // 
            // txt_matn
            // 
            this.txt_matn.Enabled = false;
            this.txt_matn.Location = new System.Drawing.Point(281, 74);
            this.txt_matn.Name = "txt_matn";
            this.txt_matn.Size = new System.Drawing.Size(100, 21);
            this.txt_matn.TabIndex = 6;
            // 
            // dgv_tiennghi
            // 
            this.dgv_tiennghi.AllowUserToAddRows = false;
            this.dgv_tiennghi.AllowUserToDeleteRows = false;
            this.dgv_tiennghi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_tiennghi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tiennghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tiennghi.Location = new System.Drawing.Point(5, 23);
            this.dgv_tiennghi.Name = "dgv_tiennghi";
            this.dgv_tiennghi.Size = new System.Drawing.Size(256, 185);
            this.dgv_tiennghi.TabIndex = 5;
            this.dgv_tiennghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tiennghi_CellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Location = new System.Drawing.Point(281, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã tiện nghi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(281, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên tiện nghi";
            // 
            // btn_xoatn
            // 
            this.btn_xoatn.Location = new System.Drawing.Point(28, 175);
            this.btn_xoatn.Name = "btn_xoatn";
            this.btn_xoatn.Size = new System.Drawing.Size(75, 23);
            this.btn_xoatn.TabIndex = 11;
            this.btn_xoatn.Text = "Xóa";
            this.btn_xoatn.Click += new System.EventHandler(this.btn_xoatn_Click);
            // 
            // btn_suatn
            // 
            this.btn_suatn.Location = new System.Drawing.Point(28, 87);
            this.btn_suatn.Name = "btn_suatn";
            this.btn_suatn.Size = new System.Drawing.Size(75, 23);
            this.btn_suatn.TabIndex = 10;
            this.btn_suatn.Text = "Sửa";
            this.btn_suatn.Click += new System.EventHandler(this.btn_suatn_Click);
            // 
            // btn_themtn
            // 
            this.btn_themtn.Location = new System.Drawing.Point(28, 45);
            this.btn_themtn.Name = "btn_themtn";
            this.btn_themtn.Size = new System.Drawing.Size(75, 23);
            this.btn_themtn.TabIndex = 8;
            this.btn_themtn.Text = "Thêm";
            this.btn_themtn.Click += new System.EventHandler(this.btn_themtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_tnphong);
            this.groupControl2.Location = new System.Drawing.Point(3, 222);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(266, 208);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Danh sách tiện nghi các phòng";
            // 
            // dgv_tnphong
            // 
            this.dgv_tnphong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_tnphong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tnphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tnphong.Location = new System.Drawing.Point(5, 23);
            this.dgv_tnphong.Name = "dgv_tnphong";
            this.dgv_tnphong.Size = new System.Drawing.Size(256, 180);
            this.dgv_tnphong.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btn_luutn);
            this.groupControl3.Controls.Add(this.btn_themtn);
            this.groupControl3.Controls.Add(this.btn_xoatn);
            this.groupControl3.Controls.Add(this.btn_suatn);
            this.groupControl3.Location = new System.Drawing.Point(421, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(132, 213);
            this.groupControl3.TabIndex = 12;
            this.groupControl3.Text = "Tác vụ";
            // 
            // btn_luutn
            // 
            this.btn_luutn.Location = new System.Drawing.Point(28, 131);
            this.btn_luutn.Name = "btn_luutn";
            this.btn_luutn.Size = new System.Drawing.Size(75, 23);
            this.btn_luutn.TabIndex = 12;
            this.btn_luutn.Text = "Lưu";
            this.btn_luutn.Click += new System.EventHandler(this.btn_luutn_Click);
            // 
            // TienNghi_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TienNghi_GUI";
            this.Size = new System.Drawing.Size(625, 430);
            this.Load += new System.EventHandler(this.TienNghi_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiennghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tnphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_tiennghi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_tnphong;
        private DevExpress.XtraEditors.SimpleButton btn_xoatn;
        private DevExpress.XtraEditors.SimpleButton btn_suatn;
        private DevExpress.XtraEditors.SimpleButton btn_themtn;
        private System.Windows.Forms.TextBox txt_tentn;
        private System.Windows.Forms.TextBox txt_matn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btn_luutn;
    }
}
