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
            string kn = @"SELECT MAPHONG as'Mã Phòng', TENPHONG as'Tên Phòng', TEN_LP as'Loại Phòng', TEN_TT as'Trạng Thái', GIA as'Giá' FROM dbo.PHONG, dbo.LOAIPHONG, dbo.TRANGTHAI WHERE dbo.PHONG.MA_LP = dbo.LOAIPHONG.MA_LP AND dbo.PHONG.MA_TT = dbo.TRANGTHAI.MA_TT";
            SqlDataAdapter da = new SqlDataAdapter(kn, conn);
            DataTable dt = new DataTable();
           // DataSet ds = new DataSet();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool themPhong(DTO_Phong p)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT INTO dbo.PHONG ( MAPHONG, TENPHONG, MA_LP, MA_TT ) VALUES  ('{0}',N'{1}',N'{2}',N'{3}')"
                    , p.MA_PHONG, p.TEN_PHONG, p.MA_LP, p.MA_TT);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;
                
            }
            catch(Exception ex)
            {
                throw ex;
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
                string SQL = string.Format(
                    "UPDATE dbo.PHONG SET TENPHONG='{0}',MA_LP='{1}',MA_TT='{2}' where MAPHONG='{3}'",
                    p.TEN_PHONG,p.MA_LP,p.MA_TT, p.MA_PHONG);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = cmd.ExecuteNonQuery();
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

        public bool xoaPhong(DTO_Phong p)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.PHONG WHERE MAPHONG='{0}'",p.MA_PHONG);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = cmd.ExecuteNonQuery();
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
