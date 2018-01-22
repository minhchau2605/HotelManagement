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
    public partial class DSPhong_GUI : UserControl
    {
        AddTab at = new AddTab();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        public DSPhong_GUI()
        {
            InitializeComponent();
        }

        private void xtraTabControl_LP_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl_LP.TabPages.RemoveAt(xtraTabControl_LP.SelectedTabPageIndex);
        }

        private void xtraTabControl_LP_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl_LP.SelectedTabPageIndex = xtraTabControl_LP.TabPages.Count - 1;
        }

        private void DSPhong_GUI_Load(object sender, EventArgs e)
        {
            txt_slphong.Text = bl.GetTotalRoom("T1").ToString();
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
            {
                if (tab.Text == "Đơn Thường")
                {
                    xtraTabControl_LP.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                at.setTab(xtraTabControl_LP, "Đơn Thường", new PhongDonT_GUI());
            }
        }

        private void Room_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Text == "Đơn Thường")
            {
                txt_slphong.Text = bl.GetTotalRoom("T1").ToString();
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
                {
                    if (tab.Text == "Đơn Thường")
                    {
                        xtraTabControl_LP.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabControl_LP, "Đơn Thường", new PhongDonT_GUI());
                }
            }
            if (rdb.Text == "Đôi Thường")
            {
                txt_slphong.Text = bl.GetTotalRoom("T2").ToString();
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
                {
                    if (tab.Text == "Đôi Thường")
                    {
                        xtraTabControl_LP.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabControl_LP, "Đôi Thường", new PhongDoiT_GUI());
                }
            }
            if (rdb.Text == "Đơn Vip")
            {
                txt_slphong.Text = bl.GetTotalRoom("VIP1").ToString();
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
                {
                    if (tab.Text == "Đơn Vip")
                    {
                        xtraTabControl_LP.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabControl_LP, "Đơn Vip", new PhongDonV_GUI());
                }
            }
            if (rdb.Text == "Đôi Vip")
            {
                txt_slphong.Text = bl.GetTotalRoom("VIP2").ToString();
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
                {
                    if (tab.Text == "Đôi Vip")
                    {
                        xtraTabControl_LP.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabControl_LP, "Đôi Vip", new PhongDoiV_GUI());
                }
            }
            if (rdb.Text == "Đặc Biệt")
            {
                txt_slphong.Text = bl.GetTotalRoom("VIP3").ToString();
                int t = 0;
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_LP.TabPages)
                {
                    if (tab.Text == "Đặc Biệt")
                    {
                        xtraTabControl_LP.SelectedTabPage = tab;
                        t = 1;
                    }
                }
                if (t != 1)
                {
                    at.setTab(xtraTabControl_LP, "Đặc Biệt", new PhongDB_GUI());
                }
            }
        }
    }
}
