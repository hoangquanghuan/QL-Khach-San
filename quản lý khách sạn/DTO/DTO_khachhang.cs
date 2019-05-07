using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_khachhang
    {
        // khai báo các thuộc tính
        private string _MA_KH;
        private string _HT_KH;
        private string _NS;
        private string _GT;
        private string _CMND;
        private string _SDT;

        // các phương thức
        public DTO_khachhang()
        { }

        public DTO_khachhang(string MA_KH,string HT_KH,string NS,string GT,string CMND, string SDT)
        {
            this._MA_KH = MA_KH;
            this._HT_KH = HT_KH;
            this._NS = NS;
            this._GT = GT;
            this._CMND = CMND;
            this._SDT = SDT;
        }
        public string MA_KH
        {
            get
            {
                return _MA_KH;
            }
            set
            {
                _MA_KH = value;
            }
        }
        public string HT_KH
        {
            get
            {
                return _HT_KH;
            }
            set
            {
                _HT_KH = value;
            }
        }
        public string NS
        {
            get
            {
                return _NS;
            }
            set
            {
                _NS = value;
            }
        }
        public  string GT
        {
            get
            {
                return _GT;
            }
            set
            {
                _GT = value;
            }
        }
        public string CMND
        {
            get
            {
                return _CMND;
            }
            set
            {
                _CMND = value;
            }
        }
        public string SDT
        {
            get
            {
                return _SDT;
            }
            set
            {
                _SDT = value;
            }
        }
    }
}
