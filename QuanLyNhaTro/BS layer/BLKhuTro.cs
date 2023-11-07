
using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLKhuTro
    {
        DBMain db = null;
        string err;
        public BLKhuTro()
        {
            db = new DBMain();
        }

        public DataTable LayKhuTro()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ViewKhuTro", CommandType.Text);
        }

        public bool ThemKhuTro(string TenKhuTro, string DiaChi)
        {
            string sqlString = "exec insertKhuTro @TenKhuTro =N'" + TenKhuTro + "', @DiaChi = N'" + DiaChi + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhuTro(string MaKhuTro)
        {
            string sqlString = "exec DeleteKhuTro @MaKhuTro ='" + MaKhuTro + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool SuaKhuTro(string MaKhuTro, string TenKhuTro, string DiaChi)
        {
            string sqlString = "exec  UpdateKhuTro @MaKhuTro = '" + MaKhuTro + "', @TenKhuTro = N'" + TenKhuTro + "', @DiaChi =N'" + DiaChi + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}