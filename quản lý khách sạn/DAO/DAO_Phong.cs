using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DAO_Phong:DBconnect
    {
        public DataTable getPhong()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.PHONG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool themPhong(DTO_Phong p)
        {
            try
            {
                conn.Open();
                string SQL = @"INSERT INTO dbo.PHONG ( MAPHONG, TENPHONG, MA_LP, MA_TT ) VALUES  ('"+p.MA_PHONG+ "','" + p.TEN_PHONG + ",'" + p.MA_LP + ",'" + p.MA_TT + ")";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;
                
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool suaPhong(DTO_Phong p)
        {
            try
            {
                conn.Open();
                string SQL = @"UPDATE dbo.PHONG SET MAPHONG='"+p.MA_PHONG+"',TENPHONG='"+p.TEN_PHONG+"',MA_LP='"+p.MA_LP+"',MA_TT='"+p.MA_TT+"'";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaPhong(string maphong)
        {
            try
            {
                conn.Open();
                string SQL = @"DELETE dbo.PHONG WHERE MAPHONG='"+maphong+"'";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
