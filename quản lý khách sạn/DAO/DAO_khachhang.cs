﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_khachhang:DBconnect
    {
        public DataTable getKhachhang()
        {
            conn.Open();
            string kn = @"SELECT MA_KH as'Mã Khách',HT_KH as'Họ Tên',NS as'Ngày Sinh',GT as'Giới Tính',CMND as'Số CMND',SDT as'SĐT'
                            FROM dbo.KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(kn,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();
            return dt;
        }

        public bool themKhachhang(DTO_khachhang kh)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "INSERT INTO dbo.KHACHHANG (MA_KH, HT_KH, NS, GT, CMND, SDT) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                    ,kh.MA_KH,kh.HT_KH,kh.NS,kh.GT,kh.CMND,kh.SDT);
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

        public bool suaKhachhang(DTO_khachhang kh)
        {
            try
            {
                conn.Open();
                string SQL = string.Format(
                    "UPDATE dbo.KHACHHANG SET HT_KH=N'{0}',NS=N'{1}',GT='{2}',CMND=N'{3}',SDT='{4}' where MA_KH='{5}'",
                    kh.HT_KH,kh.NS,kh.GT,kh.CMND,kh.SDT,kh.MA_KH);
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

        public bool xoaKhachhang(DTO_khachhang kh)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE dbo.KHACHHANG WHERE MA_KH='{0}'", kh.MA_KH);
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

        public DataTable TimKiemKH(DTO_khachhang kh)
        {
            conn.Open();
            string SQL = string.Format(
                "SELECT MA_KH as'Mã Khách',HT_KH as'Họ Tên',NS as'Ngày Sinh',GT as'Giới Tính',CMND as'Số CMND',SDT as'SĐT' FROM dbo.KHACHHANG WHERE HT_KH LIKE N'%{0}%'", kh.HT_KH);
            //SqlCommand cmd = new SqlCommand(SQL, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


    }
}
