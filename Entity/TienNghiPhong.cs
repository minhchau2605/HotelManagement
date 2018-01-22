using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class TienNghiPhong
    {
        private string loai_phong;
        private string ma_tn;
        private int so_luong_tn;

        public string Loai_phong
        {
            get
            {
                return loai_phong;
            }

            set
            {
                loai_phong = value;
            }
        }

        public string Ma_tn
        {
            get
            {
                return ma_tn;
            }

            set
            {
                ma_tn = value;
            }
        }

        public int So_luong_tn
        {
            get
            {
                return so_luong_tn;
            }

            set
            {
                so_luong_tn = value;
            }
        }
    }
}
