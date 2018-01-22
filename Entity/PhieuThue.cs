using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PhieuThue
    {
        private string ma_pt;
        private string ma_kh;
        private DateTime ngay_lap;
        private DateTime ngay_thue;
        private DateTime ngay_tra;
        private string trang_thai;
        private int dat_coc;
        private string yeu_cau;

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

        public string Ma_kh
        {
            get
            {
                return ma_kh;
            }

            set
            {
                ma_kh = value;
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

        public DateTime Ngay_thue
        {
            get
            {
                return ngay_thue;
            }

            set
            {
                ngay_thue = value;
            }
        }

        public DateTime Ngay_tra
        {
            get
            {
                return ngay_tra;
            }

            set
            {
                ngay_tra = value;
            }
        }

        public string Trang_thai
        {
            get
            {
                return trang_thai;
            }

            set
            {
                trang_thai = value;
            }
        }

        public int Dat_coc
        {
            get
            {
                return dat_coc;
            }

            set
            {
                dat_coc = value;
            }
        }

        public string Yeu_cau
        {
            get
            {
                return yeu_cau;
            }

            set
            {
                yeu_cau = value;
            }
        }
    }
}
