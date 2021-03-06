﻿using System;
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
            string kn = @"SELECT MA_NV as'Mã NV',HT_NV as'Họ Tên',GT as'Giới Tính',NS as'Ngày Sinh',DC as'Địa Chỉ',SDT as'SĐT'
                           FROM dbo.NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(kn, conn);
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
                throw ex;
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
                throw ex;
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
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable TimKiemNV(DTO_nhanvien nv)
        {
            conn.Open();
            string SQL = string.Format(
                "SELECT  MA_NV as'Mã NV',HT_NV as'Họ Tên',GT as'Giới Tính',NS as'Ngày Sinh',DC as'Địa Chỉ',SDT as'SĐT' FROM dbo.NHANVIEN WHERE HT_NV LIKE N'%{0}%'", nv.HOTEN_NV);
            //SqlCommand cmd = new SqlCommand(SQL, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
