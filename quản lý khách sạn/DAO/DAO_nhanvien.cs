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
    public class DAO_nhanvien:DBconnect
    {
        public DataTable getNhanvien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.NHANVIEN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            conn.Close();
            return dt;
        }

        public bool themNhanvien(DTO_nhanvien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT INTO dbo.NHANVIEN ( MA_NV, HT_NV, GT,NS,DC,SDT ) VALUES  ('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                    ,nv.MA_NV,nv.HOTEN_NV,nv.GT,nv.NS,nv.DC,nv.SDT);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
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

        public bool suaNhanvien(DTO_nhanvien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "UPDATE dbo.NHANVIEN SET HT_NV=N'{0}',GT=N'{1}',NS='{2}',DC=N'{3}',SDT='{4}' where MA_NV='{5}'",
                    nv.HOTEN_NV,nv.GT,nv.NS,nv.DC,nv.SDT,nv.MA_NV);
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


        public bool xoaNhanvien(DTO_nhanvien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.NHANVIEN WHERE MA_NV='{0}'", nv.MA_NV);
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

        public bool TimKiemNV(DTO_nhanvien nv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "SELECT * FROM dbo.NHANVIEN WHERE HT_NV LIKE N'%{0}'",nv.TK);
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
