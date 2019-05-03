using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_hoadon:DBconnect
    {
        public DataTable getHoadon()
        {
            string kn = @"SELECT * FROM dbo.HOADON";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(kn,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool themHoaDon(DTO_hoadon hd)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT dbo.HOADON(MA_HD,MA_NV, MA_KH,NGAY_THANH_TOAN,HINHTHUC,TONGTIEN,MAPHONG, MA_DV) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}' )"
                    ,hd.MA_HD,hd.MA_NV,hd.MA_KH,hd.NGAY_THANH_TOAN,hd.HINHTHUC,hd.TONGTIEN,hd.MAPHONG,hd.MA_DV);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
