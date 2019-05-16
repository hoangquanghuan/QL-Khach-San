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
    public class BUS_DatPhong
    {
        DAO_DatPhong dao_datphong = new DAO_DatPhong();


        public DataTable getDatPhong()
        {
            return dao_datphong.getDatPhong();
        }

        public bool themDatPhong(DTO_DatPhong dp)
        {
            return dao_datphong.themDatPhong(dp);
        }
        public bool suaDatPhong(DTO_DatPhong dp)
        {
            return dao_datphong.suaDatPhong(dp);
        }
        public bool xoaDatPhong(DTO_DatPhong dp)
        {
            return dao_datphong.xoaDatPhong(dp);
        }
    }
}
