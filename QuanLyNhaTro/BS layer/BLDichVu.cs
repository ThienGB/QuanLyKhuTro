using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyNhaTro.DB_layer;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QuanLyNhaTro.BS_layer
{
    public class BLDichVu
    {
        DBMain db = null;
        string err;

        public BLDichVu()
        {
            db = new DBMain();
        }

        //Dùng 
        public DataTable LoadTienDichVu(string MaDV)
        {
            string sql = "SELECT * FROM LayDichVuByMaDV('" + MaDV+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);           
        }

        //Dùng 
        public DataTable LayThongTinDichVu()
        {
            string sql = "SELECT * FROM viewThongTinDichVu";       
            return db.ExecuteQueryDataSet(sql, CommandType.Text);      
        }

        //Dùng 
        public DataTable LayThongTinDichVuSuDung(string MaPhong)
        {
            string sql = "SELECT * FROM LayTTDVSuDung('" + MaPhong+"')";  
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public bool ThemDichVu(string ID, string TenDichVu, int Gia)
        {
            string sqlString = "exec InsertThongTinDichVu @MaDV='" + ID + "',@GiaTien=" + Gia + " , @TenDichVu= N'" + TenDichVu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }

        //Dùng 
        public bool ThemDichVuSuDung(string MaPhong, string MaDV, int soluong )
        {
            string sqlString = "exec InsertSuDungDichVu @MaDV='" + MaDV + "',@MaPhong='" + MaPhong + "',@SoLuong="+soluong ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }

        public bool XoaDichVu(string ID)
        {
            string sqlString = "exec DeleteThongTinDichVu @MaDV='" + ID + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }

        //Dùng 
        public bool XoaDichVuSuDung(string MaDV, string MaPhong)
        {
            string sqlString = "exec DeleteSuDungDichVu @MaDV='" + MaDV + "',@MaPhong='" + MaPhong +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }        

        public bool CapNhatDichVu(int ID, string TenDichVu, long Gia)
        {
            string sqlString = "UPDATE DichVu SET TenDichVu=N'" + TenDichVu + "', Gia=" + Gia + " WHERE Id= '" + ID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
        }

        //Dùng 
        public bool CapNhatDichVu(string ID, string TenDichVu, int Gia)
        {
            string sqlString = "exec UpdateThongTinDichVu @MaDV='" + ID + "',@GiaTien=" + Gia + " , @TenDichVu= N'" + TenDichVu + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }

    }
}
