using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PhanQuyen
    {
        private string ma_quyen;
        private string quyen;

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

        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }
    }
}
