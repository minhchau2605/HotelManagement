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
    public partial class TienNghi_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        int t = 0;
        public TienNghi_GUI()
        {
            InitializeComponent();
        }
        //Get data từ field
        private TienNghi get_data_tn()
        {
            TienNghi tn = new TienNghi();
            tn.MaTN = txt_matn.Text;
            tn.TenTN = txt_tentn.Text;
            return tn;
        }
        //Show txt_tn
        private void show_txt_tn()
        {
            //txt_matn.Enabled = true;
            txt_tentn.Enabled = true;
        }
        //Hide txt_tn
        private void hide_txt_tn()
        {
            //txt_matn.Enabled = false;
            txt_tentn.Enabled = false;
        }
        //Clear txt tn
        private void clear_txt_tn()
        {
            txt_tentn.Text = "";
            txt_tentn.Focus();
        }
        //Auto tạo mã tn
        private string set_matn()
        {
            int id;
            id = int.Parse(bl.GetLastID("MaTN").Substring(2));
            return "TN" + (id + 1).ToString();
        }
        //Clear data bind
        public void clear_bindtn()
        {
            txt_matn.DataBindings.Clear();
            txt_tentn.DataBindings.Clear();
            dgv_tiennghi.DataBindings.Clear();
        }
        //Bind tiện nghi
        public void bindata_tn()
        {
            BindingSource bindSourceKH = new BindingSource();
            bindSourceKH.DataSource = qlks_e.TienNghis.ToList();
            clear_bindtn();
            txt_matn.DataBindings.Add("Text", bindSourceKH, "MaTN");
            txt_tentn.DataBindings.Add("Text", bindSourceKH, "TenTN");
            dgv_tiennghi.DataSource = bindSourceKH;
            this.dgv_tiennghi.Columns[2].Visible = false;
        }
        //Đổ dữ liệu cần ra GUI
        private void FillData()
        {
            dgv_tiennghi.DataSource = qlks_e.TienNghis.ToList();
            this.dgv_tiennghi.Columns[0].HeaderText = "Mã TN";
            this.dgv_tiennghi.Columns[1].HeaderText = "Tên TN";
            this.dgv_tiennghi.Columns[2].Visible = false;
            dgv_tnphong.DataSource = qlks_e.TienNghiPhongs.ToList();
            //bindata_tn();
        }

        private void dgv_tiennghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_matn.Text = dgv_tiennghi.CurrentRow.Cells[0].Value.ToString();
            txt_tentn.Text = dgv_tiennghi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_themtn_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btn_themtn.Text == "Thêm")
            {
                btn_themtn.Text = "Hủy bỏ";
                show_txt_tn();
                clear_txt_tn();
                txt_matn.Text = set_matn();
                btn_luutn.Enabled = true;
                btn_suatn.Enabled = false;
                btn_xoatn.Enabled = false;
                dgv_tiennghi.Enabled = false;
            }
            else
            {
                btn_themtn.Text = "Thêm";
                hide_txt_tn();
                bindata_tn();
                btn_luutn.Enabled = false;
                btn_suatn.Enabled = true;
                btn_xoatn.Enabled = true;
                dgv_tiennghi.Enabled = true;
            }
        }

        private void btn_suatn_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btn_suatn.Text == "Sửa")
            {
                btn_suatn.Text = "Hủy bỏ";
                show_txt_tn();
                txt_tentn.Focus();
                btn_themtn.Enabled = false;
                btn_xoatn.Enabled = false;
                btn_luutn.Enabled = true;
                dgv_tiennghi.Enabled = false;
            }
            else
            {
                btn_suatn.Text = "Sửa";
                hide_txt_tn();
                btn_themtn.Enabled = true;
                btn_xoatn.Enabled = true;
                btn_luutn.Enabled = false;
                dgv_tiennghi.Enabled = true;
            }
        }

        private void btn_xoatn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa tiện nghi này chứ ?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string ma_tn = txt_matn.Text;
                    TienNghi tn = qlks_e.TienNghis.Single(t => t.MaTN.Equals(ma_tn));
                    qlks_e.TienNghis.Remove(tn);
                    qlks_e.SaveChanges();
                    bindata_tn();
                    MessageBox.Show("Xóa tiện nghi thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa tiện nghi thất bại!" + ex);
                }
            }
        }

        private void btn_luutn_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                TienNghi tn = get_data_tn();
                try
                {
                    qlks_e.TienNghis.Add(tn);
                    qlks_e.SaveChanges();
                    bindata_tn();
                    hide_txt_tn();
                    btn_themtn.Text = "Thêm";
                    btn_themtn.Enabled = true;
                    btn_suatn.Enabled = true;
                    btn_xoatn.Enabled = true;
                    btn_luutn.Enabled = false;
                    dgv_tiennghi.Enabled = true;
                    MessageBox.Show("Thêm tiện nghi thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm tiện nghi thất bại!" + "\n" + ex);
                }
            }
            if (t == 2)
            {

                try
                {
                    TienNghi tn = qlks_e.TienNghis.Single(t => t.MaTN.Equals(txt_matn.Text));
                    tn.TenTN = txt_tentn.Text;
                    qlks_e.SaveChanges();
                    bindata_tn();
                    hide_txt_tn();
                    btn_suatn.Text = "Sửa";
                    btn_themtn.Enabled = true;
                    btn_suatn.Enabled = true;
                    btn_xoatn.Enabled = true;
                    btn_luutn.Enabled = false;
                    dgv_tiennghi.Enabled = true;
                    MessageBox.Show("Chỉnh sửa tiện nghi thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa tiện nghi thất bại!" + "\n" + ex);
                }
            }
        }

        private void TienNghi_GUI_Load(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
