using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuanLyNhaTro.DB_layer;

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

        public DataTable LoadTienDichVu(string TenDV)
        {
            string sql = "SELECT Id, TenDichVu, Gia FROM DichVu WHERE TenDichVu = N'" + TenDV + "'";
                return db.ExecuteQueryDataSet(sql, CommandType.Text);           
        }
        //phương
        public DataTable ViewSuDungDichVu()
        {
            string sql = "SELECT * from ViewSuDungDichVu  ";       
            return db.ExecuteQueryDataSet(sql, CommandType.Text); 
            
           
        }  
        public DataTable DeleteSuDungDichVu(string madv,string maphong )
        {
            string sql = " DeleteSuDungDichVu @MaDV='"+ madv+"',@MaPhong='"+maphong+"'\r\n ";       
            return db.ExecuteQueryDataSet(sql, CommandType.Text); 
            
           
        } 
        public DataTable InsertSuDungDichVu(string madv,string maphong,string soluong )
        {
            string sql = " InsertSuDungDichVu   @MaDV='" + madv + "',@MaPhong='" + maphong + "', @SoLuong=" + soluong + "\r\n ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text); 
            
           
        } 
        public DataTable UpdateSuDungDichVu(string madv,string maphong,string soluong )
        {
            string sql = " UpdateSuDungDichVu   @MaDV='" + madv+"',@MaPhong='"+maphong+ "', @SoLuong="+soluong+"\r\n ";       
            return db.ExecuteQueryDataSet(sql, CommandType.Text); 
            
           
        }
        //hehehehe
        public DataTable LaySDDichVu(string maphong)
        {
            string sql = "SELECT * from SuDungDichVu_TheoPhong('" + maphong+"') ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);


        }

        public bool ThemDichVu(int ID, string TenDichVu, long Gia)
        {
            string sqlString = "Insert Into DichVu Values(" +
                                 "'" + ID + "',N'" + 
                                 "'" +TenDichVu + "'," +
                                 Gia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
        }

        public bool XoaDichVu(int ID)
        {
            string sqlString = "Delete From DichVu Where Id ='" + ID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
           
        }

        public bool CapNhatDichVu(int ID, string TenDichVu, long Gia)
        {
            string sqlString = "UPDATE DichVu SET TenDichVu=N'" + TenDichVu + "', Gia=" + Gia + " WHERE Id= '" + ID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
        }
    }
}
