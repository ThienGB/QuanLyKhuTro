using QuanLyNhaTro.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class ThongTinPhongMinh : UserControl
    {
        string MaPhong = "201";
        DataTable rs = null;
        BLTTKhach ttk= new BLTTKhach();
        public ThongTinPhongMinh()
        {
            InitializeComponent();
        }
        public ThongTinPhongMinh(string MaPhong) : this()
        {
            this.MaPhong =MaPhong;
        }
        private void ThongTinPhongMinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData() {
            rs = ttk.ThongTinPhongMinh(MaPhong);
            lblMaPhong.Text = rs.Rows[0][0].ToString();
            lblLoaiPhong.Text = rs.Rows[0][2].ToString();
            lblTenKhuTro.Text = rs.Rows[0][1].ToString();
            lblDiaChi.Text = rs.Rows[0][3].ToString();
        }

    }
}
