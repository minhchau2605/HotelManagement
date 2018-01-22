namespace QuanLyKhachSan.GUI
{
    partial class PhongDoiV_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongDoiV_GUI));
            this.P4 = new DevExpress.XtraEditors.SimpleButton();
            this.P9 = new DevExpress.XtraEditors.SimpleButton();
            this.P14 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // P4
            // 
            this.P4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P4.Appearance.Options.UseFont = true;
            this.P4.Image = ((System.Drawing.Image)(resources.GetObject("P4.Image")));
            this.P4.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P4.Location = new System.Drawing.Point(22, 14);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(94, 80);
            this.P4.TabIndex = 2;
            this.P4.Text = "P4";
            this.P4.Click += new System.EventHandler(this.btn_Click);
            this.P4.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P9
            // 
            this.P9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P9.Appearance.Options.UseFont = true;
            this.P9.Image = ((System.Drawing.Image)(resources.GetObject("P9.Image")));
            this.P9.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P9.Location = new System.Drawing.Point(180, 14);
            this.P9.Name = "P9";
            this.P9.Size = new System.Drawing.Size(94, 80);
            this.P9.TabIndex = 3;
            this.P9.Text = "P9";
            this.P9.Click += new System.EventHandler(this.btn_Click);
            this.P9.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P14
            // 
            this.P14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P14.Appearance.Options.UseFont = true;
            this.P14.Image = ((System.Drawing.Image)(resources.GetObject("P14.Image")));
            this.P14.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P14.Location = new System.Drawing.Point(333, 14);
            this.P14.Name = "P14";
            this.P14.Size = new System.Drawing.Size(94, 80);
            this.P14.TabIndex = 4;
            this.P14.Text = "P14";
            this.P14.Click += new System.EventHandler(this.btn_Click);
            this.P14.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // PhongDoiV_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P14);
            this.Controls.Add(this.P9);
            this.Controls.Add(this.P4);
            this.Name = "PhongDoiV_GUI";
            this.Size = new System.Drawing.Size(720, 381);
            this.Load += new System.EventHandler(this.PhongDoiV_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton P4;
        private DevExpress.XtraEditors.SimpleButton P9;
        private DevExpress.XtraEditors.SimpleButton P14;
    }
}
