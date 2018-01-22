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
    public partial class DSDichVu_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        int t = 0;
        public DSDichVu_GUI()
        {
            InitializeComponent();
        }
        //Get data từ field
        private DichVu get_data_dv()
        {
            DichVu dv = new DichVu();
            dv.MaDV = txt_madv.Text;
            dv.TenDV = txt_tendv.Text;
            dv.DonViTinh = txt_tendv.Text;
            dv.DonGia = Convert.ToInt32(txt_gia.Text);
            return dv;
        }
        //Show txt_tn
        private void show_txt_dv()
        {
            txt_tendv.Enabled = true;
            txt_donvitinh.Enabled = true;
            txt_gia.Enabled = true;
        }
        //Hide txt_tn
        private void hide_txt_dv()
        {
            txt_tendv.Enabled = false;
            txt_donvitinh.Enabled = false;
            txt_gia.Enabled = false;
        }
        //Clear txt tn
        private void clear_txt_dv()
        {
            txt_tendv.Text = "";
            txt_donvitinh.Text = "";
            txt_gia.Text = "";
            txt_tendv.Focus();
        }
        //Auto tạo mã tn
        private string set_madv()
        {
            int id;
            id = int.Parse(bl.GetLastID("MaDV").Substring(2));
            return "DV" + (id + 1).ToString();
        }
        //Clear data bind
        public void clear_binddv()
        {
            txt_madv.DataBindings.Clear();
            txt_tendv.DataBindings.Clear();
            txt_donvitinh.DataBindings.Clear();
            txt_gia.DataBindings.Clear();
            dgv_dv.DataBindings.Clear();
        }
        //Bind dịch vụ
        public void bindata_dv()
        {
            BindingSource bindSourceKH = new BindingSource();
            bindSourceKH.DataSource = qlks_e.DichVus.ToList();
            clear_binddv();
            txt_madv.DataBindings.Add("Text", bindSourceKH, "MaDV");
            txt_tendv.DataBindings.Add("Text", bindSourceKH, "TenDV");
            txt_donvitinh.DataBindings.Add("Text", bindSourceKH, "DonViTinh");
            txt_gia.DataBindings.Add("Text", bindSourceKH, "DonGia");
            dgv_dv.DataSource = bindSourceKH;
            //this.dgv_dv.Columns[2].Visible = false;
        }
        //Đổ dữ liệu ra GUI
        public void FillData()
        {
            dgv_dv.DataSource = qlks_e.DichVus.ToList();
            this.dgv_dv.Columns[4].Visible = false;
            this.dgv_dv.Columns[0].HeaderText = "Mã DV";
            this.dgv_dv.Columns[1].HeaderText = "Tên DV";
            this.dgv_dv.Columns[2].HeaderText = "Giá";
            this.dgv_dv.Columns[3].HeaderText = "Đơn Vị Tính";
        }

        private void DSDichVu_GUI_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void dgv_dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madv.Text = dgv_dv.CurrentRow.Cells[0].Value.ToString();
            txt_tendv.Text = dgv_dv.CurrentRow.Cells[1].Value.ToString();
            txt_gia.Text = dgv_dv.CurrentRow.Cells[2].Value.ToString();
            txt_donvitinh.Text = dgv_dv.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btn_them.Text == "Thêm")
            {
                btn_them.Text = "Hủy bỏ";
                show_txt_dv();
                clear_txt_dv();
                txt_madv.Text = set_madv();
                btn_luu.Enabled = true;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                dgv_dv.Enabled = false;
            }
            else
            {
                btn_them.Text = "Thêm";
                hide_txt_dv();
                bindata_dv();
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                dgv_dv.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Hủy bỏ";
                show_txt_dv();
                txt_tendv.Focus();
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = true;
                dgv_dv.Enabled = false;
            }
            else
            {
                btn_sua.Text = "Sửa";
                hide_txt_dv();
                btn_them.Enabled = true;
                btn_xoa.Enabled = true;
                btn_luu.Enabled = false;
                dgv_dv.Enabled = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                DichVu dv = get_data_dv();
                try
                {
                    qlks_e.DichVus.Add(dv);
                    qlks_e.SaveChanges();
                    bindata_dv();
                    hide_txt_dv();
                    btn_them.Text = "Thêm";
                    btn_them.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dv.Enabled = true;
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm dịch vụ thất bại!" + "\n" + ex);
                }
            }
            if (t == 2)
            {

                try
                {
                    DichVu dv = qlks_e.DichVus.Single(t => t.MaDV.Equals(txt_madv.Text));
                    dv.TenDV = txt_tendv.Text;
                    dv.DonViTinh = txt_donvitinh.Text;
                    dv.DonGia = Convert.ToInt32(txt_gia.Text);
                    qlks_e.SaveChanges();
                    bindata_dv();
                    hide_txt_dv();
                    btn_sua.Text = "Sửa";
                    btn_them.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_xoa.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dv.Enabled = true;
                    MessageBox.Show("Chỉnh sửa dịch vụ thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa dịch vụ thất bại!" + "\n" + ex);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa dịch vụ này chứ ?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string ma_dv = txt_madv.Text;
                    DichVu dv = qlks_e.DichVus.Single(t => t.MaDV.Equals(ma_dv));
                    qlks_e.DichVus.Remove(dv);
                    qlks_e.SaveChanges();
                    bindata_dv();
                    MessageBox.Show("Xóa dịch vụ thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dịch vụ thất bại!" + ex);
                }
            }
        }

    }
}
