using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DatPhong
    {
        private string _MAPHIEUDAT;
        private string _MAPHONG;
        private string _MA_KH;
        private string _NGAYDAT;
        private string _SONGUOI;

        public DTO_DatPhong()
        {

        }

        public DTO_DatPhong(string MAPHIEUDAT,string MAPHONG, string MA_KH, string NGAYDAT,string SONGUOI)
        {
            this._MAPHIEUDAT = MAPHIEUDAT;
            this._MAPHONG = MAPHONG;
            this._MA_KH = MA_KH;
            this._NGAYDAT = NGAYDAT;
            this._SONGUOI = SONGUOI;
        }

        public string MAPHIEUDAT
        {
            get
            {
                return _MAPHIEUDAT;
            }
            set
            {
                _MAPHIEUDAT = value;
            }
        }

        public string MAPHONG
        {
            get
            {
                return _MAPHONG;
            }
            set
            {
                _MAPHONG = value;
            }
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

        public string NGAYDAT
        {
            get
            {
                return _NGAYDAT;
            }
            set
            {
                _NGAYDAT = value;
            }
        }

        public string SONGUOI
        {
            get
            {
                return _SONGUOI;
            }
            set
            {
                _SONGUOI = value;
            }
        }


    }
}
