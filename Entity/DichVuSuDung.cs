using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DichVuSuDung
    {
        private string ma_hddv;
        private string ma_dv;
        private int soluong_dv;
        private DateTime ngay_sd;

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

        public string Ma_dv
        {
            get
            {
                return ma_dv;
            }

            set
            {
                ma_dv = value;
            }
        }

        public int Soluong_dv
        {
            get
            {
                return soluong_dv;
            }

            set
            {
                soluong_dv = value;
            }
        }

        public DateTime Ngay_sd
        {
            get
            {
                return ngay_sd;
            }

            set
            {
                ngay_sd = value;
            }
        }
    }
}
