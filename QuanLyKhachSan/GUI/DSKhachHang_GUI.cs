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
    public partial class DSKhachHang_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        int t = 0;
        public DSKhachHang_GUI()
        {
            InitializeComponent();
        }
        //Get data kh nhập từ textfield
        private KhachHang get_data_kh()
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txt_makh.Text;
            kh.TenKH = txt_hoten.Text;
            kh.DiachiKH = txt_diachi.Text;
            kh.DienThoaiKH = Convert.ToInt32(txt_sdt.Text);
            if (rb_nam.Checked)
            {
                kh.GioiTinh = "Nam";
            }
            else
            {
                kh.GioiTinh = "Nữ";
            }
            kh.Email = txt_email.Text;
            kh.SoCMND = Convert.ToInt32(txt_cmnd.Text);
            kh.SoHC = txt_sohc.Text;
            return kh;
        }
        //Get data kh nhập từ textfield thực hiện update tt kh
        private KhachHang get_data_update_kh(String ma_kh)
        {
            KhachHang kh = qlks_e.KhachHangs.Single(t => t.MaKH.Equals(ma_kh));
            kh.TenKH = txt_hoten.Text;
            kh.DiachiKH = txt_diachi.Text;
            kh.DienThoaiKH = Convert.ToInt32(txt_sdt.Text);
            if (rb_nam.Checked)
            {
                kh.GioiTinh = "Nam";
            }
            else
            {
                kh.GioiTinh = "Nữ";
            }
            kh.Email = txt_email.Text;
            kh.SoCMND = Convert.ToInt32(txt_cmnd.Text);
            kh.SoHC = txt_sohc.Text;
            qlks_e.SaveChanges();
            return kh;
        }
        //Tự động tăng mã nv
        private string set_makh()
        {
            int id = 0;
            id = int.Parse(bl.GetLastID("MaKH").Substring(2));
            return "KH" + (id + 1).ToString();
        }
        //Enable textfield
        private void show_txtkh()
        {
            txt_hoten.Enabled = true;
            txt_cmnd.Enabled = true;
            txt_sdt.Enabled = true;
            txt_email.Enabled = true;
            txt_diachi.Enabled = true;
            txt_sohc.Enabled = true;
        }
        //Disable textfield
        private void hide_txtkh()
        {
            txt_makh.Enabled = false;
            txt_hoten.Enabled = false;
            txt_cmnd.Enabled = false;
            txt_sdt.Enabled = false;
            txt_email.Enabled = false;
            txt_diachi.Enabled = false;
            txt_sohc.Enabled = false;
        }
        //Lấy danh sách khách hàng
        private void FillData()
        {
            dgv_dskh.DataSource = qlks_e.KhachHangs.Select(kh => new
            {
                makh = kh.MaKH,
                tenkh = kh.TenKH,
                diachi = kh.DiachiKH,
                dienthoai = kh.DienThoaiKH,
                gioitinh = kh.GioiTinh,
                email = kh.Email,
                cmnd = kh.SoCMND,
                sohc = kh.SoHC,
            }).ToList();
            this.dgv_dskh.Columns[0].HeaderText = "Mã KH";
            this.dgv_dskh.Columns[1].HeaderText = "Họ Tên";
            this.dgv_dskh.Columns[2].HeaderText = "Địa Chỉ";
            this.dgv_dskh.Columns[3].HeaderText = "SĐT";
            this.dgv_dskh.Columns[4].HeaderText = "Giới Tính";
            this.dgv_dskh.Columns[5].HeaderText = "Email";
            this.dgv_dskh.Columns[6].HeaderText = "CMND";
            this.dgv_dskh.Columns[7].HeaderText = "Hộ chiếu";

            /*txt_makh.Text = dgv_dskh.Rows[0].Cells[0].Value.ToString();
            txt_hoten.Text = dgv_dskh.Rows[0].Cells[1].Value.ToString();
            txt_diachi.Text = dgv_dskh.Rows[0].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_dskh.Rows[0].Cells[3].Value.ToString();
            string gioi_tinh = dgv_dskh.Rows[0].Cells[4].Value.ToString();
            if (gioi_tinh == "Nam")
            {
                rb_nam.Checked=true;
            }else
            {
                rb_nu.Checked = true;
            }
            txt_email.Text = dgv_dskh.Rows[0].Cells[5].Value.ToString();
            txt_cmnd.Text = dgv_dskh.Rows[0].Cells[6].Value.ToString();
            txt_sohc.Text = dgv_dskh.Rows[0].Cells[7].Value.ToString();*/
        }
        //Clear textfield
        private void clear_txtkh()
        {
            txt_hoten.Text = "";
            txt_sdt.Text = "";
            txt_email.Text = "";
            txt_diachi.Text = "";
            txt_cmnd.Text = "";
            txt_sohc.Text = "";
            txt_hoten.Focus();
        }
        //Clear databinding
        private void clear_bindkh()
        {
            txt_makh.DataBindings.Clear();
            txt_hoten.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();       
            txt_email.DataBindings.Clear();
            txt_cmnd.DataBindings.Clear();
            txt_sohc.DataBindings.Clear();
            dgv_dskh.DataBindings.Clear();
        }
        //Lấy dữ liêu khách hàng từ datagridview hiển thị ra TextField
        private void bindata_kh()
        {
            BindingSource bindSourceKH = new BindingSource();
            bindSourceKH.DataSource = qlks_e.KhachHangs.Select(kh => new
            {
                makh = kh.MaKH,
                tenkh = kh.TenKH,
                diachi = kh.DiachiKH,
                dienthoai = kh.DienThoaiKH,
                gioitinh = kh.GioiTinh,
                email = kh.Email,
                cmnd = kh.SoCMND,
                sohc = kh.SoHC,
            }).ToList();
            clear_bindkh();
            txt_makh.DataBindings.Add("Text", bindSourceKH, "makh");
            txt_hoten.DataBindings.Add("Text", bindSourceKH, "tenkh");
            txt_diachi.DataBindings.Add("Text", bindSourceKH, "diachi");
            txt_sdt.DataBindings.Add("Text", bindSourceKH, "dienthoai");
            if (rb_nam.Checked)
            {

            }
            txt_email.DataBindings.Add("Text", bindSourceKH, "email");
            txt_cmnd.DataBindings.Add("Text", bindSourceKH, "cmnd");
            txt_sohc.DataBindings.Add("Text", bindSourceKH, "sohc");
            dgv_dskh.DataSource = bindSourceKH;
        }

        private void DSKhachHang_GUI_Load(object sender, EventArgs e)
        {
            FillData();
        }
        //Thêm khách hàng
        private void btn_them_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btn_them.Text == "Thêm")
            {
                btn_them.Text = "Hủy bỏ";
                show_txtkh();
                clear_txtkh();
                txt_makh.Text = set_makh();
                btn_luu.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                dgv_dskh.Enabled = false;
            }
            else
            {
                btn_them.Text = "Thêm";
                hide_txtkh();
                bindata_kh();
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                dgv_dskh.Enabled = true;
            }
        }
        //Sửa tt khách hàng
        private void btn_sua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Hủy bỏ";
                show_txtkh();
                txt_hoten.Focus();
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = true;
                dgv_dskh.Enabled = false;
            }
            else
            {
                btn_sua.Text = "Sửa";
                hide_txtkh();
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;
                dgv_dskh.Enabled = true;
            }
        }
        //Xóa khách hàng
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này chứ ?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string ma_kh = txt_makh.Text;
                    KhachHang kh = qlks_e.KhachHangs.Single(t => t.MaKH.Equals(ma_kh));
                    qlks_e.KhachHangs.Remove(kh);
                    qlks_e.SaveChanges();
                    bindata_kh();
                    MessageBox.Show("Xóa khách hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa khách hàng thất bại!" + ex);
                }
            }
        }
        //Lưu thông tin đã sửa,thêm
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                KhachHang kh = get_data_kh();
                try
                {               
                    qlks_e.KhachHangs.Add(kh);
                    qlks_e.SaveChanges();             
                    bindata_kh();
                    hide_txtkh();
                    btn_them.Text = "Thêm";
                    btn_them.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dskh.Enabled = true;
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm khách hàng thất bại!" +"\n"+ ex);
                }
            }
            if (t == 2)
            {
                
                try
                {
                    KhachHang kh = get_data_update_kh(txt_makh.Text);               
                    bindata_kh();
                    hide_txtkh();
                    btn_sua.Text = "Sửa";
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dskh.Enabled = true;
                    MessageBox.Show("Chỉnh sửa khách hàng thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa khách hàng thất bại!"+"\n"+ex);
                }
            }
        }

        private void dgv_dskh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = dgv_dskh.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = dgv_dskh.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = dgv_dskh.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = dgv_dskh.CurrentRow.Cells[3].Value.ToString();
            string gioi_tinh = dgv_dskh.CurrentRow.Cells[4].Value.ToString();
            if (gioi_tinh == "Nam")
            {
                rb_nam.Checked = true;
            }
            else
            {
                rb_nu.Checked = true;
            }
            txt_email.Text = dgv_dskh.CurrentRow.Cells[5].Value.ToString();
            string cmnd = (dgv_dskh.CurrentRow.Cells[6].Value == null ? "" : dgv_dskh.CurrentRow.Cells[6].Value.ToString());
            txt_cmnd.Text = cmnd;
            string so_hc = (dgv_dskh.CurrentRow.Cells[7].Value == null ? "" : dgv_dskh.CurrentRow.Cells[7].Value.ToString());
            txt_sohc.Text = so_hc;
        }
    }
}
