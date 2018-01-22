using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    public partial class SubRP_CTHDDV : DevExpress.XtraReports.UI.XtraReport
    {
        //BusinessLogic.Logic bl = new BusinessLogic.Logic();
        public SubRP_CTHDDV()
        {
            //string ma_hddv = bl. 
            InitializeComponent();
            this.cthddv_mahddvTableAdapter.Fill(qlkS_DATASET1.cthddv_mahddv, "hddv1");
        }

    }
}
