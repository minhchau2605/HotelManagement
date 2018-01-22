namespace QuanLyKhachSan.GUI
{
    partial class PhongDonV_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongDonV_GUI));
            this.P3 = new DevExpress.XtraEditors.SimpleButton();
            this.P13 = new DevExpress.XtraEditors.SimpleButton();
            this.P8 = new DevExpress.XtraEditors.SimpleButton();
            this.P16 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // P3
            // 
            this.P3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P3.Appearance.Options.UseFont = true;
            this.P3.Image = ((System.Drawing.Image)(resources.GetObject("P3.Image")));
            this.P3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P3.Location = new System.Drawing.Point(27, 18);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(94, 80);
            this.P3.TabIndex = 3;
            this.P3.Text = "P3";
            this.P3.Click += new System.EventHandler(this.btn_Click);
            this.P3.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P13
            // 
            this.P13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P13.Appearance.Options.UseFont = true;
            this.P13.Image = ((System.Drawing.Image)(resources.GetObject("P13.Image")));
            this.P13.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P13.Location = new System.Drawing.Point(289, 18);
            this.P13.Name = "P13";
            this.P13.Size = new System.Drawing.Size(94, 80);
            this.P13.TabIndex = 4;
            this.P13.Text = "P13";
            this.P13.Click += new System.EventHandler(this.btn_Click);
            this.P13.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P8
            // 
            this.P8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8.Appearance.Options.UseFont = true;
            this.P8.Image = ((System.Drawing.Image)(resources.GetObject("P8.Image")));
            this.P8.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P8.Location = new System.Drawing.Point(161, 18);
            this.P8.Name = "P8";
            this.P8.Size = new System.Drawing.Size(94, 80);
            this.P8.TabIndex = 5;
            this.P8.Text = "P8";
            this.P8.Click += new System.EventHandler(this.btn_Click);
            this.P8.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P16
            // 
            this.P16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P16.Appearance.Options.UseFont = true;
            this.P16.Image = ((System.Drawing.Image)(resources.GetObject("P16.Image")));
            this.P16.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P16.Location = new System.Drawing.Point(428, 18);
            this.P16.Name = "P16";
            this.P16.Size = new System.Drawing.Size(94, 80);
            this.P16.TabIndex = 6;
            this.P16.Text = "P16";
            this.P16.Click += new System.EventHandler(this.btn_Click);
            this.P16.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // PhongDonV_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P16);
            this.Controls.Add(this.P8);
            this.Controls.Add(this.P13);
            this.Controls.Add(this.P3);
            this.Name = "PhongDonV_GUI";
            this.Size = new System.Drawing.Size(706, 379);
            this.Load += new System.EventHandler(this.PhongDonV_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton P3;
        private DevExpress.XtraEditors.SimpleButton P13;
        private DevExpress.XtraEditors.SimpleButton P8;
        private DevExpress.XtraEditors.SimpleButton P16;
    }
}
