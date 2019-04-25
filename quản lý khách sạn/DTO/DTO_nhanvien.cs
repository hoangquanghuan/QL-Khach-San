using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_nhanvien
    {
        // các thuộc tính của NHân Viên
        private string _MA_NHANVIEN;
        private string _HOTEN_NHANVIEN;
        private string _GT;
        private string _NS;
        private string _DC;
        private string _SDT;
        // các hàm khởi tạo
        public DTO_nhanvien()
        {}

        public DTO_nhanvien(string MA_NV,string HOTEN_NV,string GT,string NS,string DC,string SDT)
        {
            this._MA_NHANVIEN = MA_NV;
            this._HOTEN_NHANVIEN = HOTEN_NV;
            this._GT = GT;
            this._NS = NS;
            this._DC = DC;
            this._SDT = SDT;
        }

        public string MA_NV
        {
            get
            {
                return _MA_NHANVIEN;
            }
            set
            {
                _MA_NHANVIEN = value;
            }
        }
        public string HOTEN_NV
        {
            get
            {
                return _HOTEN_NHANVIEN;
            }
            set
            {
                _HOTEN_NHANVIEN = value;
            }
        }
        public string GT
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
        public string DC
        {
            get
            {
                return _DC;
            }
            set
            {
                _DC = value;
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
