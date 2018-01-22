using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class NhanVien
    {
        private string ma_nv;
        private string ten_nv;
        private DateTime ngay_sinh;
        private string gioi_tinh;
        private int so_cmnd;
        private string dia_chi;
        private int dienthoai_nv;
        private string chuc_vu;

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

        public string Ten_nv
        {
            get
            {
                return ten_nv;
            }

            set
            {
                ten_nv = value;
            }
        }

        public DateTime Ngay_sinh
        {
            get
            {
                return ngay_sinh;
            }

            set
            {
                ngay_sinh = value;
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

        public string Dia_chi
        {
            get
            {
                return dia_chi;
            }

            set
            {
                dia_chi = value;
            }
        }

        public int Dienthoai_nv
        {
            get
            {
                return dienthoai_nv;
            }

            set
            {
                dienthoai_nv = value;
            }
        }

        public string Chuc_vu
        {
            get
            {
                return chuc_vu;
            }

            set
            {
                chuc_vu = value;
            }
        }
    }
}
