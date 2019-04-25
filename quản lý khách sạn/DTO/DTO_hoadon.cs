using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_hoadon
    {
        // khai báo các thuộc tính
        private string _MA_HD;
        private string _MA_NV;
        private string _MA_KH;
        private string _NGAY_THANH_TOAN;
        private string _HINHTHUC;
        private string _TONGTIEN;
        private string _MAPHONG;
        private string _MA_DV;


        // các phương thức

        public DTO_hoadon()
        {

        }

        public DTO_hoadon(string MA_HD,string MA_NV,string MA_KH,string NGAY_THANH_TOAN,string HINHTHUC, string TONGTIEN,string MAPHONG,string MA_DV)
        {
            this._MA_HD = MA_HD;
            this._MA_NV = MA_NV;
            this._MA_KH = MA_KH;
            this._NGAY_THANH_TOAN = NGAY_THANH_TOAN;
            this._HINHTHUC = HINHTHUC;
            this._TONGTIEN = TONGTIEN;
            this._MAPHONG = MAPHONG;
            this._MA_DV = MA_DV;
        }

        public string MA_HD
        {
            get
            {
                return _MA_HD;
            }
            set
            {
                _MA_HD = value;
            }
        }

        public string MA_NV
        {
            get
            {
                return _MA_NV;
            }
            set
            {
                _MA_NV = value;
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

        public string NGAY_THANH_TOAN
        {
            get
            {
                return _NGAY_THANH_TOAN;
            }
            set
            {
                _NGAY_THANH_TOAN = value;
            }
        }

        public string HINHTHUC
        {
            get
            {
                return _HINHTHUC;
            }
            set
            {
                _HINHTHUC = value;
            }
        }

        public string TONGTIEN
        {
            get
            {
                return _TONGTIEN;
            }
            set
            {
                _TONGTIEN = value;
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


    }
}
