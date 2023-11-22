using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection.Emit;

namespace QuanLyNhaTro.BS_layer
{
    class BLPhieuChi
    {
        public BLPhieuChi()
        {
            db = new DBMain(); // Khởi tạo đối tượng DBMain
        }
        DBMain db = null;
        string err;

        public DataTable layPhieuChi()
        {
            string sql = "select * from Phieu_chi ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        //Dùng 
        public bool InsertPhieuChi(DateTime NgayLap, string sotien, string ghichu)
        {
            string sql = "exec  InsertPhieuChi @NgayLapPC = '" + NgayLap + "', @SoTien =" + sotien + ",@GhiChu = N'" + ghichu + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool updatePhieuChi(string id, string sotien, string ghichu, string ngayLap)
        {
            string sql = "exec  UpdatePhieuChi @MaPC = '" + id + "' , @NgayLapPC = '" + ngayLap + "', @SoTien = '" + sotien + " ',@GhiChu = N'" + ghichu + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool DeletePhieuChi(string id)
        {
            string sql = "exec  DeletePhieuChi @MaPC = '" + id + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
