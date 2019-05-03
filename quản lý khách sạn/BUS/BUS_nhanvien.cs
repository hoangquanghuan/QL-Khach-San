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
    public class BUS_nhanvien
    {
        DAO_nhanvien dao_nhanvien = new DAO_nhanvien();

        public DataTable getNhanvien()
        {
            return dao_nhanvien.getNhanvien();
        }

        public bool themNhanvien(DTO_nhanvien nv)
        {
            return dao_nhanvien.themNhanvien(nv);
        }

        public bool suaNhanvien(DTO_nhanvien nv)
        {
            return dao_nhanvien.suaNhanvien(nv);
        }

        public bool xoaNhanvien(DTO_nhanvien nv)
        {
            return dao_nhanvien.xoaNhanvien(nv);
        }

        public bool TimKiemNV(DTO_nhanvien nv)
        {
            return dao_nhanvien.TimKiemNV(nv);
        }
    }
}
