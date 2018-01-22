using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HoaDonDV
    {
        private string ma_hddv;
        private string ma_pt;
        private DateTime ngay_lap_hddv;
        private string ghi_chu;

        public string Ma_hddv
        {
            get
            {
                return ma_hddv;
            }

            set
            {
                ma_hddv = value;
            }
        }

        public string Ma_pt
        {
            get
            {
                return ma_pt;
            }

            set
            {
                ma_pt = value;
            }
        }

        public DateTime Ngay_lap_hddv
        {
            get
            {
                return ngay_lap_hddv;
            }

            set
            {
                ngay_lap_hddv = value;
            }
        }

        public string Ghi_chu
        {
            get
            {
                return ghi_chu;
            }

            set
            {
                ghi_chu = value;
            }
        }
    }
}
