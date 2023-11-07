using QuanLyNhaTro.DB_layer;
using System;
using System.Data;
using System.Data.SqlTypes;

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
            return db.ExecuteQueryDataSet("select * from PHIEU_THU", CommandType.Text);
            
        }
        public DataTable LayPhieuThuTheoMa(int Mapt)
        {
            string sql = "select * from PHIEU_THU where MaPT = " + Mapt;
            return db.ExecuteQueryDataSet(sql, CommandType.Text);

        }

        //Dùng 
        public DataTable LayPhieuThuTheoMaPhong(string MaP)
        {
            string sql = "select * from LayPhieuThuTheoMaPhong('"+MaP+"')";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
           
        }


        public double  TongDaThu()
        {
            string sql = "SELECT SUM(TongTien) " +
                   "FROM PHIEU_THU " +
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

        //Dùng 
        public bool ThemPhieuThu(string MaP, int PhiMT, int Sodien, int Sonuoc)
        {
            string sql = "exec TaoPhieuThu  @MaPhong='" + MaP + "' ,@PhiMoiTruong=" + PhiMT + ", @SoDien=" + Sodien + ", @SoNuoc=" + Sonuoc;
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref err);
        }


        public DataTable LayThangPhieuThu()
        {
            string sql = "SELECT CONVERT(VARCHAR(2), NgayLap, 101) +'/' + CONVERT(VARCHAR(4), NgayLap, 120) AS Thang " +
                   "FROM PHIEU_THU " +
                   "ORDER BY NgayLap ASC";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
            
        }


        public DataTable LayPhieuThuTheoThang(string thang)
        {
            string sql= "SELECT MaPT, NgayLap, MaPhong " +
                   "FROM PHIEU_THU " +
                   "WHERE CONVERT(VARCHAR(2), NgayLap, 101) + '/' + CONVERT(VARCHAR(4), NgayLap, 120) ='"+ thang +
                   "' AND TrangThai = N'Đã thu'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);            
        }

        public long TongDoanhThuThang(string thang)
        {
            string sql = "SELECT SUM(TongTien) " +
                   "FROM PHIEU_THU " +
                   "WHERE CONVERT(VARCHAR(2), NgayLap, 101) + '/' + CONVERT(VARCHAR(4), NgayLap, 120) = '"+thang +
                   "'AND TrangThai = N'Đã thu'";
            var table = db.ExecuteQueryDataSet(sql, CommandType.Text);
            long tongDaThu = Convert.ToInt64(table.Rows[0][0].ToString());
            return tongDaThu;

        }

        

        public DataTable LayPhongChuaThu(string makv)
        {
            string sqlString = "SELECT pt.MaPT, pt.MaPhong, pt.TongTien " +
                   "FROM PHIEU_THU pt " +
                   "INNER JOIN Phong p ON pt.MaPhong = p.MaPhong " +
                   "WHERE p.MaKhuTro ='" + makv + "'AND pt.TrangThai = N'Chưa thu'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
           
        }

        public bool CapNhatPhieuThu(float id ,DateTime ngaythu)
        {
            string sqlString = "Update PHIEU_THU Set NgayThu=N'" +
                                    ngaythu +"', TrangThai = N'Đã thu'"+ " Where MaPT=N'" + id+"'" ;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
           
        }

        
    }
}