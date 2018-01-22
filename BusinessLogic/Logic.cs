using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace BusinessLogic
{
    public class Logic
    {
        Data da = new Data();
        DataTable dt = new DataTable();
        SpDataAccess sda = new SpDataAccess();
        //Kiểm tra quyền login nv
        public DataTable Login(QuyenNV qnv)
        {
            return sda.Login(qnv);
        }
        //DS Nhân Viên theo mã CV
        public DataTable ListNV(string ma_cv)
        {
            return sda.ListNV(ma_cv);
        }
        //DS Phòng còn trống theo mã loại phòng
        public DataTable ListRoom(string loai_phong)
        {
            return sda.ListRoomEmpty(loai_phong);
        }
        //List ct đặt phòng
        public DataTable ListCTDP(string ma_pt)
        {
            return sda.ListCTDP(ma_pt);
        }
        //List phiếu thuê phòng theo mã kh
        public DataTable ListPT(string ma_kh)
        {
            return sda.ListPT(ma_kh);
        }
        //List hóa đơn dv theo mã pt
        public DataTable ListHDDV(string ma_pt)
        {
            return sda.ListHDDV(ma_pt);
        }
        //List chi tiết hóa đơn dv theo mã hddv
        public DataTable ListCTHDDV(string ma_hddv)
        {
            return sda.ListCTHDDV(ma_hddv);
        }
        //Thông tin phòng đã được thuê (Tên KH,Ngày đến,Ngày hẹn trả)
        public DataTable InfoRoom(string ma_phong)
        {
            return sda.InfoRoom(ma_phong);
        }
        //Update phòngtt khi trả phòng(thêm ngày trả và thành tiền)
        public DataTable Update_PhongTT(string ma_pt, string ma_phong, DateTime ngay_trap, int thanh_tien)
        {
            return sda.Update_PhongTT(ma_pt, ma_phong, ngay_trap, thanh_tien);
        }
        //Tổng tiền mỗi phòng(tạo rp hóa đơn tt) table
        public DataTable TienPhongTT_Table(string ma_pt, DateTime ngay_traph)
        {
            return sda.TienPhongTT_Table(ma_pt, ngay_traph);
        }
        //Tổng Tiền Phòng(Tạo rp Hóa đơn tt)
        public DataSet TienPhongTT(string ma_pt, DateTime ngay_traph)
        {
            return sda.TienPhongTT(ma_pt, ngay_traph);
        }
        //Tổng Tiền Phòng(Tạo Hóa đơn tt)
        public int TongTienPT(string ma_pt, DateTime ngay_traph)
        {
            dt = sda.TongTienPT(ma_pt, ngay_traph);
            return Convert.ToInt32(dt.Rows[0]["ThanhTien"].ToString());
        }
        //Tổng tiền hóa đơn dịch vụ theo mã pt
        public int TongTienHDDV_MaPT(string ma_pt)
        {
            dt = sda.TongTienHDDV_MaPT(ma_pt);
            DataRow dr = dt.Rows[0];
            //return Convert.ToInt32(dt.Rows[0]["TongTienHDDV"].ToString());
            return Convert.ToInt32(dr["TongTienHDDV"].ToString());
        }
        //
        //Đặt dịch vụ (phiếu thuê chưa tạo hddv)
        public bool InsertCTHDDV(string ma_hddv, string ma_pt, DateTime ngay_lap_hddv, string ghi_chu, string ma_dv, int sl_dv, DateTime ngay_sd)
        {
            dt = sda.InsertCTHDDV(ma_hddv, ma_pt, ngay_lap_hddv, ghi_chu, ma_dv, sl_dv, ngay_sd);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
        //Đặt dịch vụ (phiếu đã tạo hddv)
        public bool InsertDVSD(string ma_hddv, string ma_dv, int sl_dv, DateTime ngay_sd)
        {
            dt = sda.InsertDVSD(ma_hddv, ma_dv, sl_dv, ngay_sd);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
        //Trạng thái phòng
        public bool StatusRoom(string ma_phong)
        {
            dt = sda.StatusRoom(ma_phong);
            DataRow r = dt.Rows[0];
            if (r[0].ToString() == "True")
                return true;
            else
                return false;
        }
        //Cập nhật trạng thái phòng
        public bool UpdateStatusRoom(string ma_phong)
        {
            dt = sda.UpdateStatusRoom(ma_phong);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
        //Câp nhật trạng thái phòng(set trạng thái phòng = 0 (trả phòng))
        public bool TraPhong(string ma_phong)
        {
            dt = sda.TraPhong(ma_phong);
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
        }
        //Kiểm tra phiếu thuê đã có hddv chưa
        public bool TestHDDV(string ma_hddv)
        {
            dt = sda.StatusRoom(ma_hddv);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        //Lấy mã cuối cùng
        public string GetLastID(string column_name)
        {
            dt = sda.Fk_Auto(column_name);
            return dt.Rows[0][column_name].ToString();
        }
        //Số lượng phòng mỗi loại phòng
        public int GetTotalRoom(string loai_phong)
        {
            dt = sda.TotalRoom(loai_phong);
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r[0].ToString());
        }
        //Tính Tiền Cọc
        public int GetDownPayment(string loai_phong, int sl_ph)
        {
            dt = sda.DownPayment(loai_phong);
            DataRow r = dt.Rows[0];
            int don_gia = Convert.ToInt32(r[0].ToString());
            return (don_gia * sl_ph * 10 / 100);
        }
        //Câp nhật trạng thái phiếu thuê (đã thanh toán pt chưa ?)
        public bool UpdateStatusPT(string ma_pt, bool ok)
        {
            if (ok)
            {
                bool tt = true;
                dt = sda.StatusPT(ma_pt, tt);
            }
            if (dt.Rows.Count == 0)
                return true;
            else
                return false;
            //return da.ProcedureGetTable(sql, name, values, so_luong);
        }
    }
}

