using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HoaDonTT
    {
        private string ma_hddt;
        private string ma_pt;
        private string ma_nv;
        private DateTime ngay_lap;
        private int tong_tien_dv;
        private int tong_tien_pt;
        private string ghi_chu;

        public string Ma_hddt
        {
            get
            {
                return ma_hddt;
            }

            set
            {
                ma_hddt = value;
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

        public string Ma_nv
        {
            get
            {
                return ma_nv;
            }

            set
            {
                ma_nv = value;
            }
        }

        public DateTime Ngay_lap
        {
            get
            {
                return ngay_lap;
            }

            set
            {
                ngay_lap = value;
            }
        }

        public int Tong_tien_dv
        {
            get
            {
                return tong_tien_dv;
            }

            set
            {
                tong_tien_dv = value;
            }
        }

        public int Tong_tien_pt
        {
            get
            {
                return tong_tien_pt;
            }

            set
            {
                tong_tien_pt = value;
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
