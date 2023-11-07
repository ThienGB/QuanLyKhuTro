using QuanLyNhaTro;
using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
        public DataTable LayPhongtrong(string makv)
        {
            string sql = "SELECT * from LocPhongTheoKhuTro('"+makv+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        public DataTable LayPhongtrong_gia(string dongia )
        {
            string sql = "select * from  LocPhongTheoGia(" + dongia + ")";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        public DataTable LayPhongtrong_dientich(string dientich)
        {
            string sql = "select * from  LocPhongTheoGia(" + dientich + ")";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        //Dùng 
        public DataTable LayLoaiPhong()
        {
            string sql = "Select * from ViewThongTinLoaiPhong ";
            return db.ExecuteQueryDataSet(sql,CommandType.Text);
            
        }

        //Dùng 
        public DataTable LayPhongtrong(string makv, string loaiphong)
        {           
            string sql = "select * from LayPhongTrongMaKV_LP( '"+makv+"','"+loaiphong+"' )";
            return db.ExecuteQueryDataSet (sql,CommandType.Text);          
        }

       
        //Dùng 
        public DataTable LayPhongtrong_MaKV_TenP(string makv, string tenphong)
        {
            string sql = "SELECT * from LayPhongTrongTheoTenP_MaKTro( '"+makv+"', '"+tenphong+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //Dùng 
        public DataTable LayPhong_MaP(string maphong)
        {
            string sql = "select * from LayPhongTrong_MaP('"+maphong+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }

        public DataTable Layphong_TT_MaKV(string trangthai,string makv)
        {
            string sql = "SELECT MaPhong, TenPhong " +
                 "FROM PHONG_TRO " +
                 "WHERE TrangThai = N'"+trangthai +"' AND MaKhuTro = N'"+makv+"'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

        //Dùng 
        public bool UpdateTrangThai(string maphong,string trangthai ) 
        {
            string sqlString = "exec UpdateTTPhongTro @MaPhong='"+maphong+"',@TrangThai =N'"+trangthai+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
           
        }

        public bool ThemPhong(string maphong,string maloaiphong,string khuvuc,string tenphong,string  day)
        {
            string sqlString = "Insert Into PHONG_TRO Values(" + "'" +
                             maphong + "',N'" +
                             maloaiphong + "',N'" +
                             khuvuc + "',N'" +
                             tenphong + "',N'" +
                             day  + "',N'Trống',N'1')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);           
        }

        //Dùng 
        public DataTable LayPhongChuaLapHD(string makv, int  thismonth , int  thisyear ) 
        {
            string sql = "select * from GetPhongChuaThu( '"+makv+"' , '"+thismonth+"' , '"+thisyear+"' ) ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);        
            
        }

        //Dùng 
        public DataTable LayMaPhong(string tenphong, string Makv)
        {
            string sql = "select * from LayMaPhong_TenP_MaKtro('"+tenphong+"' , '"+Makv+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }
        
        //Dùng
        public DataTable LayP_dathue_TTThue(string maphong)
        {
            string sql = "select * from LayThongTinPhong_Ngaythue('"+maphong+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

        public DataTable LayPhongDaThue_MaKV_LP(string makv, string loaiphong)
        {
            string sql = "Select * from PHONG_TRO " +
                "where MaKhuTro = N'" + makv + "' and TrangThai = N'Đã thuê' and  MaLP =N'"+loaiphong+"'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

        public DataTable LayPhongDaThue_MaKV_TenP(string makv, string tenphong)
        {
            string sql = "Select * from PHONG_TRO "+
                "where MaKhuTro = N'" + makv + "' and TrangThai = N'Đã thuê' and  TenPhong =N'" + tenphong + "'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }

        public DataTable LayPhongDaThue_MaKV(string makv)
        {

            string sql = "select Maphong,TenPhong,MaLP,Day from PHONG_TRO " +
                "where MaKhuTro = N'" + makv + "' and TrangThai = N'Đã thuê'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }

    }
}

