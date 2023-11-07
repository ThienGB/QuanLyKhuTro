using QuanLyNhaTro;
using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.BS_layer
{
     class BLPhong
    {
        DBMain db = null;
        string err;

        public BLPhong()
        {
            db = new DBMain();
        }
        public DataTable LayPhongTro()
        {
            return db.ExecuteQueryDataSet("select * from ViewPhongTro", CommandType.Text);
        }

        public DataTable Layphong_TT_MaKV(string trangthai,string makt)
        {
            string sql = "SELECT MaPhong, TenPhong " +
                 "FROM LocPhongTheoTT_KV " +
                 "(N'"+trangthai +"', '"+makt+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

        public bool ThemPhongTro(string makhutro, string tenphong,string maloaiphong)
        {
            string sqlString = "Exec InsertPhongTro " 
                + "  @MaKhuTro ='" + makhutro
                + "',@TenPhong = N'" + tenphong 
                + "',@MaLoaiPhong'" + maloaiphong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);           
        }
        public bool CapNhatPhongTro(string maphong, string makhutro, string trangthai, string tenphong, string maloaiphong)
        {
            
            string sqlString = "Exec UpdatePhongTro "
                + "  @MaPhong ='" + maphong
                + "',@MaKhuTro = N'" + makhutro
                + "',@TrangThai = N'" + trangthai
                + "',@TenPhong = N'" + tenphong
                + "',@MaLoaiPhong'" + maloaiphong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhongTro(string maphong)
        {
            string sqlString = "Exec DeletePhongTro "
                + " @MaPhong ='" + maphong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable LayPhongDaThue_MaKV_LP(string makv, string loaiphong)
        {
            string sql = "Select * from Phong " +
                "where MaKhuVuc = N'" + makv + "' and TrangThai = N'Đã thuê' and  MaLoaiPhong =N'"+loaiphong+"'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

        public DataTable LayPhongDaThue_MaKV_TenP(string makv, string tenphong)
        {
            string sql = "Select * from Phong "+
                "where MaKhuVuc = N'" + makv + "' and TrangThai = N'Đã thuê' and  TenPhong =N'" + tenphong + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }

        public DataTable LayPhongDaThue_MaKV(string makv)
        {

            string sql = "select Maphong,TenPhong,MaLoaiPhong,Day from Phong " +
                "where MaKhuVuc = N'" + makv + "' and TrangThai = N'Đã thuê'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }
        public string LayMaPhongBangMaKT(string MaKT)
        {
            string sql = "select Maphong From LayPhongBangMaKT ('" + MaKT + "')";
            var table = db.ExecuteQueryDataSet(sql, CommandType.Text);
            int row = table.Rows.Count;
            if (row != 0)
            {
                return table.Rows[0][0].ToString();
            }
            return null;

        }
        public DataTable ViewChuaTaoPhieuThu()
        {
            string sql = "select * from ViewChuaTaoPhieuThu";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        //Dùng 
        public DataTable LayPhongChuaLapHD(string makv, int thismonth, int thisyear)
        {
            string sql = "select * from GetPhongChuaThu( '" + makv + "' , '" + thismonth + "' , '" + thisyear + "' ) ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        //Dùng 
        public DataTable LayMaPhong(string tenphong, string Makv)
        {
            string sql = "select * from LayMaPhong_TenP_MaKtro('" + tenphong + "' , '" + Makv + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        //Dùng
        public DataTable LayP_dathue_TTThue(string maphong) 
        {
            string sql = "select * from LayThongTinPhong_Ngaythue('" + maphong + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        //Dùng 
        public bool UpdateTrangThai(string maphong, string trangthai)
        {
            string sqlString = "exec UpdateTTPhongTro @MaPhong='" + maphong + "',@TrangThai =N'" + trangthai + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        //Dùng 
        public DataTable LayLoaiPhong()
        {
            string sql = "Select * from ViewThongTinLoaiPhong ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        //Dùng 
        public DataTable LayPhongtrong(string makv, string loaiphong)
        {
            string sql = "select * from LayPhongTrongMaKV_LP( '" + makv + "','" + loaiphong + "' )";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        //Dùng 
        public DataTable LayPhongtrong_MaKV_TenP(string makv, string tenphong)
        {
            string sql = "SELECT * from LayPhongTrongTheoTenP_MaKTro( '" + makv + "', '" + tenphong + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //Dùng 
        public DataTable LayPhong_MaP(string maphong)
        {
            string sql = "select * from LayPhongTrong_MaP('" + maphong + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        public DataTable LayPhong_MaP1(string maphong)
        {
            string sql = "SELECT TenPhong, TenLoaiPhong, DienTich, GiaThue, DiaChi " +
                         "FROM LayThongTinPhong" +
                         "('" + maphong + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        public DataTable LayPhongtrong(string makv)
        {
            string sql = "SELECT * from LocPhongTheoKhuTro('" + makv + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        public DataTable LayPhongtrong_gia(string dongia)
        {
            string sql = "select * from  LocPhongTheoGia(" + dongia + ")";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        public DataTable LayPhongtrong_dientich(string dientich)
        {
            string sql = "select * from  LocPhongTheoGia(" + dientich + ")";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}

