﻿using QuanLyNhaTro.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.BS_layer
{
    class BLTTThuePhong
    {
        DBMain db = null;
        string err;
        public BLTTThuePhong()
        {
            db = new DBMain();
        }

        public DataTable LayThongTinThue()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM HOP_DONG", CommandType.Text);
        }

        public int LayIDMoi()
        {
            var table = this.LayThongTinThue();
            table.PrimaryKey = new DataColumn[] { table.Columns["MaHD"] };
            int id = table.Rows.Count + 1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows.Find(i) == null)
                    return i;
            }
            return id;
        }

        public bool ThemThongTinThue(string idtttp, string makhach, string maphong, DateTime ngaythue, long tiendatcoc)
        {
            string sqlString = "INSERT INTO HOP_DONG VALUES ('" + idtttp + "', '" + makhach + "', '" +
                maphong + "', '" + ngaythue + "', '" + tiendatcoc + "', 'null'" + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool TraPhong(string maphong)
        {
            string sqlString = "DELETE FROM HOP_DONG WHERE MaPhong = '" + maphong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //Dùng 
        public bool ThemThongTinThue(string makhach, string maphong, DateTime ngaythue, long tiendatcoc)
        {
            string sqlString = "exec InsertHopDong @MaKT='" + makhach + "', @MaPhong='" + maphong + "' ,@TienDatCoc =" + tiendatcoc + ",@NgayBatDau='" + ngaythue + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
