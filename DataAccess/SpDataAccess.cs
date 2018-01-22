using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DataAccess
{
    public class SpDataAccess
    {
        Data da = new Data();
        //Dang nhap 
        public DataTable Login(QuyenNV qnv)
        {
            string sql = "login";
            int so_luong = 2;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaNV"; values[0] = qnv.Ma_nv;
            name[1] = "@MatKhau"; values[1] = qnv.Mat_khau;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Proc listNV theo mã cv
        public DataTable ListNV(string ma_cv)
        {
            string sql = "select_nv_macv";
            int so_luong = 1; ;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaCV"; values[0] = ma_cv;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Proc status room
        public DataTable StatusRoom(string ma_phong)
        {
            string sql = "tinhtrang_phong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPhong"; values[0] = ma_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Proc getlastID
        public DataTable Fk_Auto(string name_column)
        {
            string sql = "pk_auto";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@NameColumn"; values[0] = name_column;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Proc listPhong theo mã loại phòng
        public DataTable ListRoomEmpty(string loai_phong)
        {
            string sql = "select_dsphongtrong_loaiphong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@LoaiPhong"; values[0] = loai_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //List chi tiết đặt phòng
        public DataTable ListCTDP(string ma_pt)
        {
            string sql = "phieuthue_ctdp";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //List phiếu thuê theo mã kh
        public DataTable ListPT(string ma_kh)
        {
            string sql = "dsphieuthue_makh";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaKH"; values[0] = ma_kh;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //List hóa đơn dv theo mã pt
        public DataTable ListHDDV(string ma_pt)
        {
            string sql = "hddv_mapt";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //List chi tiết hóa đơn dv
        public DataTable ListCTHDDV(string ma_hddv)
        {
            string sql = "cthddv_mahddv";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaHDDV"; values[0] = ma_hddv;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Đặt dịch vụ (phiếu thuê chưa tạo hddv)
        public DataTable InsertCTHDDV(string ma_hddv, string ma_pt, DateTime ngay_lap_hddv, string ghi_chu, string ma_dv, int sl_dv, DateTime ngay_sd)
        {
            string sql = "them_hddv_ctdv";
            int so_luong = 7;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaHDDV"; values[0] = ma_hddv;
            name[1] = "@MaPT"; values[1] = ma_pt;
            name[2] = "@NgayLapHDDV"; values[2] = ngay_lap_hddv;
            name[3] = "@GhiChu"; values[3] = ghi_chu;
            name[4] = "@MaDV"; values[4] = ma_dv;
            name[5] = "@SoLuongDV"; values[5] = sl_dv;
            name[6] = "@NgaySD"; values[6] = ngay_sd;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        ////Đặt dịch vụ (phiếu đã tạo hddv)
        public DataTable InsertDVSD(string ma_hddv, string ma_dv, int sl_dv, DateTime ngay_sd)
        {
            string sql = "insert_dvsd";
            int so_luong = 4;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaHDDV"; values[0] = ma_hddv;
            name[1] = "@MaDV"; values[1] = ma_dv;
            name[2] = "@SoLuongDV"; values[2] = sl_dv;
            name[3] = "@NgaySD"; values[3] = ngay_sd;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Tổng tiền mỗi phòng(tạo rp hóa đơn tt)
        public DataSet TienPhongTT(string ma_pt, DateTime ngay_traph)
        {
            string sql = "tong_tien_phong";
            int so_luong = 2;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            name[1] = "@NgayTraP"; values[0] = ngay_traph;
            return da.ProcedureGetDataSet(sql, name, values, so_luong);
        }
        //Kiểm tra phiếu thuê đã tồn tại hóa đơn dv chưa ?
        public DataTable TestHDDV(string ma_hddv)
        {
            string sql = "ktra_pt_tontai_hddv";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaHDDV"; values[0] = ma_hddv;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Câp nhật trạng thái phòng(set trạng thái phòng = 1)
        public DataTable UpdateStatusRoom(string ma_phong)
        {
            string sql = "capnhat_trangthai_phong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPhong"; values[0] = ma_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Câp nhật trạng thái phòng(set trạng thái phòng = 0 (trả phòng))
        public DataTable TraPhong(string ma_phong)
        {
            string sql = "tra_phong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPhong"; values[0] = ma_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Thông tin phòng đã được thuê (Tên KH,Ngày đến,Ngày hẹn trả)
        public DataTable InfoRoom(string ma_phong)
        {
            string sql = "thongtin_phongthue";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPhong"; values[0] = ma_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Số lượng phòng mỗi loại phòng
        public DataTable TotalRoom(string loai_phong)
        {
            string sql = "slph_moi_loaiphong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@LoaiPhong"; values[0] = loai_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Lấy đơn giá loại phòng để tính tiền cọc
        public DataTable DownPayment(string loai_phong)
        {
            string sql = "tiencoc_loaiphong";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@LoaiPhong"; values[0] = loai_phong;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Câp nhật trạng thái phiếu thuê (đã trả chưa ?)
        public DataTable StatusPT(string ma_pt, bool tt)
        {
            string sql = "capnhat_trangthai_pt";
            int so_luong = 2;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            name[1] = "@TrangThai"; values[1] = tt;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Tổng tiền phiếu thuê
        public DataTable TongTienPT(string ma_pt, DateTime ngay_traph)
        {
            string sql = "tongtien_pt";
            int so_luong = 2;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            name[1] = "@NgayTraP"; values[1] = ngay_traph;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Tổng tiền hóa đơn dv theo mã pt
        public DataTable TongTienHDDV_MaPT(string ma_pt)
        {
            string sql = "tongtien_hddv_theo_mapt";
            int so_luong = 1;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Update phòngtt khi trả phòng (thêm ngày trả và thành tiền)
        public DataTable Update_PhongTT(string ma_pt, string ma_phong, DateTime ngay_trap, int thanh_tien)
        {
            string sql = "capnhat_phongtt";
            int so_luong = 3;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            name[1] = "@MaPhong"; values[1] = ma_phong;
            name[2] = "@NgayTraP"; values[2] = ngay_trap;
            name[3] = "@ThanhTien"; values[3] = thanh_tien;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
        //Tổng tiền mỗi phòng(tạo rp hóa đơn tt)
        public DataTable TienPhongTT_Table(string ma_pt, DateTime ngay_traph)
        {
            string sql = "tong_tien_phong";
            int so_luong = 2;
            string[] name = new string[so_luong];
            object[] values = new object[so_luong];
            name[0] = "@MaPT"; values[0] = ma_pt;
            name[1] = "@NgayTraP"; values[1] = ngay_traph;
            return da.ProcedureGetTable(sql, name, values, so_luong);
        }
    }

}
