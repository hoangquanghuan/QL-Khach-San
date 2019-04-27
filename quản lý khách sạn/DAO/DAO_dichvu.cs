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
    public class DAO_dichvu: DBconnect
    {
        public DataTable getDichvu()
        {
            string kn = @"SELECT * FROM dbo.DICHVU";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(kn, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool themDichvu(DTO_dichvu dv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT INTO dbo.DICHVU VALUES  ('{0}',N'{1}',N'{2}')"
                    ,dv.MA_DV,dv.TEN_DV,dv.GIA);
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

        public bool suaDichvu(DTO_dichvu dv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "UPDATE dbo.DICHVU SET TEN_DV='{0}',GIA='{1}' where MA_DV='{2}'",
                    dv.TEN_DV,dv.GIA,dv.MA_DV);
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

        public bool xoaDichvu(DTO_dichvu dv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.DICHVU WHERE MA_DV='{0}'", dv.MA_DV);
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
