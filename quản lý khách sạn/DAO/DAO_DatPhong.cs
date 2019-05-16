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
    public class DAO_DatPhong : DBconnect
    {
        public DataTable getDatPhong()
        {
            conn.Open();
            string kn = @"SELECT * FROM dbo.PHIEUDATPHONG";
            SqlDataAdapter da = new SqlDataAdapter(kn, conn);
            DataTable dt = new DataTable();
            // DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool themDatPhong(DTO_DatPhong dp)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT INTO dbo.PHIEUDATPHONG(MAPHIEUDAT,MAPHONG,MA_KH,NGAYDAT,SONGUOI) VALUES  ('{0}',N'{1}',N'{2}',N'{3}',N'{4}')"
                    , dp.MAPHIEUDAT,dp.MAPHONG,dp.MA_KH,dp.NGAYDAT,dp.SONGUOI);
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

        public bool suaDatPhong(DTO_DatPhong dp)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "UPDATE dbo.PHIEUDATPHONG SET MAPHONG = '{0}', MA_KH = '{1}', NGAYDAT = '{2}', SONGUOI = '{3}' WHERE MAPHIEUDAT = '{4}'",
                   dp.MAPHONG,dp.MA_KH,dp.NGAYDAT,dp.SONGUOI,dp.MAPHIEUDAT);
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

        public bool xoaDatPhong(DTO_DatPhong dp)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.PHIEUDATPHONG WHERE MAPHIEUDAT ='{0}'", dp.MAPHIEUDAT);
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
