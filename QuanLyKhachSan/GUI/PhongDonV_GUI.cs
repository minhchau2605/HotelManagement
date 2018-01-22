using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class PhongDonV_GUI : UserControl
    {
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        public PhongDonV_GUI()
        {
            InitializeComponent();
        }
        //Set ảnh trạng thái cho các phòng 
        private void setImg()
        {
            foreach (DevExpress.XtraEditors.SimpleButton c in this.Controls)
            {
                if (bl.StatusRoom(c.Text.ToString()))
                {
                    c.Image = Image.FromFile("../../Resources/smile.png");
                }
                else
                {
                    c.Image = Image.FromFile("../../Resources/themphong.png");
                }
            }
        }

        private void PhongDonV_GUI_Load(object sender, EventArgs e)
        {
            setImg();
        }

        private string settooltip(DevExpress.XtraEditors.SimpleButton btn, bool b)
        {
            string info = "";
            if (b)
            {
                DataTable dtb = new DataTable();
                dtb = bl.InfoRoom(btn.Name.ToString());
                DataRow r = dtb.Rows[0];
                info = "Khách hàng: " + r[0].ToString() + " - " + r[1].ToString() + System.Environment.NewLine + "Ngày đến: " + r[2].ToString() + System.Environment.NewLine + "Ngày hẹn trả: " + r[3].ToString();
            }
            else
            {
                info = "Phòng trống";
            }
            return info;
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            if (bl.StatusRoom(btn.Text))
            {
                tt.Show(settooltip(btn, true), btn);
            }
            else
            {
                tt.Show(settooltip(btn, false), btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)sender;
            if (bl.StatusRoom(btn.Text))
            {
                MessageBox.Show(settooltip(btn, true), "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(settooltip(btn, false), "Thông tin phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
