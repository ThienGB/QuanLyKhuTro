using DevComponents.DotNetBar;
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
            return db.ExecuteQueryDataSet("SELECT * FROM ViewKhachThue", CommandType.Text);
        }
        public DataTable LayThongTinKhachQuaMaPhong(string maphong)
        {
            return db.ExecuteQueryDataSet("SELECT MaKT, HoTen, GioiTinh, NgaySinh,CMND, QueQuan, NgheNghiep FROM LocKhachThueTheoMaPhong ('" + maphong + "')", CommandType.Text);
        }

        public bool ThemKhach(string maphong, string hoten, string gioitinh, string nghenghiep, string quequan, string cmnd, DateTime ngaysinh,out string err)
        {
            err = "";

            {
                string formattedDate = ngaysinh.ToString("yyyy/MM/dd");
                string sqlString = "Exec InsertKhachThue "
                    + "  @MaPhong ='" + maphong
                    + "',@HoTen = N'" + hoten
                    + "',@GioiTinh = N'" + gioitinh
                    + "',@NgheNghiep = N'" + nghenghiep
                    + "',@QueQuan = N'" + quequan
                    + "',@CMND = N'" + cmnd
                    + "',@NgaySinh ='" + formattedDate + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

            }


            /*string formattedDate = ngaysinh.ToString("yyy/MM/dd");
            string sqlString = "Exec InsertKhachThue "
                + "  @MaPhong ='" + maphong
                + "',@HoTen = N'" + hoten
                + "',@GioiTinh = N'" + gioitinh
                + "',@NgheNghiep = N'" + nghenghiep
                + "',@QueQuan = N'" + quequan
                + "',@CMND = N'" + cmnd
                + "',@NgaySinh ='" + formattedDate + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);*/
        }
        public bool CapNhatThongTinKhach(string maKT, string maphong, string hoten, string gioitinh, string nghenghiep, string quequan, string cmnd, DateTime ngaysinh)
        {
            string sqlString = "Exec UpdateKhachThue "
                + "  @MaKT ='" + maKT
                + "',@MaPhong = N'" + maphong
                + "',@HoTen = N'" + hoten
                + "',@GioiTinh = N'" + gioitinh
                + "',@NgheNghiep = N'" + nghenghiep
                + "',@QueQuan = N'" + quequan
                + "',@CMND = N'" + cmnd
                + "',@NgaySinh = '" + ngaysinh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhach(string maKT)
        {
            string sqlString = "Exec DeleteKhachThue "
                + "  @MaKT ='" + maKT + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public string LayIDMoi()
        {
            BLTTKhach bLTTKhach = new BLTTKhach();
            var table = bLTTKhach.LayThongTinKhach();
            table.PrimaryKey = new DataColumn[] { table.Columns["MaKhachTro"] };
            int id_khach = table.Rows.Count + 1;
            string idkhach = "KT" + id_khach.ToString("000");
            for (int i = 1; i < table.Rows.Count; i++)
            {
                if (table.Rows.Find("KT" + i.ToString("000")) == null)
                    return ("KT" + i.ToString("000"));
            }
            return idkhach;
        }


        public byte[] LayAnh(string id)
        {          
            string sqlString  = "SELECT TOP 1 AnhNhanDien FROM ThongTinKhach WHERE MaKhachTro = N'"+id+"'";
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


        public bool TraPhong(string maPhong)
        {
            string sqlString = "DELETE FROM ThongTinKhach WHERE MaPhong = '" + maPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataTable LayThongTinKhach_DungMaKT(string maKT)
        {
            string sqlString = "SELECT * FROM LocKhachThueTheoMaKT ('" + maKT + "')";


            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        //Dùng 
        public DataTable LayThongTinKhach_ThongTinThue(string maphong)
        {
            string sqlString = "SELECT TTP.MaKT, TK.HoTen " +
                               "FROM HOP_DONG TTP " +
                               "JOIN KHACH_THUE TK ON TTP.MaKT = TK.MaKT " +
                               "WHERE TTP.MaPhong = '" + maphong + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        //Dùng 
        public bool ThemKhach(string hoten, string gioitinh, DateTime ngaysinh, string cmnd, string quequan, string nghenghiep, string maphong)
        {
            string sqlString = "exec  InsertKhachThue @MaPhong ='" + maphong + "', @HoTen = N'" + hoten + "', @GioiTinh = N'" + gioitinh + "', @NgheNghiep = N'" + nghenghiep + "', @QueQuan=N'" + quequan + "', @CMND='" + cmnd + "', @NgaySinh = '" + ngaysinh + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //Dùng 
        public DataTable LayMaKT_CMND(string cmnd)
        {
            return db.ExecuteQueryDataSet("SELECT MaKT FROM KHACH_THUE where CMND='" + cmnd + "'", CommandType.Text);
        }
        //Dùng 
        public DataTable LayThongTinKhachQuaID(string id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM KHACH_THUE WHERE MaKT = '" + id + "'", CommandType.Text);
        }
        public DataTable ThongTinPhongMinh(string MaPhong)
        {
            string sqlString = "SELECT * FROM HienThiPhong_TheoPhong(" + MaPhong + ");";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable demSoLuongKhach ()
        {
            return db.ExecuteQueryDataSet("SELECT dbo.LaySoLuongKhach() AS SoLuongKhach", CommandType.Text);
        }
    }
}
