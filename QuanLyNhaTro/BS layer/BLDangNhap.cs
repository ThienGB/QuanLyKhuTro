using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.Design.WebControls;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Security.Cryptography;
using QuanLyNhaTro.DB_layer;

namespace QuanLyNhaTro.BS_layer
{
    class BLDangNhap
    {
        DBMain db = null;
        string err;
        public BLDangNhap()
        {
            db = new DBMain();
        }

        public bool DangNhap(string id, string pass)
        {
            string sqlString = "Select * From DangNhap where id =N'" + id + "' and pass = N'" + pass + "'";
            var table = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            int row = table.Rows.Count;
            if (row == 0)
            {
                return false;
            }
            return true;
        }
        public bool ThemTaiKhoan(string id, string pass)
        {
            string sqlString = "Insert Into DangNhap (id, pass) Values(" + "'" + id + "',N'" + pass + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable LayGhiNho()
        {
            return db.ExecuteQueryDataSet("select id, password from GhiNho", CommandType.Text);
        }
        
        public bool LuuTaiKhoan(string id, string pass)
        {
            this.Del();
            string sqlString = "insert into GhiNho (id, password) values (" + "'" + id + "',N'" + pass + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool Del()
        {
            DataTable dt = this.LayGhiNho();
            if (dt.Rows.Count > 0)
            {
                string Id = dt.Rows[0][0].ToString();
                string sqlString = "delete from GhiNho where id =N'" + Id + "'";
               
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            }
            return false;
        }

        public bool DoiMatKhau(string id, string pass)
        {
            string sqlString = "update DangNhap set pass =N'" + pass + "' where id =N'" + id + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        //Dùng 
        public bool InsertTaiKhoan(string cmnd, string maphong, string makt )
        {
            string sql = "exec InsertTaiKhoan @TaiKhoan='"+cmnd+"',@MatKhau ='"+maphong+"', @MaKT ='"+makt+"'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }
    }
}