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
        public DataTable LayThongTinKhachQuaID(string id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinKhach WHERE MaKhachTro = '" + id + "'", CommandType.Text);
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


        public DataTable LayThongTinKhach_ThongTinThue(string maphong)
        {
            string sqlString = "SELECT TTP.MaKhachTro, TK.Ho + ' ' + TK.Ten AS HoTen " +
                               "FROM ThongTinThuePhong TTP " +
                               "JOIN ThongTinKhach TK ON TTP.MaKhachTro = TK.MaKhachTro " +
                               "WHERE TTP.MaPhong = @MaPhong";
            db.comm.Parameters.AddWithValue("@MaPhong", maphong);
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool TraPhong(string maPhong)
        {
            string sqlString = "DELETE FROM ThongTinKhach WHERE MaPhong = '" + maPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
