using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaTro.DB_layer;
    

namespace QuanLyNhaTro.BS_layer
{
    
    class BLLoaiPhong
    {
        DBMain db = null;
        string err;
        public BLLoaiPhong()
        {
            db = new DBMain();
        }
        public DataTable LayLoaiPhong()
        {

            return db.ExecuteQueryDataSet("select MaLP, TenLoaiPhong, DienTich, GiaThue from ViewThongTinLoaiPhong", CommandType.Text);

        }

        public bool ThemLoaiPhong(string TenLoaiPhong, int DienTich, int DonGia)
        {
            string sqlString = "exec insertThongTinLoaiPhong @DienTich= " + DienTich + ",	@GiaThue=" + DonGia + ",@TenLoaiPhong=N'" + TenLoaiPhong + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaLoaiPhong(string MaLoaiPhong)
        {
            string sqlString = "exec DeleteThongTinLoaiPhong @MaLP ='" + MaLoaiPhong + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool CapNhatLoaiPhong(string MaLoaiPhong, string TenLoaiPhong, int DienTich, int DonGia)
        {
            string sqlString = "exec UpdateThongTinLoaiPhong @MaLP = '" + MaLoaiPhong + "', @DienTich=" + DienTich + ",@GiaThue=" + DonGia + ", @TenLoaiPhong=N'" + TenLoaiPhong + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
    }
}


