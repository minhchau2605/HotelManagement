namespace QuanLyKhachSan.GUI
{
    partial class PhongDB_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhongDB_GUI));
            this.P5 = new DevExpress.XtraEditors.SimpleButton();
            this.P10 = new DevExpress.XtraEditors.SimpleButton();
            this.P15 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // P5
            // 
            this.P5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P5.Appearance.Options.UseFont = true;
            this.P5.Image = ((System.Drawing.Image)(resources.GetObject("P5.Image")));
            this.P5.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P5.Location = new System.Drawing.Point(19, 14);
            this.P5.Name = "P5";
            this.P5.Size = new System.Drawing.Size(94, 80);
            this.P5.TabIndex = 3;
            this.P5.Text = "P5";
            this.P5.Click += new System.EventHandler(this.btn_Click);
            this.P5.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P10
            // 
            this.P10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P10.Appearance.Options.UseFont = true;
            this.P10.Image = ((System.Drawing.Image)(resources.GetObject("P10.Image")));
            this.P10.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P10.Location = new System.Drawing.Point(172, 14);
            this.P10.Name = "P10";
            this.P10.Size = new System.Drawing.Size(94, 80);
            this.P10.TabIndex = 4;
            this.P10.Text = "P10";
            this.P10.Click += new System.EventHandler(this.btn_Click);
            this.P10.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // P15
            // 
            this.P15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P15.Appearance.Options.UseFont = true;
            this.P15.Image = ((System.Drawing.Image)(resources.GetObject("P15.Image")));
            this.P15.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.P15.Location = new System.Drawing.Point(322, 14);
            this.P15.Name = "P15";
            this.P15.Size = new System.Drawing.Size(94, 80);
            this.P15.TabIndex = 5;
            this.P15.Text = "P15";
            this.P15.Click += new System.EventHandler(this.btn_Click);
            this.P15.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // PhongDB_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P15);
            this.Controls.Add(this.P10);
            this.Controls.Add(this.P5);
            this.Name = "PhongDB_GUI";
            this.Size = new System.Drawing.Size(725, 375);
            this.Load += new System.EventHandler(this.PhongDB_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton P5;
        private DevExpress.XtraEditors.SimpleButton P10;
        private DevExpress.XtraEditors.SimpleButton P15;
    }
}
