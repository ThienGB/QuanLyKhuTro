using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLDoanhThuThang
    {
        DBMain db = null;
        string err;
        public BLDoanhThuThang()
        {
            db = new DBMain();
        }

        public DataTable LayDoanhThuThang()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ViewDoanhThuThang", CommandType.Text);
        }
    }
}
