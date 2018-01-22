using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
namespace QuanLyKhachSan
{
    public partial class ReportHDTT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHDTT(string ma_pt, DateTime ngay_traph)
        {
            InitializeComponent();
            tong_tien_phongTableAdapter.Fill(qlkS_DATASET1.tong_tien_phong, ma_pt, ngay_traph);
            //cthddv_mahddvTableAdapter.Fill(qlkS_DATASET1.cthddv_mahddv, "hddv1");
            //xrSubreport_cthddv.ParameterBindings.Add()
        }
        /*public ReportHDTT(string ma_pt)
        {
            InitializeComponent();
            tong_tien_phongTableAdapter.Fill(qlkS_DATASET1.tong_tien_phong, ma_pt, ngay_traph);
            //cthddv_mahddvTableAdapter.Fill(qlkS_DATASET1.cthddv_mahddv, "hddv1");
            //xrSubreport_cthddv.ParameterBindings.Add()
        }*/

    }
}
