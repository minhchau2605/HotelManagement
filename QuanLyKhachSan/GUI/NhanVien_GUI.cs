using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace QuanLyKhachSan
{
    public partial class NhanVien_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        string ma_cv = "";
        int t = 0;
        public NhanVien_GUI()
        {
            InitializeComponent();
        }

        private void NhanVien_GUI_Load(object sender, EventArgs e)
        {
            FillData();
        }
        //Get data nv nhập từ textfield
        private NhanVien get_data_nv()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txt_manv.Text;
            nv.MaCV = cb_chucvu.SelectedValue.ToString();
            nv.TenNV = txt_hoten.Text;
            nv.NgaySinh = dtp_ngaysinh.Value;
            nv.GioiTinh = txt_gioitinh.Text;
            nv.SoCMND = Convert.ToInt32(txt_cmnd.Text);
            nv.DiaChi = txt_diachi.Text;
            nv.DienThoaiNV = Convert.ToInt32(txt_sdt.Text);
            return nv;
        }

        private NhanVien get_data_nv_update(string ma_nv)
        {
            NhanVien nv = qlks_e.NhanViens.Single(t => t.MaNV.Equals(ma_nv));
            nv.MaCV = cb_chucvu.SelectedValue.ToString();
            nv.TenNV = txt_hoten.Text;
            nv.NgaySinh = dtp_ngaysinh.Value;
            nv.GioiTinh = txt_gioitinh.Text;
            nv.SoCMND = Convert.ToInt32(txt_cmnd.Text);
            nv.DiaChi = txt_diachi.Text;
            nv.DienThoaiNV = Convert.ToInt32(txt_sdt.Text);
            qlks_e.SaveChanges();
            return nv;
        }
        //Tự động tăng mã nv
        private string set_manv()
        {
            int id = 0;
            id = int.Parse(bl.GetLastID("MaNV").Substring(2));
            return "NV" + (id + 1).ToString();
        }
        //
        private void show_txtnv()
        {
            //txt_manv.Enabled = true;
            txt_hoten.Enabled = true;
            dtp_ngaysinh.Enabled = true;
            txt_gioitinh.Enabled = true;
            txt_cmnd.Enabled = true;
            txt_sdt.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
        }

        private void hide_txtnv()
        {
            txt_hoten.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            txt_gioitinh.Enabled = false;
            txt_cmnd.Enabled = false;
            txt_sdt.Enabled = false;
            txt_email.Enabled = false;
            txt_diachi.Enabled = false;
        }
        //Lấy ds nhân viên theo chức vụ
        private void FillData()
        {
            /*dgv_dsnv.DataSource = qlks_e.NhanViens.ToList();*/
            DataTable dt_cv = new DataTable();
            cb_chucvu.DataSource = qlks_e.ChucVus.ToList();
            cb_chucvu.DisplayMember = "TenCV";
            cb_chucvu.ValueMember = "MaCV";

            cb_chucvu.SelectedIndex = 0;
            string ma_cv = cb_chucvu.SelectedValue.ToString();
            DataTable dt_nv = new DataTable();
            dt_nv = bl.ListNV(ma_cv);
            dgv_dsnv.DataSource = dt_nv;

            this.dgv_dsnv.Columns[0].HeaderText = "Mã NV";
            this.dgv_dsnv.Columns[1].HeaderText = "Tên NV";
            this.dgv_dsnv.Columns[2].HeaderText = "Ngày Sinh";
            this.dgv_dsnv.Columns[2].HeaderText = "Giới Tính";
            this.dgv_dsnv.Columns[4].HeaderText = "Số CMND";
            this.dgv_dsnv.Columns[5].HeaderText = "Địa Chỉ";
            this.dgv_dsnv.Columns[6].HeaderText = "Điện Thoại";

            txt_manv.Text = dgv_dsnv.Rows[0].Cells[0].Value.ToString();
            txt_hoten.Text = dgv_dsnv.Rows[0].Cells[1].Value.ToString();
            dtp_ngaysinh.Value = Convert.ToDateTime(dgv_dsnv.Rows[0].Cells[2].Value);
            txt_gioitinh.Text = dgv_dsnv.Rows[0].Cells[3].Value.ToString();
            txt_cmnd.Text = dgv_dsnv.Rows[0].Cells[4].Value.ToString();
            txt_diachi.Text = dgv_dsnv.Rows[0].Cells[5].Value.ToString();
            txt_sdt.Text = dgv_dsnv.Rows[0].Cells[6].Value.ToString();
        }

        private void clear_bindnv()
        {
            txt_manv.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            dtp_ngaysinh.DataBindings.Clear();
            txt_gioitinh.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            txt_cmnd.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            dgv_dsnv.DataBindings.Clear();
        }
        //Lấy dữ liêu nhân viên hiển thị ra DataGridView+TextField khi chọn lại chức vụ 
        private void bindata_nv()
        {
            BindingSource bindSourceNV = new BindingSource();
            ma_cv = cb_chucvu.SelectedValue.ToString();
            bindSourceNV.DataSource = bl.ListNV(ma_cv);
            clear_bindnv();
            txt_manv.DataBindings.Add("Text", bindSourceNV, "MaNV");
            txt_hoten.DataBindings.Add("Text", bindSourceNV, "TenNV");
            dtp_ngaysinh.DataBindings.Add("Value", bindSourceNV, "NgaySinh");
            txt_gioitinh.DataBindings.Add("Text", bindSourceNV, "GioiTinh");
            txt_cmnd.DataBindings.Add("Text", bindSourceNV, "SoCMND");
            txt_diachi.DataBindings.Add("Text", bindSourceNV, "DiaChi");
            txt_sdt.DataBindings.Add("Text", bindSourceNV, "DienThoaiNV");
            dgv_dsnv.DataSource = bindSourceNV;
        }

        private void show_txt_nv()
        {
            txt_hoten.Enabled = true;
            dtp_ngaysinh.Enabled = true;
            txt_gioitinh.Enabled = true;
            txt_cmnd.Enabled = true;
            txt_sdt.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
        }

        private void hide_txt_nv()
        {
            txt_hoten.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            txt_gioitinh.Enabled = false;
            txt_cmnd.Enabled = false;
            txt_sdt.Enabled = false;
            txt_email.Enabled = false;
            txt_diachi.Enabled = false;
        }

        private void clear_txt_nv()
        {
            txt_hoten.Text = "";
            dtp_ngaysinh.Value = DateTime.Today;
            txt_gioitinh.Text = "";
            txt_cmnd.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            cb_chucvu.Focus();
        }

        private void cb_chucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_them.Text != "Hủy bỏ" && btn_sua.Text != "Hủy bỏ")
            {
                bindata_nv();
            }
        }
        //Thêm nhân viên
        private void btn_them_Click(object sender, EventArgs e)
        {
                dgv_dsnv.ClearSelection();
                t = 1;
                if (btn_them.Text == "Thêm")
                {
                    btn_them.Text = "Hủy bỏ";
                    show_txt_nv();
                    clear_txt_nv();
                    txt_manv.Text = set_manv();
                    btn_luu.Enabled = true;
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                    dgv_dsnv.Enabled = false;
                }
                else
                {
                    btn_them.Text = "Thêm";
                    hide_txt_nv();
                    bindata_nv();
                    btn_luu.Enabled = false;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    dgv_dsnv.Enabled = true;
                }
        }
        //Sửa nhân viên
        private void btn_sua_Click(object sender, EventArgs e)
        {
            dgv_dsnv.ClearSelection();
            t = 2;
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Hủy bỏ";
                show_txt_nv();
                txt_hoten.Focus();
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = true;
                dgv_dsnv.Enabled = false;
            }
            else
            {
                btn_sua.Text = "Sửa";
                hide_txt_nv();
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;
                dgv_dsnv.Enabled = true;
            }
        }
        //Xóa nhân viên
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này chứ ?","", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string ma_nv = txt_manv.Text;
                    NhanVien nv = qlks_e.NhanViens.Single(t => t.MaNV.Equals(ma_nv));
                    qlks_e.NhanViens.Remove(nv);
                    qlks_e.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công!");
                    bindata_nv();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa nhân viên thất bại!"+ex);
                }
            }
        }
        //Lưu tt nhân viên đã thêm,sửa
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                NhanVien nv = get_data_nv();
                try
                {
                    qlks_e.NhanViens.Add(nv);
                    qlks_e.SaveChanges();         
                    bindata_nv();
                    hide_txt_nv();
                    btn_them.Text = "Thêm";
                    btn_them.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dsnv.Enabled = true;
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm nhân viên thất bại!" + ex);
                }
            }
            if (t == 2)
            {
                try
                {
                    string ma_nv = txt_manv.Text;
                    NhanVien nv = get_data_nv_update(ma_nv);              
                    bindata_nv();
                    hide_txt_nv();
                    btn_sua.Text = "Sửa";
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dsnv.Enabled = true;
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa nhân viên thất bại!"+ex);
                }
            }
        }
    }
}
