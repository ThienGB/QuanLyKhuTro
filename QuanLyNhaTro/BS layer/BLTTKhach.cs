﻿using DevComponents.DotNetBar;
using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLTTKhach
    {
        DBMain db = null;
        string err;
        public BLTTKhach()
        {
            db = new DBMain();
        }
        public DataTable LayThongTinKhach()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KHACH_THUE", CommandType.Text);
        }

        //Dùng 
        public DataTable LayMaKT_CMND(string cmnd )
        {
            return db.ExecuteQueryDataSet("SELECT MaKT FROM KHACH_THUE where CMND='"+cmnd+"'", CommandType.Text);
        }
        //Dùng 
        public DataTable LayThongTinKhachQuaID(string id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KHACH_THUE WHERE MaKT = '" + id + "'", CommandType.Text);
        }

        public DataTable LayThongTinKhachQuaMaPhong(string maphong)
        {
            return db.ExecuteQueryDataSet("SELECT MaKT, HoTen, GioiTinh, NgaySinh,CMND, QueQuan, NgheNghiep FROM KHACH_THUE WHERE MaPhong = '" + maphong + "'", CommandType.Text);
        }

        //Dùng 
        public bool ThemKhach( string hoten, string gioitinh, DateTime ngaysinh, string cmnd, string quequan, string nghenghiep, string maphong)
        {          
            string sqlString = "exec  InsertKhachThue @MaPhong ='"+maphong+"', @HoTen = N'"+hoten+"', @GioiTinh = N'"+gioitinh+"', @NgheNghiep = N'"+nghenghiep+"', @QueQuan=N'"+quequan+"', @CMND='"+cmnd+"', @NgaySinh = '"+ngaysinh+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


       
        public bool CapNhatThongTinKhach(string id, string ho, string ten, string gioitinh, DateTime ngaysinh, string cmnd, string quequan, string nghenghiep, string ghichu, byte[] Image)
        {
            string query;
            if (Image != null)
            {
                 query = "UPDATE KHACH_THUE SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, QueQuan = @QueQuan, NgheNghiep = @NgheNghiep, GhiChu = @GhiChu, AnhNhanDien = @AnhNhanDien WHERE MaKhachTro = @MaKhachTro";
                db.comm.Parameters.AddWithValue("@AnhNhanDien", Image);
            }
            else query = "UPDATE KHACH_THUE SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, QueQuan = @QueQuan, NgheNghiep = @NgheNghiep, GhiChu = @GhiChu WHERE MaKT = @MaKhachTro";    
            db.comm.Parameters.AddWithValue("@Ho", ho);
            db.comm.Parameters.AddWithValue("@Ten", ten);
            db.comm.Parameters.AddWithValue("@GioiTinh", gioitinh);
            db.comm.Parameters.AddWithValue("@NgaySinh", ngaysinh);
            db.comm.Parameters.AddWithValue("@CMND", cmnd);
            db.comm.Parameters.AddWithValue("@QueQuan", quequan);
            db.comm.Parameters.AddWithValue("@NgheNghiep", nghenghiep);
            db.comm.Parameters.AddWithValue("@GhiChu", ghichu);
            
            db.comm.Parameters.AddWithValue("@MaKhachTro", id);
            return db.MyExecuteNonQuery(query, CommandType.Text,ref err);                
        }

        public byte[] LayAnh(string id)
        {          
            string sqlString  = "SELECT TOP 1 AnhNhanDien FROM KHACH_THUE WHERE MaKT = N'" + id+"'";
            var dataTable= db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0]["AnhNhanDien"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])dataTable.Rows[0]["AnhNhanDien"];
                    return imageBytes;
                }
                else 
                    return null;
            }
            else
            {
                return null;
            }
        }

        //Dùng 
        public DataTable LayThongTinKhach_ThongTinThue(string maphong)
        {
            string sqlString = "SELECT TTP.MaKT, TK.HoTen " +
                               "FROM HOP_DONG TTP " +
                               "JOIN KHACH_THUE TK ON TTP.MaKT = TK.MaKT " +
                               "WHERE TTP.MaPhong = '"+maphong+"'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool TraPhong(string maPhong)
        {
            string sqlString = "DELETE FROM KHACH_THUE WHERE MaPhong = '" + maPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataTable ThongTinPhongMinh(string MaPhong)
        {
            string sqlString = "SELECT * FROM HienThiPhong_TheoPhong("+MaPhong+");";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
