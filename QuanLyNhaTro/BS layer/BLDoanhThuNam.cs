using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLDoanhThuNam
    {
        DBMain db = null;
        string err;
        public BLDoanhThuNam()
        {
            db = new DBMain();
        }

        public DataTable LayDoanhThuNam()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM ViewDoanhThuNam", CommandType.Text);
        }
    }
}
