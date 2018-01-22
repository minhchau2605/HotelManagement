namespace QuanLyKhachSan.GUI
{
    partial class PhongDonT_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongDonT_GUI));
            this.P1 = new DevExpress.XtraEditors.SimpleButton();
            this.P6 = new DevExpress.XtraEditors.SimpleButton();
            this.P11 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Appearance.Options.UseFont = true;
            this.P1.Image = ((System.Drawing.Image)(resources.GetObject("P1.Image")));
            this.P1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P1.Location = new System.Drawing.Point(30, 23);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(94, 80);
            this.P1.TabIndex = 1;
            this.P1.Text = "P1";
            this.P1.Click += new System.EventHandler(this.btn_Click);
            this.P1.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P6
            // 
            this.P6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P6.Appearance.Options.UseFont = true;
            this.P6.Image = ((System.Drawing.Image)(resources.GetObject("P6.Image")));
            this.P6.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P6.Location = new System.Drawing.Point(183, 23);
            this.P6.Name = "P6";
            this.P6.Size = new System.Drawing.Size(94, 80);
            this.P6.TabIndex = 2;
            this.P6.Text = "P6";
            this.P6.Click += new System.EventHandler(this.btn_Click);
            this.P6.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P11
            // 
            this.P11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P11.Appearance.Options.UseFont = true;
            this.P11.Image = ((System.Drawing.Image)(resources.GetObject("P11.Image")));
            this.P11.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P11.Location = new System.Drawing.Point(357, 23);
            this.P11.Name = "P11";
            this.P11.Size = new System.Drawing.Size(94, 80);
            this.P11.TabIndex = 3;
            this.P11.Text = "P11";
            this.P11.Click += new System.EventHandler(this.btn_Click);
            this.P11.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // PhongDonT_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P11);
            this.Controls.Add(this.P6);
            this.Controls.Add(this.P1);
            this.Name = "PhongDonT_GUI";
            this.Size = new System.Drawing.Size(740, 468);
            this.Load += new System.EventHandler(this.PhongDonT_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton P1;
        private DevExpress.XtraEditors.SimpleButton P6;
        private DevExpress.XtraEditors.SimpleButton P11;
    }
}
