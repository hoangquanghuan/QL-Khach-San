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
    public class BUS_hoadon
    {
        DAO_hoadon dao_hoadon = new DAO_hoadon();

        public DataTable getHoadon()
        {
            return dao_hoadon.getHoadon();
        }

        public bool themHoadon(DTO_hoadon hd)
        {
            return dao_hoadon.themHoaDon(hd);
        }

        public bool suaHoaDon(DTO_hoadon hd)
        {
            return dao_hoadon.suaHoaDon(hd);
        }

        public bool xoaHoaDon(DTO_hoadon hd)
        {
            return dao_hoadon.xoaHoaDon(hd);
        }


    }
}
