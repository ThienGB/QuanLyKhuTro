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

        //Dùng 
        public DataTable LayLoaiPhong()
        {
            return db.ExecuteQueryDataSet("select * from viewThongTinLoaiPhong ", CommandType.Text);
        }

        public bool ThemLoaiPhong(string MaLoaiPhong, string TenLoaiPhong, int DienTich, int DonGia)
        {
            string sqlString = "Insert Into THONG_TIN_LOAI_PHONG Values(" + "'" +
                                     MaLoaiPhong + "',N'" +
                                     TenLoaiPhong + "',N'" +
                                     DienTich + "'," +
                                     DonGia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaLoaiPhong(string MaLoaiPhong)
        {
            string sqlString = "Delete From THONG_TIN_LOAI_PHONG Where MaLP ='" + MaLoaiPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool CapNhatLoaiPhong(string MaLoaiPhong, string TenLoaiPhong, int DienTich, int DonGia)
        {
            string sqlString = "exec UpdateThongTinLoaiPhong @MaLP = '" + MaLoaiPhong + "', @DienTich=" + DienTich + ",@GiaThue=" + DonGia + ", @TenLoaiPhong=N'" + TenLoaiPhong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }

        public DataTable LayGiaPhong()
        {
            return db.ExecuteQueryDataSet("SELECT DISTINCT GiaThue FROM THONG_TIN_LOAI_PHONG", CommandType.Text);
        }

        public DataTable LayDienTich()
        {
            return db.ExecuteQueryDataSet("SELECT DISTINCT DienTich  FROM THONG_TIN_LOAI_PHONG", CommandType.Text);
        }
    }
}


