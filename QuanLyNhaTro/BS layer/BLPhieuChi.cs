using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


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


        //Dùng 
        public bool InsertPhieuChi (DateTime NgayLap, int sotien, string ghichu )
        {
            string sql = "exec  InsertPhieuChi @NgayLapPC = '" + NgayLap + "', @SoTien =" + sotien + ",@GhiChu = N'" + ghichu + "'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}
