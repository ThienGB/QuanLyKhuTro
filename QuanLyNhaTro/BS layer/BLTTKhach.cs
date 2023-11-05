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
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinKhach", CommandType.Text);
        }
        public DataTable LayThongTinKhachQuaID(string id)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ThongTinKhach WHERE MaKhachTro = '" + id + "'", CommandType.Text);
        }

        public DataTable LayThongTinKhachQuaMaPhong(string maphong)
        {
            return db.ExecuteQueryDataSet("SELECT MaKhachTro, Ho, Ten, GioiTinh, NgaySinh,CMND, QueQuan, NgheNghiep FROM ThongTinKhach WHERE MaPhong = '" + maphong + "'", CommandType.Text);
        }

        public bool ThemKhach(string makhach, string ho, string ten, string gioitinh, DateTime ngaysinh, string cmnd, string quequan, string nghenghiep, string maphong, string ghichu)
        {          
            string sqlString = "INSERT INTO ThongTinKhach VALUES (" + "'" + makhach + "', N'" + ho + "', N'" + ten +
                "', N'" + gioitinh + "', NULL, '" + ngaysinh + "', '" + cmnd + "', N'" + quequan + "', N'" + nghenghiep +
                "', '" + maphong + "', N'" + ghichu + "')";
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

        public bool CapNhatThongTinKhach(string id, string ho, string ten, string gioitinh, DateTime ngaysinh, string cmnd, string quequan, string nghenghiep, string ghichu, byte[] Image)
        {
            string query;
            if (Image != null)
            {
                 query = "UPDATE ThongTinKhach SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, QueQuan = @QueQuan, NgheNghiep = @NgheNghiep, GhiChu = @GhiChu, AnhNhanDien = @AnhNhanDien WHERE MaKhachTro = @MaKhachTro";
                db.comm.Parameters.AddWithValue("@AnhNhanDien", Image);
            }
            else query = "UPDATE ThongTinKhach SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, CMND = @CMND, QueQuan = @QueQuan, NgheNghiep = @NgheNghiep, GhiChu = @GhiChu WHERE MaKhachTro = @MaKhachTro";    
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
