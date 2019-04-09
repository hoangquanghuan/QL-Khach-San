using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phong
    {
        private string _MA_PHONG;
        private string _TEN_PHONG;
        private string _MA_LP;
        private string _MA_TT;

        public string MA_PHONG
        {
            get
            {
                return _MA_PHONG;
            }
            set
            {
                _MA_PHONG = value;
            }
        }
        public string TEN_PHONG
        {
            get
            {
                return _TEN_PHONG;
            }
            set
            {
                _TEN_PHONG = value;
            }
        }
        public string MA_LP
        {
            get
            {
                return _MA_LP;
            }
            set
            {
                _MA_LP = value;
            }
        }
        public string MA_TT
        {
            get
            {
                return _MA_TT;
            }
            set
            {
                _MA_TT = value;
            }
        }

        public DTO_Phong()
        {

        }
        public DTO_Phong(string MA_PHONG,string TEN_PHONG,string MA_LP,string MA_TT)
        {
            this._MA_PHONG = MA_PHONG;
            this._TEN_PHONG = TEN_PHONG;
            this._MA_LP = MA_LP;
            this._MA_TT = MA_TT;
        }

    }
}
