using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_dichvu
    {
        // khai báo các thuộc tính
        private string _MA_DV;
        private string _TEN_DV;
        private string _GIA;

        public DTO_dichvu()
        {

        }

        public DTO_dichvu(string MA_DV,string TEN_DV, string GIA)
        {
            this._MA_DV = MA_DV;
            this._TEN_DV = TEN_DV;
            this._GIA = GIA;
        }

        public string MA_DV
        {
            get
            {
                return _MA_DV;
            }
            set
            {
                _MA_DV = value;
            }
        }
        public string TEN_DV
        {
            get
            {
                return _TEN_DV;
            }
            set
            {
                _TEN_DV = value;
            }
        }

        public string GIA
        {
            get
            {
                return _GIA;
            }
            set
            {
                _GIA = value;
            }
        }
    }
}
