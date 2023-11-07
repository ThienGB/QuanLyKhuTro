using QuanLyNhaTro.DB_layer;
using System;
using System.Data;

namespace QuanLyNhaTro.BS_layer
{
    class BLPhieuThu
    {

        DBMain db = null;
        string err;

        public BLPhieuThu()
        {
            db = new DBMain();
        }

        public DataTable LayPhieuThu()
        {
            return db.ExecuteQueryDataSet("select * from PhieuThu", CommandType.Text);
            
        }

        public DataTable LayPhieuThuTheoMa(int maPT)
        {
            string sql = "select * from PhieuThu where MaPT = " + maPT ;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }
        public double  TongDaThu()
        {
            string sql = "SELECT SUM(TongTien) " +
                   "FROM PhieuThu " +
                   "Where TrangThai= N'Đã thu'";
            var table = db.ExecuteQueryDataSet(sql, CommandType.Text);
            int a = table.Rows.Count;
            string text =table.Rows[0][0].ToString();
            
            
            double tongDaThu = double.Parse(table.Rows[0][0].ToString());
            
            return tongDaThu;

        }

        public double LayIDMoi()
        {
            var table = this.LayPhieuThu();
            table.PrimaryKey = new DataColumn[] { table.Columns["MaPT"] };
            double id_pt = table.Rows.Count + 1;
            return id_pt;
        }

        public bool ThemPhieuThu(double idPT, string maphong, DateTime ngaylap, DateTime ngaythu, long tiennha, int sokidien, long tiendien, int sokhoinuoc, long PT_tiennuoc, long tongtien)
        {
            string sqlString = "Insert Into PhieuThu Values(" + 
                                     idPT + ",N'" +
                                     maphong + "',N'" +
                                     ngaylap + "',N'" +
                                     ngaythu + "',N'" +
                                     tiennha + "',N'" +
                                     sokidien + "',N'" +
                                     tiendien + "',N'" +
                                     sokhoinuoc + "',N'" +
                                     PT_tiennuoc + "',N'" +
                                     tongtien +                 
                                     "',N'Chưa thu')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable LayThangPhieuThu()
        {
            string sql = "SELECT CONVERT(VARCHAR(2), NgayLap, 101) +'/' + CONVERT(VARCHAR(4), NgayLap, 120) AS Thang " +
                   "FROM PhieuThu " +
                   "ORDER BY NgayLap ASC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }
        public DataTable LayThangPhieuThuTheoMaPhong(string MaPhong)
        {
            string sql = "SELECT Thang from PhieuThuTheoMaPhong ('" + MaPhong + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }
        public DataTable LayPTTheoMaPhongvaThang(string MaPhong, string ThangNam)
        {
            string[] parts = ThangNam.Split('/');
            int thang = int.Parse(parts[0]);
            int nam = int.Parse(parts[1]);
            string sql = "SELECT * from LayPTTheoMaPhongvaThang ('" + MaPhong + "', '" + thang + "', '" + nam + "')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        public DataTable LayPhieuThuTheoThang(string thang)
        {
            string sql= "SELECT MaPT, NgayLap, MaPhong " +
                   "FROM PhieuThu " +
                   "WHERE CONVERT(VARCHAR(2), NgayLap, 101) + '/' + CONVERT(VARCHAR(4), NgayLap, 120) ='"+ thang +
                   "' AND TrangThai = N'Đã thu'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);            
        }

        public long TongDoanhThuThang(string thang)
        {
            string sql = "SELECT SUM(TongTien) " +
                   "FROM PhieuThu " +
                   "WHERE CONVERT(VARCHAR(2), NgayLap, 101) + '/' + CONVERT(VARCHAR(4), NgayLap, 120) = '"+thang +
                   "'AND TrangThai = N'Đã thu'";
            var table = db.ExecuteQueryDataSet(sql, CommandType.Text);
            long tongDaThu = Convert.ToInt64(table.Rows[0][0].ToString());
            return tongDaThu;

        }

        

        public DataTable LayPhongChuaThu(string makv)
        {
            string sqlString = "SELECT pt.MaPT, pt.MaPhong, pt.TongTien " +
                   "FROM PhieuThu pt " +
                   "INNER JOIN Phong p ON pt.MaPhong = p.MaPhong " +
                   "WHERE p.MaKhuVuc ='" + makv + "'AND pt.TrangThai = N'Chưa thu'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
           
        }

        public bool CapNhatPhieuThu(float id ,DateTime ngaythu)
        {
            string sqlString = "Update PhieuThu Set NgayThu=N'" +
                                    ngaythu +"', TrangThai = N'Đã thu'"+ " Where MaPT=N'" + id+"'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
           
        }

        
    }
}