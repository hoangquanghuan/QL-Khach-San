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
    public class BUS_Phong
    {
        DAO_Phong dao_phong = new DAO_Phong();

        public DataTable getPhong()
        {
            return dao_phong.getPhong();
        }

        public bool themPhong(DTO_Phong p)
        {
            return dao_phong.themPhong(p);
        }
        public bool suaPhong(DTO_Phong p)
        {
            return dao_phong.suaPhong(p);
        }
        public bool xoaPhong(string maphong)
        {
            return dao_phong.xoaPhong(maphong);
        }

    }
}
