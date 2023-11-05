using QuanLyNhaTro;
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

        public DataTable LayThongTinQuaMaKhuVuc(string MaKv)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinDangKyPhong WHERE MaKhuVuc = '" + MaKv + "'", CommandType.Text);
        }

        public DataTable LayThongTinQuaID(int id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinDangKyPhong WHERE Id = '" + id + "'", CommandType.Text);
        }

        public bool Xoa(int id)
        {
            string sqlString = "DELETE FROM ThongTinDangKyPhong WHERE Id = '" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable LayTenLoaiPhong(string maloaiphong)
        {
            return db.ExecuteQueryDataSet("SELECT TenLoaiPhong FROM LoaiPhong WHERE MaLoaiPhong = '" + maloaiphong + "'", CommandType.Text);
        }
    }
}

