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

namespace QuanLyNhaTro.FrmMain
{
    public partial class Dsthutien : UserControl
    {
        BLKhuVuc dbkv = new BLKhuVuc();
        BLPhieuThu dbPT = new BLPhieuThu();

        string maphong;
        float idhoadon;
        public Dsthutien()
        {
            InitializeComponent();
        }

        void LoadDataKV()
        {
            try
            {
                cbKhuVuc.DisplayMember = "TenKhuVuc";
                cbKhuVuc.ValueMember = "MaKhuVuc";
                cbKhuVuc.DataSource = dbkv.LayKhuVuc();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table KHUVUC. Lỗi rồi!!!");
            }
        }

        private void Dsthutien_Load(object sender, EventArgs e)
        {
            LoadDataKV();
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHoaDon.Items.Clear();
            LoadList();
        }

        private void LoadList()
        {
            string makv = cbKhuVuc.SelectedValue.ToString();

            var loaiphong = dbPT.LayPhongChuaThu(makv);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][1].ToString().TrimEnd());
                item.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(loaiphong.Rows[i][2].ToString().TrimEnd())));

                listHoaDon.Items.Add(item);
            }
        }

        private void listHoaDon_Click(object sender, EventArgs e)
        {
            ListViewItem item = listHoaDon.SelectedItems[0];
            string maPT = item.Text;            
            maphong = maPT;
            var table = dbPT.LayPhieuThuTheoMa(int.Parse(maPT));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                grCTHD.Text = "Chi tiết hóa đơn số: " + table.Rows[i][0].ToString().TrimEnd();
                lbLoaiphong.Text = table.Rows[i][1].ToString().TrimEnd();
                lbTienPhong.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][4].ToString().TrimEnd()));
                lbDienSK.Text = table.Rows[i][5].ToString().TrimEnd();
                lbTienDien.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][6].ToString().TrimEnd()));
                lbNuocSK.Text = table.Rows[i][7].ToString().TrimEnd();
                lbTienNuoc.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][8].ToString().TrimEnd()));
                lbTT.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][9].ToString().TrimEnd())) + " vnd";
            }
            idhoadon = float.Parse(table.Rows[0][0].ToString());
        }


        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            DateTime ngaythu = DateTime.Today;
            if (MessageBox.Show("Thời gian thu: " + ngaythu.ToString() + "\nMã Phòng: " + maphong, "Xác nhận thanh toán hóa đơn: " + idhoadon, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listHoaDon.SelectedItems[0];
                string thang = item.Text;
                bool i = dbPT.CapNhatPhieuThu(idhoadon, ngaythu);
                MessageBox.Show("Đã đóng thành công!");
                listHoaDon.Items.Clear();
                LoadList();
            }
        }
    }
}
