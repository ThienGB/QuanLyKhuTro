using QuanLyNhaTro.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class ThemTK : Form
    {
        public ThemTK()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtpassword.Text;
            BLDangNhap bLDangNhap = new BLDangNhap();
            bool i = bLDangNhap.ThemTaiKhoan(id, pass);
            if (i == true)
                MessageBox.Show("Thêm thành công!");
            this.Close();
        }
    }
}
