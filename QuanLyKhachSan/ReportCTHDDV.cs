using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    public partial class ReportCTHDDV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCTHDDV(string ma_hddv)
        {
            InitializeComponent();
            this.cthddv_mahddvTableAdapter.Fill(qlkS_DATASET1.cthddv_mahddv, ma_hddv);
            //this.xrLabel_mahddv.Text = ma_hddv;
        }

    }
}
