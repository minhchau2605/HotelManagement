using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class KhachHang
    {
        private string ma_kh;
        private string ten_kh;
        private string dia_chi_kh;
        private int dienthoai_kh;
        private string gioi_tinh;
        private string quoc_tich;
        private int so_cmnd;
        private string so_hc;

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

        public string Ten_kh
        {
            get
            {
                return ten_kh;
            }

            set
            {
                ten_kh = value;
            }
        }

        public string Dia_chi_kh
        {
            get
            {
                return dia_chi_kh;
            }

            set
            {
                dia_chi_kh = value;
            }
        }

        public int Dienthoai_kh
        {
            get
            {
                return dienthoai_kh;
            }

            set
            {
                dienthoai_kh = value;
            }
        }

        public string Gioi_tinh
        {
            get
            {
                return gioi_tinh;
            }

            set
            {
                gioi_tinh = value;
            }
        }

        public string Quoc_tich
        {
            get
            {
                return quoc_tich;
            }

            set
            {
                quoc_tich = value;
            }
        }

        public int So_cmnd
        {
            get
            {
                return so_cmnd;
            }

            set
            {
                so_cmnd = value;
            }
        }

        public string So_hc
        {
            get
            {
                return so_hc;
            }

            set
            {
                so_hc = value;
            }
        }
    }
}
