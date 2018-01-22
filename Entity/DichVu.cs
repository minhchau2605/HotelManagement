using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DichVu
    {
        private string ma_dv;
        private string ten_dv;
        private int don_gia;
        private string dv_tinh;

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

        public string Ten_dv
        {
            get
            {
                return ten_dv;
            }

            set
            {
                ten_dv = value;
            }
        }

        public int Don_gia
        {
            get
            {
                return don_gia;
            }

            set
            {
                don_gia = value;
            }
        }

        public string Dv_tinh
        {
            get
            {
                return dv_tinh;
            }

            set
            {
                dv_tinh = value;
            }
        }
    }
}
