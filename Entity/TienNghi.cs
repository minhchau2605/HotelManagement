using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class TienNghi
    {
        private string ma_tn;
        private string ten_tn;

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

        public string Ten_tn
        {
            get
            {
                return ten_tn;
            }

            set
            {
                ten_tn = value;
            }
        }
    }
}
