namespace QuanLyKhachSan.GUI
{
    partial class PhongDoiT_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongDoiT_GUI));
            this.P2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // P2
            // 
            this.P2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Appearance.Options.UseFont = true;
            this.P2.Image = ((System.Drawing.Image)(resources.GetObject("P2.Image")));
            this.P2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P2.Location = new System.Drawing.Point(33, 24);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(94, 80);
            this.P2.TabIndex = 2;
            this.P2.Text = "P2";
            this.P2.Click += new System.EventHandler(this.btn_Click);
            this.P2.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(181, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 80);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "P7";
            this.simpleButton1.Click += new System.EventHandler(this.btn_Click);
            this.simpleButton1.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(336, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 80);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "P12";
            this.simpleButton2.Click += new System.EventHandler(this.btn_Click);
            this.simpleButton2.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // PhongDoiT_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.P2);
            this.Name = "PhongDoiT_GUI";
            this.Size = new System.Drawing.Size(664, 397);
            this.Load += new System.EventHandler(this.PhongDoiT_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton P2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
