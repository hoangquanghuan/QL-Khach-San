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
            string kn = @"
             SELECT MA_HD as 'Mã HĐ',hd.MA_NV as'Mã NV',nv.HT_NV as'Họ Tên NV',hd.MA_KH as'Mã KH',kh.HT_KH as'Họ Tên KH',NGAY_THANH_TOAN as'Ngày TT',HINHTHUC as'Hình Thức',TONGTIEN as'Tổng Tiền',MAPHONG as'Mã P',MA_DV as'Mã DV'
             FROM dbo.HOADON hd,dbo.KHACHHANG kh,dbo.NHANVIEN nv
             WHERE hd.MA_NV=nv.MA_NV AND hd.MA_KH=kh.MA_KH";
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
                    "INSERT dbo.HOADON(MA_HD,MA_NV, MA_KH,NGAY_THANH_TOAN,HINHTHUC,MAPHONG, MA_DV) VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}' )"
                    ,hd.MA_HD,hd.MA_NV,hd.MA_KH,hd.NGAY_THANH_TOAN,hd.HINHTHUC,hd.MAPHONG,hd.MA_DV);
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

        public bool suaHoaDon(DTO_hoadon hd)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "UPDATE dbo.HOADON SET MA_NV = N'{0}', MA_KH = N'{1}', NGAY_THANH_TOAN = N'{2}', HINHTHUC = N'{3}', TONGTIEN = N'{4}', MAPHONG = N'{5}', MA_DV = N'{6}' WHERE MA_HD = N'{7}'",
                    hd.MA_NV,hd.MA_KH,hd.NGAY_THANH_TOAN,hd.HINHTHUC,hd.TONGTIEN,hd.MAPHONG,hd.MA_DV,hd.MA_HD);
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

        public bool xoaHoaDon(DTO_hoadon hd)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.HOADON WHERE MA_HD='{0}'", hd.MA_HD);
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
