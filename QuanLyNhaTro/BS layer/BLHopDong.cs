using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    internal class BLHopDong
    {
        DBMain db = null;
        string err;
        public BLHopDong()
        {
            db = new DBMain();
        }
        public DataTable LayHopDong()
        {

            return db.ExecuteQueryDataSet("select * from ViewHopDong ", CommandType.Text);

        }
        public DataTable LayHopDong_MaKV(string makv)
        {

            return db.ExecuteQueryDataSet("select * from LocPhongTheoKhuVuc('"+ makv+ "') ", CommandType.Text);

        }

    }
}

