using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
namespace QuanLyKhachSan.GUI
{
    public partial class DatDichVu_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        public DatDichVu_GUI()
        {
            InitializeComponent();
        }
        //Bind data hddv
        private void bindata_hddv()
        {
            dgv_hddv.DataSource = bl.ListHDDV(cb_phong.SelectedValue.ToString());
            dgv_hddv.Columns[1].Visible = false;
            dgv_dvsd.DataSource = null;
            //bindata_cthddv();
        }
        //Bind data cthddv
        private void bindata_cthddv()
        {
            BindingSource bs_cthddv = new BindingSource();
            bs_cthddv.DataSource = bl.ListCTHDDV(txt_mahddv.Text);
            dgv_dvsd.DataSource = bs_cthddv;
            //this.dgv_dvsd.Columns[0].Visible = false;
            this.dgv_dvsd.Columns[0].Visible = false;
            this.dgv_dvsd.Columns[1].HeaderText = "Tên Dịch Vụ";
            this.dgv_dvsd.Columns[2].HeaderText = "Số Lượng/Thời gian";
            this.dgv_dvsd.Columns[3].HeaderText = "Ngày SD";
            this.dgv_dvsd.Columns[4].HeaderText = "Tổng Tiền";
            /*list_dvsd.DataBindings.Clear();
            list_dvsd.DataSource = bs_cthddv;
            list_dvsd.DisplayMember = "TenDV";
            list_dvsd.ValueMember = "MaHDDV";*/
            //string ma_hddv = (dgv_hddv.CurrentRow.Cells[0].Value == null ? "" : dgv_hddv.CurrentRow.Cells[0].Value.ToString());
            //string ma_hddv = dgv_hddv.CurrentRow.Cells[0].ToString();
            //dgv_cthddv.DataSource = bl.ListCTHDDV(ma_hddv);
        }
        //Ðổ dữ liệu cần thiết ra GUI
        private void FillData()
        {
            dgv_dsdv.DataSource = qlks_e.DichVus.Select(dv => new
            {
                madv = dv.MaDV,
                tendv = dv.TenDV,
                dongia = dv.DonGia,
                donvitinh = dv.DonViTinh,
            }).ToList();
            this.dgv_dsdv.Columns[1].HeaderText = "Tên Dịch Vụ";
            this.dgv_dsdv.Columns[0].Visible = false;
            this.dgv_dsdv.Columns[2].Visible = false;
            this.dgv_dsdv.Columns[3].Visible = false;
            txt_dongia.Text = this.dgv_dsdv.Rows[0].Cells[2].Value.ToString();
            txt_donvi.Text = this.dgv_dsdv.Rows[0].Cells[3].Value.ToString();
            txt_dichvu.Text = this.dgv_dsdv.Rows[0].Cells[0].Value.ToString();

            cb_phong.DataSource = qlks_e.PhongTTs.Select(ptt => new
            {
                mapt = ptt.MaPT,
                maphong = ptt.MaPhong,
            }).ToList();
            cb_phong.ValueMember = "mapt";
            cb_phong.DisplayMember = "maphong";

            bindata_hddv();
            //bindata_cthddv();
        }

        private void DatDichVu_GUI_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void dgv_dsdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dongia.Text = this.dgv_dsdv.CurrentRow.Cells[2].Value.ToString();
            txt_donvi.Text = this.dgv_dsdv.CurrentRow.Cells[3].Value.ToString();
            txt_dichvu.Text = this.dgv_dsdv.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_hddv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahddv.Text = this.dgv_hddv.CurrentRow.Cells[0].Value.ToString();
            bindata_cthddv();
        }
        //Auto tạo mã HDDV
        private string set_mahddv()
        {
            int id;
            id = int.Parse(bl.GetLastID("MaHDDV").Substring(4));
            return "HDDV" + (id + 1).ToString();
        }
        private void btn_datdv_Click(object sender, EventArgs e)
        {
            if (txt_mahddv.Text == null)
            {
                try
                {
                    string ma_hddv = set_mahddv();
                    string ma_pt = cb_phong.SelectedValue.ToString();
                    DateTime ngay_lap_hddv = dtp_ngaydat.Value;
                    string ghi_chu = "";
                    string ma_dv = txt_dichvu.Text;
                    int sl_dv = Convert.ToInt32(nud_soluong.Value);
                    DateTime ngay_sd = dtp_ngaydat.Value;
                    bl.InsertCTHDDV(ma_hddv, ma_pt, ngay_lap_hddv, ghi_chu, ma_dv, sl_dv, ngay_sd);
                    bindata_hddv();
                    bindata_cthddv();
                    MessageBox.Show("Đặt dịch vụ thành công");
                    bindata_hddv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Đặt dịch vụ thất bại!" + ex);
                }
            }
            else
            {
                try
                {
                    string ma_hddv = txt_mahddv.Text;
                    string ma_dv = txt_dichvu.Text;
                    int so_luong = Convert.ToInt32(nud_soluong.Value);
                    DateTime ngay_sd = dtp_ngaydat.Value;
                    bl.InsertDVSD(ma_hddv, ma_dv, so_luong, ngay_sd);
                    MessageBox.Show("Đặt dịch vụ thành công");
                    bindata_hddv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Đặt dịch vụ thất bại!" + ex);
                }
            }
        }

        private void cb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindata_hddv();
        }

        private void btn_taohddv_Click(object sender, EventArgs e)
        {
            string ma_hddv = txt_mahddv.Text;
            /*Parameter pam_ma_hddv = new Parameter();
            pam_ma_hddv.Name = "MaHDDV";
            pam_ma_hddv.Type = typeof(System.String);
            pam_ma_hddv.Value = txt_mahddv.Text;
            pam_ma_hddv.Visible = true;*/
            ReportCTHDDV rp_cthddv = new ReportCTHDDV(ma_hddv);
            //rp_cthddv.Parameters["MaHDDV"].Value = txt_mahddv.Text;
            ReportPrintTool pt = new ReportPrintTool(rp_cthddv);       
            rp_cthddv.ShowPreviewDialog();
        }
    }
}
