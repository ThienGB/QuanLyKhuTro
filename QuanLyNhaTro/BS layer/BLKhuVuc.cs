
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
    class BLKhuVuc
    {
        DBMain db = null;
        string err;
        public BLKhuVuc()
        {
            db = new DBMain();
        }

        public DataTable LayKhuVuc()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ViewKhuTro ", CommandType.Text);
        }

        public bool ThemKhuVuc(string MaKV, string TenKhuVuc)
        {
            string sqlString = "insert into KhuVuc (MaKhuVuc, TenKhuVuc) values(" + "'" + MaKV + "',N'" + TenKhuVuc + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}