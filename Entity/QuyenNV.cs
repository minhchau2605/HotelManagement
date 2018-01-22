using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class QuyenNV
    {
        private string ma_nv;
        private string ma_quyen;
        private string mat_khau;

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

        public string Ma_quyen
        {
            get
            {
                return ma_quyen;
            }

            set
            {
                ma_quyen = value;
            }
        }

        public string Mat_khau
        {
            get
            {
                return mat_khau;
            }

            set
            {
                mat_khau = value;
            }
        }
    }
}
