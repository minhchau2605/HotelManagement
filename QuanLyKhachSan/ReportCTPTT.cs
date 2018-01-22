using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    public partial class ReportCTPTT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCTPTT(string ma_pt,DateTime ngay_traph)
        {
            InitializeComponent();
            this.tong_tien_phongTableAdapter.Fill(this.qlkS_DATASET1.tong_tien_phong, ma_pt, ngay_traph);
        }

    }
}
