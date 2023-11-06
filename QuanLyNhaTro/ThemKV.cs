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
    public partial class ThemKV : UserControl
    {
        BLKhuVuc bLKhuVuc = new BLKhuVuc();

        public ThemKV()
        {
            InitializeComponent();
        }

        private void ThemKV_Load(object sender, EventArgs e)
        {
            var dtKV=bLKhuVuc.LayKhuVuc();
            txtMaKV.Text = "KV" + dtKV.Rows.Count.ToString();      
        }

        public bool check()
        {
            bool check;
            if (txtTenKV.Text == "" )
                check = false;
            else check = true;
            return check;
        }

        public void btThem_Click(object sender, EventArgs e)
        {
            string makv = txtMaKV.Text;
            string ten = txtTenKV.Text;
            if (check() == false)
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                bLKhuVuc.ThemKhuVuc(makv, ten);
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }               
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenKV.Clear();
        }
    }
  
}
