using QuanLyNhaTro.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class ThemPhong : UserControl
    {
        BLKhuTro bLKhuVuc = new BLKhuTro();
        BLLoaiPhong bLLoaiPhong = new BLLoaiPhong();
        BLPhong bLPhong = new BLPhong();


        public ThemPhong()
        {
            InitializeComponent();
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
        }
  

        private void Load_ComboBox()
        {
            
            var kv = bLKhuVuc.LayKhuTro();
            cbKV.ValueMember = "MaKhuVuc";
            cbKV.DisplayMember = "TenKhuVuc";
            cbKV.DataSource = kv;

            var lp = bLLoaiPhong.LayLoaiPhong();
            cbLoaiPhong.ValueMember = "MaLoaiPhong";
            cbLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbLoaiPhong.DataSource = lp;
        }
        public bool Check()
        {
            bool check;
            if (txtMaPhong.Text == "" || txtTenPhong.Text == ""|| txtDay.Text==""
                ||cbKV.SelectedValue.ToString()==""||cbLoaiPhong.SelectedValue.ToString()=="")
            {
                check = false;
            }
            else check = true;  
            return check;
        }

        private void btThem_Click(object sender, EventArgs e)
        { 
            string maphong = txtMaPhong.Text.ToString(),
                    loaiphong = cbLoaiPhong.SelectedValue.ToString(),
                    khuvuc = cbKV.SelectedValue.ToString(),
                    tenphong = txtTenPhong.Text.ToString(),
                    day = txtDay.Text.ToString();
            
            if (Check() == false)
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Check()== true )
            {
                bLPhong.ThemPhong(maphong, loaiphong, khuvuc, tenphong);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btHuy_Click_1(object sender, EventArgs e)
        {
            txtDay.Clear();
            txtMaPhong.Clear();
            txtTenPhong.Clear();
        }
    }
}
