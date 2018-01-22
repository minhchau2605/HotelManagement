using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PhongTT
    {
        private string ma_pt;
        private string ma_phong;
        private DateTime ngay_tra;
        private int thanh_tien;

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

        public string Ma_phong
        {
            get
            {
                return ma_phong;
            }

            set
            {
                ma_phong = value;
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

        public int Thanh_tien
        {
            get
            {
                return thanh_tien;
            }

            set
            {
                thanh_tien = value;
            }
        }
    }
}
