using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyKhachSan.GUI;

namespace QuanLyKhachSan
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AddTab clsAddTab = new AddTab();
        public MainForm()
        {
            InitializeComponent();
            clsAddTab.setTab(xtraTabControl_Main, "Quản lý phòng", new DSPhong_GUI());
        }
        //Tab thêm nhân viên
        private void btn_dsnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*NhanVien_GUI uc = new NhanVien_GUI();
            var form = new Form();
            form.Text = "Danh Sách Nhân Viên";
            form.Controls.Add(uc);
            form.MdiParent = this;
            form.Show();*/
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Thêm nhân viên")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Thêm nhân viên", new NhanVien_GUI());
            }
        }
        //Tab danh sách phòng
        private void btn_ds_phong_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Quản lý phòng")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Quản lý phòng", new DSPhong_GUI());
            }
        }
        //Tab danh sách khách hàng
        private void btn_dskh_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Danh sách khách hàng")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Danh sách khách hàng", new DSKhachHang_GUI());
            }
        }
        //Tab gọi dịch vụ
        private void btn_goidichvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Đặt dịch vụ")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Đặt dịch vụ", new DatDichVu_GUI());
            }
        }
        //Tab đặt phòng
        private void btn_dat_phong_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Đặt phòng")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Đặt phòng", new DatPhong_GUI());
            }
        }
        //Tab tiện nghi
        private void btn_tiennghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Tiện nghi")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Tiện nghi", new TienNghi_GUI());
            }
        }
        //Tab quản lý dịch vụ
        private void btn_dsdichvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl_Main.TabPages)
            {
                if (tab.Text == "Danh sách dịch vụ")
                {
                    xtraTabControl_Main.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl_Main, "Danh sách dịch vụ", new DSDichVu_GUI());
            }
        }
        //Đóng Form
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Xác nhân đóng Form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //Nút đăng xuất
        private void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            this.Dispose(true);
            LoginForm flg = new LoginForm();
            flg.Show();
        }

        private void xtraTabControl_Main_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl_Main.SelectedTabPageIndex = xtraTabControl_Main.TabPages.Count - 1;
        }
        //Đóng tab
        private void xtraTabControl_Main_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl_Main.TabPages.RemoveAt(xtraTabControl_Main.SelectedTabPageIndex);
        }
    }
}