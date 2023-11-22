using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyNhaTro.BS_layer;
using System.Drawing;

namespace QuanLyNhaTro.DB_layer
{
    class DBMain
    {
       
      //  string ConnStr = "Data Source=DESKTOP-F3GD5US\\MAYAOTHIEN;Initial Catalog=QLKhuTro;Integrated Security=True";
        
        public SqlConnection conn = null;
        public SqlCommand comm = null;
        public SqlDataAdapter da = null;
        public DBMain()
        {
            
        }
        public DataTable ExecuteQueryDataSet(string strSQL, CommandType ct)
        {

            string ConnStr = @"Data Source=192.168.0.107;Initial Catalog=QLKhuTro;User Id=" + Global.username + ";Password=" + Global.password + ";";
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            string ConnStr = @"Data Source=192.168.0.107;Initial Catalog=QLKhuTro;User Id=" + Global.username + ";Password=" + Global.password + ";";
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Là mã lỗi cho ràng buộc duy nhất
                {
                    error = "Số CMND này đã tồn tại, vui lòng nhập lại";
                }
                else
                {
                    error = ex.Message; // Xử lý lỗi SQL Server ở trường hợp khác
                }
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

    }
}