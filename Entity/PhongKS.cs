using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class PhongKS
    {
        private string ma_phong;
        private string loai_phong;
        private string tinh_trang;

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

        public string Tinh_trang
        {
            get
            {
                return tinh_trang;
            }

            set
            {
                tinh_trang = value;
            }
        }
    }
}
