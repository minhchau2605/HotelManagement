using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class LoaiPhong
    {
        private string loai_phong;
        private int don_gia;
        private int dien_tich;
        private string kieu_phong;

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

        public int Dien_tich
        {
            get
            {
                return dien_tich;
            }

            set
            {
                dien_tich = value;
            }
        }

        public string Kieu_phong
        {
            get
            {
                return kieu_phong;
            }

            set
            {
                kieu_phong = value;
            }
        }
    }
}
