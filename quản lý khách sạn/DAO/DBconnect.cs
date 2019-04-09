using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DBconnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BS6O692\SQLEXPRESS;Initial Catalog=QuanLyKhachSan9;Persist Security Info=True;User ID=sa;Password=haidong..");
    }
}
