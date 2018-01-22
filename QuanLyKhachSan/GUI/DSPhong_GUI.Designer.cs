namespace QuanLyKhachSan.GUI
{
    partial class DSPhong_GUI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rb_dacbiet = new System.Windows.Forms.RadioButton();
            this.rb_doiv = new System.Windows.Forms.RadioButton();
            this.rb_donv = new System.Windows.Forms.RadioButton();
            this.rb_doit = new System.Windows.Forms.RadioButton();
            this.rb_dont = new System.Windows.Forms.RadioButton();
            this.txt_slphong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl_LP = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_slphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_LP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rb_dacbiet);
            this.panelControl1.Controls.Add(this.rb_doiv);
            this.panelControl1.Controls.Add(this.rb_donv);
            this.panelControl1.Controls.Add(this.rb_doit);
            this.panelControl1.Controls.Add(this.rb_dont);
            this.panelControl1.Controls.Add(this.txt_slphong);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(756, 51);
            this.panelControl1.TabIndex = 1;
            // 
            // rb_dacbiet
            // 
            this.rb_dacbiet.AutoSize = true;
            this.rb_dacbiet.Location = new System.Drawing.Point(512, 17);
            this.rb_dacbiet.Name = "rb_dacbiet";
            this.rb_dacbiet.Size = new System.Drawing.Size(65, 17);
            this.rb_dacbiet.TabIndex = 7;
            this.rb_dacbiet.TabStop = true;
            this.rb_dacbiet.Text = "Đặc Biệt";
            this.rb_dacbiet.UseVisualStyleBackColor = true;
            this.rb_dacbiet.Click += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // rb_doiv
            // 
            this.rb_doiv.AutoSize = true;
            this.rb_doiv.Location = new System.Drawing.Point(417, 15);
            this.rb_doiv.Name = "rb_doiv";
            this.rb_doiv.Size = new System.Drawing.Size(58, 17);
            this.rb_doiv.TabIndex = 6;
            this.rb_doiv.TabStop = true;
            this.rb_doiv.Text = "Đôi Vip";
            this.rb_doiv.UseVisualStyleBackColor = true;
            this.rb_doiv.Click += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // rb_donv
            // 
            this.rb_donv.AutoSize = true;
            this.rb_donv.Location = new System.Drawing.Point(323, 15);
            this.rb_donv.Name = "rb_donv";
            this.rb_donv.Size = new System.Drawing.Size(62, 17);
            this.rb_donv.TabIndex = 5;
            this.rb_donv.TabStop = true;
            this.rb_donv.Text = "Đơn Vip";
            this.rb_donv.UseVisualStyleBackColor = true;
            this.rb_donv.Click += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // rb_doit
            // 
            this.rb_doit.AutoSize = true;
            this.rb_doit.Location = new System.Drawing.Point(214, 15);
            this.rb_doit.Name = "rb_doit";
            this.rb_doit.Size = new System.Drawing.Size(81, 17);
            this.rb_doit.TabIndex = 4;
            this.rb_doit.TabStop = true;
            this.rb_doit.Text = "Đôi Thường";
            this.rb_doit.UseVisualStyleBackColor = true;
            this.rb_doit.Click += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // rb_dont
            // 
            this.rb_dont.AutoSize = true;
            this.rb_dont.Checked = true;
            this.rb_dont.Location = new System.Drawing.Point(107, 15);
            this.rb_dont.Name = "rb_dont";
            this.rb_dont.Size = new System.Drawing.Size(85, 17);
            this.rb_dont.TabIndex = 3;
            this.rb_dont.TabStop = true;
            this.rb_dont.Text = "Đơn Thường";
            this.rb_dont.UseVisualStyleBackColor = true;
            this.rb_dont.CheckedChanged += new System.EventHandler(this.Room_CheckedChanged);
            this.rb_dont.Click += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // txt_slphong
            // 
            this.txt_slphong.Enabled = false;
            this.txt_slphong.Location = new System.Drawing.Point(680, 16);
            this.txt_slphong.Name = "txt_slphong";
            this.txt_slphong.Size = new System.Drawing.Size(53, 20);
            this.txt_slphong.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn loại phòng:";
            // 
            // xtraTabControl_LP
            // 
            this.xtraTabControl_LP.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl_LP.Location = new System.Drawing.Point(3, 60);
            this.xtraTabControl_LP.Name = "xtraTabControl_LP";
            this.xtraTabControl_LP.Size = new System.Drawing.Size(759, 386);
            this.xtraTabControl_LP.TabIndex = 2;
            this.xtraTabControl_LP.CloseButtonClick += new System.EventHandler(this.xtraTabControl_LP_CloseButtonClick);
            this.xtraTabControl_LP.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabControl_LP_ControlAdded);
            // 
            // DSPhong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl_LP);
            this.Controls.Add(this.panelControl1);
            this.Name = "DSPhong_GUI";
            this.Size = new System.Drawing.Size(762, 449);
            this.Load += new System.EventHandler(this.DSPhong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_slphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_LP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton rb_dacbiet;
        private System.Windows.Forms.RadioButton rb_doiv;
        private System.Windows.Forms.RadioButton rb_donv;
        private System.Windows.Forms.RadioButton rb_doit;
        private System.Windows.Forms.RadioButton rb_dont;
        private DevExpress.XtraEditors.TextEdit txt_slphong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_LP;
    }
}
