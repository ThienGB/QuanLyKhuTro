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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaTro.FrmMain
{
    
    public partial class Dsthutien : UserControl
    {
        private string mapt;
        BLPhieuThu dbPT = new BLPhieuThu();

        string maphong;
        float idhoadon;
        public Dsthutien()
        {
            InitializeComponent();
        }


        private void Dsthutien_Load(object sender, EventArgs e)
        {
            listHoaDon.Items.Clear();
            LoadList();
        }


        private void LoadList()
        {
        
            var loaiphong = dbPT.ViewChuaDongTien();
            foreach (DataRow row in loaiphong.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPT"].ToString()); // Giả sử cột "MaPhong" trong DataTable
                item.SubItems.Add(row["MaPhong"].ToString()); // Giả sử cột "TenPhong" trong DataTable
                item.SubItems.Add(row["NgayLapPT"].ToString()); // Giả sử cột "MaLoaiPhong" trong DataTable
                item.SubItems.Add(row["TongTien"].ToString()); // Giả sử cột "Day" trong DataTable
                item.SubItems.Add(row["TrangThai"].ToString()); // Giả sử cột "Day" trong DataTable
                listHoaDon.Items.Add(item); // Thêm mục vào ListView
            }
        }

        private void listHoaDon_Click(object sender, EventArgs e)
        {
            ListViewItem item = listHoaDon.SelectedItems[0];
            mapt=item.Text;

            var data= dbPT.ViewChuaDongTien_MaPT(mapt);
  
            txtMaPhong.Text = data.Rows[0][1].ToString();
            txtPhiDV.Text= data.Rows[0][5].ToString();
            txtPhiMT.Text= data.Rows[0][4].ToString();
            txtTienPhong.Text= data.Rows[0][7].ToString();
            txtTong.Text= data.Rows[0][8].ToString();
        }


        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Xác nhận đã thu tiền", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbPT.CapNhapPT_MaPT(mapt);
                listHoaDon.Items.Clear();
                LoadList();
                MessageBox.Show("Đã đóng!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }
        }
    }
}
