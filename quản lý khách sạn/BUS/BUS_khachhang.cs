using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_khachhang
    {
        DAO_khachhang dao_khachhang = new DAO_khachhang();

        public DataTable getKhachhang()
        {
            return dao_khachhang.getKhachhang();
        }

        public bool themKhachhang(DTO_khachhang kh)
        {
            return dao_khachhang.themKhachhang(kh);
        }

        public bool suaKhachhang(DTO_khachhang kh)
        {
            return dao_khachhang.suaKhachhang(kh);
        }

        public bool xoaKhachhang(DTO_khachhang kh)
        {
            return dao_khachhang.xoaKhachhang(kh);
        }
    }
}
