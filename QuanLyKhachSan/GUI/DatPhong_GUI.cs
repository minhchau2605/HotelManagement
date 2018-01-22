using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
namespace QuanLyKhachSan.GUI
{
    public partial class DatPhong_GUI : UserControl
    {
        QuanLyKhachSanEntities qlks_e = new QuanLyKhachSanEntities();
        BusinessLogic.Logic bl = new BusinessLogic.Logic();
        string ma_kh = "";
        int t = 0;
        ArrayList arr = new ArrayList();
        ArrayList arr1 = new ArrayList();
        public DatPhong_GUI()
        {
            InitializeComponent();
        }
        //Get data tt phiếu thuê phòng(đặt phòng) từ textfield
        private PhieuThue getdata_dp()
        {
            PhieuThue pt = new PhieuThue();
            pt.MaPT = txt_mapt.Text;
            pt.MaNV = txt_manv.Text;
            pt.MaKH = cb_khachhang.SelectedValue.ToString();
            pt.NgaylapP = dtp_ngaydat.Value;
            pt.NgaythueP = dtp_ngayden.Value;
            pt.Ngayhentr = dtp_ngayhentra.Value;
            //pt.TienDatCoc = Convert.ToInt32(txt_tiencoc.Text);
            pt.TienDatCoc = 0;
            pt.SoLuong = Convert.ToInt32(txt_soluong.Text);
            pt.TrangThai = ckb_trangthai.Checked;
            return pt;
        }
        //Get data tt phiếu thuê phòng(đặt phòng) từ textfield để update
        private PhieuThue get_data_nv_update(string ma_pt)
        {
            PhieuThue pt = qlks_e.PhieuThues.Single(t => t.MaPT.Equals(ma_pt));

            qlks_e.SaveChanges();
            return pt;
        }
        //Get data chi tiết đặt phòng (phongtt)
        private PhongTT getdata_ctdp(ArrayList arr, int i)
        {
            PhongTT ct_dp = new PhongTT();
            ct_dp.MaPT = txt_mapt.Text;
            ct_dp.MaPhong = arr[i].ToString();
            return ct_dp;
        }
        //Show txt đặt phòng
        private void show_txtdp()
        {
            //txt_yeucau.Enabled = true;
            //cb_khachhang.Enabled = true;
            dtp_ngaydat.Enabled = true;
            dtp_ngayden.Enabled = true;
            dtp_ngayhentra.Enabled = true;
        }
        //Hide txt đặt phòng
        private void hide_txtdp()
        {
            //txt_yeucau.Enabled = false;
            //cb_khachhang.Enabled = false;
            dtp_ngaydat.Enabled = true;
            dtp_ngayden.Enabled = false;
            dtp_ngayhentra.Enabled = false;
        }
        //Clear txt đặt phòng
        private void clear_txtdp()
        {
            //cb.Text = "";
            dtp_ngaydat.Value = DateTime.Today;
            dtp_ngayden.Value = DateTime.Today;
            dtp_ngaydi.Value = DateTime.Today;
            ckb_trangthai.Checked = false;
            txt_tiencoc.Text = "";
            txt_LpDat.Text = "";
            txt_soluong.Text = "";
            //txt_makh.Focus();
        }
        //Clear bind đặt phòng
        private void clear_binddp()
        {
            txt_mapt.DataBindings.Clear();
            txt_manv.DataBindings.Clear();
            //cb_khachhang.DataBindings.Clear();
            txt_LpDat.DataBindings.Clear();
            dtp_ngayden.DataBindings.Clear();
            dtp_ngaydat.DataBindings.Clear();
            dtp_ngayhentra.DataBindings.Clear();
            txt_tiencoc.DataBindings.Clear();
            txt_soluong.DataBindings.Clear();
            ckb_trangthai.DataBindings.Clear();
            //txt_yeucau.DataBindings.Clear();
            list_datphong.DataBindings.Clear();
            dgv_dspt.DataBindings.Clear();
        }
        //Bind data đặt phòng
        private void bindata_dp()
        {
            BindingSource bsdp = new BindingSource();
            /*bsdp.DataSource = qlks_e.PhieuThues.Select(pt => new {
                mapt = pt.MaPT,
                makh = pt.MaKH,
                manv = pt.MaNV,
                ngaylapphieu = pt.NgaylapP,
                ngaythuephong = pt.NgaythueP,
                ngayhentra = pt.Ngayhentr,
                trangthai = pt.TrangThai,
                tiencoc = pt.TienDatCoc,
                yeucau = pt.Yeucau,
            }).ToList();*/

            ma_kh = cb_khachhang.SelectedValue.ToString();
            bsdp.DataSource = bl.ListPT(ma_kh);
            clear_binddp();

            txt_mapt.DataBindings.Add("Text", bsdp, "MaPT");
            txt_manv.DataBindings.Add("Text", bsdp, "MaNV");
            //cb_khachhang.DataBindings.Add("ValueMember", bsdp, "makh");
            dtp_ngaydat.DataBindings.Add("Value", bsdp, "NgaylapP");
            dtp_ngayden.DataBindings.Add("Value", bsdp, "NgaythueP");
            dtp_ngayhentra.DataBindings.Add("Value", bsdp, "Ngayhentr");
            txt_tiencoc.DataBindings.Add("Text", bsdp, "TienDatCoc");
            //txt_soluong.DataBindings.Add("Text", bsdp, "soluong");
            ckb_trangthai.DataBindings.Add("Checked", bsdp, "TrangThai");
            txt_soluong.DataBindings.Add("Text", bsdp, "SoLuong");
            dgv_dspt.DataSource = bsdp;

            bindata_list_datphong();
        }
        //Bind data list phòng còn trống để đặt
        private void bindata_list_phong()
        {
            BindingSource bsp = new BindingSource();
            string loai_phong = cb_loaiphong.SelectedValue.ToString();
            bsp.DataSource = bl.ListRoom(loai_phong);
            list_phong.DataBindings.Clear();
            list_phong.DataSource = bsp;
            list_phong.DisplayMember = "MaPhong";
            list_phong.ValueMember = "MaPhong";
        }
        //Bind data list ct đặt phòng
        private void bindata_list_datphong()
        {
            BindingSource bs_ctdp = new BindingSource();
            bs_ctdp.DataSource = bl.ListCTDP(txt_mapt.Text);
            txt_LpDat.DataBindings.Clear();
            txt_LpDat.DataBindings.Add("Text", bs_ctdp, "KieuPhong");
            list_datphong.DataSource = bs_ctdp;
            list_datphong.DisplayMember = "MaPhong";
            list_datphong.ValueMember = "MaPhong";
        }
        //Đưa dữ liệu phiếu thuê ra gridview và ds loại phòng ra combobox
        private void Fill_Data()
        {
            /*dgv_dspt.DataSource = qlks_e.PhieuThues.Select(pt => new {
                mapt = pt.MaPT,
                makh = pt.MaKH,
                manv = pt.MaNV,
                ngaylapphieu = pt.NgaylapP,
                ngaythuephong = pt.NgaythueP,
                ngayhentra = pt.Ngayhentr,
                trangthai = pt.TrangThai,
                tiencoc = pt.TienDatCoc,
                yeucau = pt.Yeucau,
            }).ToList();*/
            /*this.dgv_dspt.Columns[0].HeaderText = "Mã PT";
            this.dgv_dspt.Columns[1].HeaderText = "Mã KH";
            this.dgv_dspt.Columns[2].HeaderText = "Mã NV";
            this.dgv_dspt.Columns[3].HeaderText = "Ngày lập phiếu";
            this.dgv_dspt.Columns[4].HeaderText = "Ngày thuê phòng";
            this.dgv_dspt.Columns[5].HeaderText = "Ngày hẹn trả";
            this.dgv_dspt.Columns[6].HeaderText = "Trạng thái";
            this.dgv_dspt.Columns.Add(col_trangthai);
            this.dgv_dspt.Columns[7].HeaderText = "Tiền cọc";
            this.dgv_dspt.Columns[8].HeaderText = "Yêu cầu";*/

            //Lấy danh sách kh
            cb_khachhang.DataSource = qlks_e.KhachHangs.Select(kh => new
            {
                makh = kh.MaKH,
                tenkh = kh.TenKH,
            }).ToList();
            cb_khachhang.ValueMember = "makh";
            cb_khachhang.DisplayMember = "tenkh";

            //Lấy ds phiếu thuê theo mã kh
            string ma_kh = cb_khachhang.SelectedValue.ToString();
            DataTable dt_kh = new DataTable();
            dt_kh = bl.ListPT(ma_kh);
            dgv_dspt.DataSource = dt_kh;


            //Lấy danh sách loại phòng
            cb_loaiphong.DataSource = qlks_e.LoaiPhongs.ToList();
            cb_loaiphong.ValueMember = "LoaiPhong1";
            cb_loaiphong.DisplayMember = "KieuPhong";

            bindata_list_phong();
            bindata_dp();
        }
        //Select loại phòng => ds phòng
        private void cb_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_them.Text == "Hủy bỏ")
            {
                txt_LpDat.Text = cb_loaiphong.SelectedValue.ToString();
                txt_tiencoc.Text = bl.GetDownPayment(cb_loaiphong.SelectedValue.ToString(), int.Parse(txt_soluong.Text)).ToString();
            }
            bindata_list_phong();
        }
        //
        private void cb_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_them.Text != "Hủy bỏ" && btn_sua.Text != "Hủy bỏ")
            {
                bindata_dp();
            }
        }
        private void DatPhong_GUI_Load(object sender, EventArgs e)
        {
            Fill_Data();
        }

        private void dgv_dspt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindata_list_datphong();
            txt_mapt.Text = dgv_dspt.CurrentRow.Cells[0].Value.ToString();
            txt_manv.Text = dgv_dspt.CurrentRow.Cells[1].Value.ToString();
            //cb_khachhang = dgv_dspt.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaydat.Value = Convert.ToDateTime(dgv_dspt.CurrentRow.Cells[3].Value);
            dtp_ngayden.Value = Convert.ToDateTime(dgv_dspt.CurrentRow.Cells[4].Value);
            dtp_ngayhentra.Value = Convert.ToDateTime(dgv_dspt.CurrentRow.Cells[5].Value);
            txt_tiencoc.Text = dgv_dspt.CurrentRow.Cells[7].Value.ToString();
            ckb_trangthai.Checked = Convert.ToBoolean(dgv_dspt.CurrentRow.Cells[6].Value);
            //string yeu_cau = (dgv_dspt.CurrentRow.Cells[8].Value == null ? "" : dgv_dspt.CurrentRow.Cells[6].Value.ToString());
            //txt_yeucau.Text = yeu_cau;
        }
        //Tự động tăng mã pt
        private string set_mapt()
        {
            int id;
            id = int.Parse(bl.GetLastID("MaPT").Substring(2));
            return "PT" + (id + 1).ToString();
        }
        //Setting button
        private void enablemove()
        {
            btn_AddAll.Enabled = true;
            btn_AddOne.Enabled = true;
            btn_ClearOne.Enabled = true;
            btn_ClearAll.Enabled = true;
        }
        //Setting button
        private void disablemove()
        {
            btn_AddAll.Enabled = false;
            btn_AddOne.Enabled = false;
            btn_ClearOne.Enabled = false;
            btn_ClearAll.Enabled = false;
        }
        //Event click button thêm
        private void btn_them_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btn_them.Text == "Thêm")
            {
                //limitdate();
                btn_them.Text = "Hủy bỏ";
                enablemove();
                show_txtdp();
                clear_txtdp();
                list_datphong.DataSource = null;
                list_datphong.DataBindings.Clear();
                txt_mapt.Text = set_mapt();
                //txtmanv.Text = frmLogin.mnv;
                txt_LpDat.Text = cb_loaiphong.SelectedValue.ToString();
                btn_luu.Enabled = true;
                btn_sua.Enabled = false;
                btn_thanhtoan.Enabled = false;
                dgv_dspt.Enabled = false;
            }
            else
            {
                //nolimitdate();
                btn_them.Text = "Thêm";
                arr.Clear();
                arr1.Clear();
                disablemove();
                hide_txtdp();
                bindata_dp();
                bindata_list_phong();
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_thanhtoan.Enabled = true;
                dgv_dspt.Enabled = true;
            }
        }
        //Event click button sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Hủy bỏ";
                show_txtdp();
                //txt_makh.Focus();
                btn_them.Enabled = false;
                btn_thanhtoan.Enabled = false;
                btn_luu.Enabled = true;
                dgv_dspt.Enabled = false;
            }
            else
            {
                btn_sua.Text = "Sửa";
                hide_txtdp();
                btn_them.Enabled = true;
                btn_thanhtoan.Enabled = true;
                btn_luu.Enabled = false;
                dgv_dspt.Enabled = true;
            }
        }
        //Arr1
        private void setarr1()
        {
            string loai_phong;
            DataTable dtb = new DataTable();
            loai_phong = cb_loaiphong.SelectedValue.ToString();
            dtb = bl.ListRoom(loai_phong);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                arr1.Add(r[0]);
            }
        }
        //Event click button lưu 
        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Thêm phiếu thuê (đặt phòng)
            if (t == 1)
            {
                PhieuThue pt = getdata_dp();
                try
                {
                    qlks_e.PhieuThues.Add(pt);
                    qlks_e.SaveChanges();
                    int d = 0;
                    if (arr.Count == 0)
                    {
                        setarr1();
                        for (int i = 0; i < arr1.Count; i++)
                        {
                            qlks_e.PhongTTs.Add(getdata_ctdp(arr1, i));
                            if (qlks_e.SaveChanges() > 0)
                            {
                                bl.UpdateStatusRoom(arr1[i].ToString());
                                //lpbl.truslph(cb_loaiphong.SelectedValue.ToString());
                                d++;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < arr.Count; i++)
                        {
                            qlks_e.PhongTTs.Add(getdata_ctdp(arr1, i));
                            if (qlks_e.SaveChanges() > 0)
                            {
                                bl.UpdateStatusRoom(arr1[i].ToString());
                                //lpbl.truslph(cb_loaiphong.SelectedValue.ToString());
                                d++;
                            }
                        }
                    }
                    if (d != 0)
                        MessageBox.Show("Đặt phòng thành công!");
                    else
                        MessageBox.Show("Đặt phòng thất bại!");
                    bindata_dp();
                    hide_txtdp();
                    arr.Clear();
                    arr1.Clear();
                    disablemove();
                    bindata_list_phong();
                    btn_them.Text = "Thêm";
                    btn_them.Enabled = true;
                    btn_sua.Enabled = true;
                    btn_thanhtoan.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dspt.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Đặt phòng thất bại!" + ex);
                }
            }
            //Sửa phiếu thuê
            if (t == 2)
            {
                //DatPhong_DTO dp = getdatadp();
                try
                {
                    //DataTable dtb = (ctdpbl.dsdpct(txtmadp.Text));
                    //for (int i = 0; i < dtb.Rows.Count; i++)
                    //{
                    //    DataRow r = dtb.Rows[i];
                    //    pbl.traphong(r[0].ToString());
                    //    lpbl.congslph(txtLpDat.Text);
                    //}
                    //qlks_e.PhieuThues.
                    MessageBox.Show("Chỉnh sửa thành công!");
                    bindata_dp();
                    hide_txtdp();
                    btn_sua.Text = "Sửa";
                    btn_them.Enabled = true;
                    btn_thanhtoan.Enabled = true;
                    btn_luu.Enabled = false;
                    dgv_dspt.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa thất bại!" + ex);
                }
            }
        }
        //Button AddAll event
        private void btn_AddAll_Click(object sender, EventArgs e)
        {
            string loai_phong;
            arr.Clear();
            arr1.Clear();
            btn_ClearOne.Enabled = false;
            btn_AddOne.Enabled = false;
            BindingSource bsp = new BindingSource();
            loai_phong = cb_loaiphong.SelectedValue.ToString();
            bsp.DataSource = bl.ListRoom(loai_phong);
            list_datphong.DataBindings.Clear();
            list_datphong.DataSource = bsp;
            list_datphong.DisplayMember = "maphong";
            list_datphong.ValueMember = "maphong";
            list_phong.DataSource = null;
            list_phong.DataBindings.Clear();
            //txt_soluong.Text = pbl.dsph(tenlp).Rows.Count.ToString();
            //txttiencoc.Text = lpbl.getTiendatcoc(cb_loaiphong.SelectedValue.ToString(), int.Parse(txt_soluong.Text)).ToString();
        }

        private void btn_AddOne_Click(object sender, EventArgs e)
        {
            if (arr1.Count == 0)
            {
                setarr1();
            }

            list_datphong.DataSource = null;
            list_datphong.DataBindings.Clear();
            if (list_phong.SelectedIndex > -1)
            {
                arr.Add(list_phong.SelectedValue);
                arr1.RemoveAt(list_phong.SelectedIndex);
            }
            list_phong.ClearSelected();
            BindingSource bsOne = new BindingSource();
            bsOne.DataSource = arr;
            list_datphong.DataSource = bsOne;

            list_phong.DataSource = null;
            list_phong.DataBindings.Clear();
            list_phong.DataSource = arr1;

            if (arr.Count != 0)
                btn_ClearOne.Enabled = true;

            if (arr1.Count == 0)
                btn_AddOne.Enabled = false;
            else
                btn_AddOne.Enabled = true;
        }

        private void btn_ClearOne_Click(object sender, EventArgs e)
        {
            string tmp = arr[list_datphong.SelectedIndex].ToString();
            arr.RemoveAt(list_datphong.SelectedIndex);
            arr1.Add(tmp);
            list_phong.DataSource = null;
            list_phong.DataBindings.Clear();
            list_phong.DataSource = arr1;
            list_datphong.DataSource = null;
            list_datphong.DataBindings.Clear();
            list_datphong.DataSource = arr;
            btn_AddOne.Enabled = true;
            if (arr.Count == 0)
                btn_ClearOne.Enabled = false;
            else
                btn_ClearOne.Enabled = true;
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            arr.Clear();
            arr1.Clear();
            btn_AddOne.Enabled = true;
            btn_ClearOne.Enabled = false;
            bindata_list_phong();
            list_datphong.DataSource = null;
            list_datphong.DataBindings.Clear();
            txt_soluong.Text = "0";
        }
        //Tự tạo mã hóa đơn tt
        private string set_mahdtt()
        {
            int id;
            /*if (bl.GetLastID("MaHDDT") == "")
            {
                return "HDTT1";
            }
            else
            {*/
            id = int.Parse(bl.GetLastID("MaHDTT").Substring(4));
            return "HDTT" + (id + 1).ToString();
            //}
        }
        //Get data hoadontt
        private HoaDonTT getdata_hdtt()
        {
            string ghi_chu = "Khong co";
            HoaDonTT hdtt = new HoaDonTT();
            hdtt.MaHDTT = set_mahdtt();
            hdtt.MaPT = txt_mapt.Text;
            hdtt.MaNV = txt_manv.Text;
            hdtt.NgayLap = DateTime.Today;
            hdtt.Tongtiendv = bl.TongTienHDDV_MaPT(txt_mapt.Text);
            hdtt.Tongtienpt = bl.TongTienPT(txt_mapt.Text, dtp_ngaydi.Value);
            hdtt.GhiChu = ghi_chu;
            return hdtt;
        }

        public ArrayList getdspd()
        {
            ArrayList a = new ArrayList();
            DataTable dtb = bl.ListCTDP(txt_mapt.Text);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                //DataRow r = dtb.Rows[i];
                a.Add(dtb.Rows[i]["MaPhong"].ToString());
            }
            return a;
        }

        //Event button thanh toán
        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            //string ma_pt = "";
            if (ckb_trangthai.Checked == false)
            {
                if (MessageBox.Show("Phòng chưa trả!" + System.Environment.NewLine + "Bạn có muốn cập nhật trạng thái phòng và thanh toán?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {         
                    //ma_pt = txt_mapt.Text;
                    if (bl.UpdateStatusPT(txt_mapt.Text, true))
                    {
                        for (int i = 0; i < getdspd().Count; i++)
                        {
                            /*DataTable dt = bl.TienPhongTT_Table(txt_mapt.Text,dtp_ngaydi.Value);
                            int thanhtien = Convert.ToInt32(dt.Rows[i]["ThanhTien"].ToString());*/
                            bl.TraPhong(getdspd()[i].ToString());
                            //bl.Update_PhongTT(txt_mapt.Text, getdspd()[i].ToString(), dtp_ngaydi.Value,thanhtien);
                            //lpbl.congslph(txtLpDat.Text);
                        }
                        try
                        {
                            HoaDonTT hdtt = getdata_hdtt();
                            qlks_e.HoaDonTTs.Add(hdtt);
                            qlks_e.SaveChanges();
                            MessageBox.Show("Cập nhật thành công!");
                            ReportHDTT rp_hdtt = new ReportHDTT(txt_mapt.Text, dtp_ngaydi.Value);
                            //rp_hdtt.Parameters["TongTienPhong"].Value = "HDDV1";
                            rp_hdtt.Parameters["MaNV"].Value = "abc";
                            rp_hdtt.Parameters["ngaylap_hdtt"].Value = "abc";
                            ReportPrintTool print = new ReportPrintTool(rp_hdtt);
                            //SubRP_CTHDDV sub_rp = new SubRP_CTHDDV();
                            //sub_rp.
                            rp_hdtt.ShowPreviewDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cập nhật thất bại!" + ex);
                        }
                    }
                }
            }
            else
            {
                //ma_pt = txt_mapt.Text;
                ReportHDTT rp_hdtt = new ReportHDTT(txt_mapt.Text, dtp_ngaydi.Value);
                //rp_hdtt.Parameters["MaHDDV"].Value = "HDDV1";
                ReportPrintTool print = new ReportPrintTool(rp_hdtt);
                rp_hdtt.ShowPreviewDialog();
            }
            //DataSet ds_tienph = new DataSet();
            //string ma_pt = txt_mapt.Text;
            //string ma_hddv = 
            //DateTime ngay_traph = dtp_ngaydi.Value;
            //ds_tienph=bl.TienPhongTT(ma_pt, ngay_traph);
            //if (ds_tienph.Tables[0].Rows.Count > 0)
            // {
            //ReportHDTT rp_hdtt = new ReportHDTT(ma_pt,ngay_traph);
            //rp_hdtt.Parameters["MaHDDV"].Value = "HDDV1";
            //ReportPrintTool print = new ReportPrintTool(rp_hdtt);
            //rp_hdtt.ShowPreviewDialog();
            //}

            /*DataTable dt_cthddv = new DataTable();
            string ma_hddv = txt_mapt.Text;
            dt_cthddv = bl.ListCTHDDV(ma_hddv);
            if (dt_cthddv.Rows.Count > 0)
            {
                ReportHDTT rp_hdtt = new ReportHDTT();
                rp_hdtt.DataSource = ds_tienph;
                rp_hdtt.ShowPreviewDialog();
            }*/
        }
    }
}

