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
    public class BUS_dichvu
    {
        // tạo một đối tượng dichvu
        DAO_dichvu dichvu = new DAO_dichvu();

        public DataTable getDichvu()
        {
            return dichvu.getDichvu();
        }

        public bool themDichvu(DTO_dichvu dv)
        {
            return dichvu.themDichvu(dv);
        }
        public bool suaDichvu(DTO_dichvu dv)
        {
            return dichvu.suaDichvu(dv);
        }
        public bool xoaDichvu(DTO_dichvu dv)
        {
            return dichvu.xoaDichvu(dv);
        }

    }
}
