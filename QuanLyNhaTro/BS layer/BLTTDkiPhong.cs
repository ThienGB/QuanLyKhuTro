﻿using QuanLyNhaTro;
using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLTTDkiPhong
    {
        string err;
        DBMain db = null;
        public BLTTDkiPhong()
        {
            db = new DBMain();
        }

        public DataTable LayThongTinDangKy()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinDangKyPhong", CommandType.Text);
        }

        public bool ThemThongTinDangKy(int id, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string CMND, string QueQuan, string NgheNghiep, string MaKhuVuc, string MaLoaiPhong)
        {
            string sqlString = "INSERT INTO ThongTinDangKyPhong (Id, Ho, Ten, GioiTinh, NgaySinh, CMND, QueQuan, NgheNghiep, MaKhuVuc, MaLoaiPhong) " +
                    "VALUES (@Id, @Ho, @Ten, @GioiTinh, @NgaySinh, @CMND, @QueQuan, @NgheNghiep, @MaKhuVuc, @MaLoaiPhong)";
            db.comm.Parameters.AddWithValue("@Id", id);
            db.comm.Parameters.AddWithValue("@Ho", Ho);
            db.comm.Parameters.AddWithValue("@Ten", Ten);
            db.comm.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            db.comm.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            db.comm.Parameters.AddWithValue("@CMND", CMND);
            db.comm.Parameters.AddWithValue("@QueQuan", QueQuan);
            db.comm.Parameters.AddWithValue("@NgheNghiep", NgheNghiep);
            db.comm.Parameters.AddWithValue("@MaKhuVuc", MaKhuVuc);
            db.comm.Parameters.AddWithValue("@MaLoaiPhong", MaLoaiPhong);
            db.comm.CommandText = sqlString;
            return db.MyExecuteNonQuery(db.comm.CommandText, CommandType.Text, ref err);
        }

        //Dùng 
        public DataTable LayTenLoaiPhong(string MaPhong)
        {
            return db.ExecuteQueryDataSet("SELECT TenPhong From PHONG_TRO WHERE MaPhong = '" + MaPhong + "'", CommandType.Text);
        }

        //Dùng 
        public bool updateTrangThaiDangKy(string madon)
        {
            string sql = "exec UpdateTrangThaiDangKy @MaDon= '" + madon + "' ";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
        //Dùng 
        public DataTable LayThongTinQuaMaKhuVuc(string kv)
        {
            string sql = "SELECT THONG_TIN_DANG_KY.* " +
                        "FROM KHU_TRO " +
                        "JOIN PHONG_TRO ON KHU_TRO.MaKhuTro = PHONG_TRO.MaKhuTro " +
                        "JOIN THONG_TIN_DANG_KY ON PHONG_TRO.MaPhong = THONG_TIN_DANG_KY.MaPhongDK " +
                        "WHERE KHU_TRO.MaKhuTro = '" + kv + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //Dùng 
        public DataTable LayThongTinQuaID(int id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM THONG_TIN_DANG_KY WHERE MaDon = '" + id + "'", CommandType.Text);
        }
        public bool ThemThongTinDangKy(string maphong, string Ho, string Ten, string GioiTinh, DateTime NgaySinh, string CMND, string QueQuan, string NgheNghiep)
        {
            string sqlString = "exec insertThongTinDangKy @MaPhongDK = '" + maphong + "',@HoTen =N'" + Ho + " " + Ten + "'," +
                "@GioiTinh=N'" + GioiTinh + "' ,@NgaySinh='" + NgaySinh + "' ,@CMND='" + CMND + "' ," +
                "@QueQuan = N'" + QueQuan + "',@NgheNghiep='" + NgheNghiep + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}

