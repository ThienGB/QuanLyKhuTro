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
    public partial class ThemNguoi : UserControl
    {
        string ho, ten, gioitinh, cmnd, quequan, nghenghiep, maphong, ghichu;
        DateTime ngaysinh;
        string makhach;
        BLKhuVuc dbKhuVuc = new BLKhuVuc();
        BLLoaiPhong dbLoaiPhong = new BLLoaiPhong();
        BLPhong dbPhong = new BLPhong();
        BLTTKhach dbKhach = new BLTTKhach();

        public ThemNguoi()
        {
            InitializeComponent();
        }

        private void ThemNguoi_Load(object sender, EventArgs e)
        {
            Load_CBKhuVuc();
            Load_CBLoaiPhong();
            ListViewPhong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Load_CBKhuVuc()
        {
            var kv = dbKhuVuc.LayKhuVuc();
            cbKhuVuc.ValueMember = "MaKhuTro";
            cbKhuVuc.DisplayMember = "TenKhuTro";
            cbKhuVuc.DataSource = kv;
        }

        private void Load_CBLoaiPhong()
        {
            var lp = dbLoaiPhong.LayLoaiPhong();
            cbChonPhong.ValueMember = "MaLP";
            cbChonPhong.DisplayMember = "TenLoaiPhong";
            cbChonPhong.DataSource = lp;
        }

        private void Load_ListViewPhong()
        {
            string khuvuc = cbKhuVuc.SelectedValue.ToString();
            string loaiphong = cbChonPhong.SelectedValue.ToString();
            textBox1.Text = khuvuc +" " + loaiphong;
            var phong = dbPhong.LayPhongDaThue_MaKV_LP(khuvuc, loaiphong);
            for (int i = 0; i < phong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(phong.Rows[i][3].ToString());
                item.SubItems.Add(phong.Rows[i][0].ToString());
                item.ImageIndex = 0;
                ListViewPhong.Items.Add(item);
            }
        }

        private void ListViewPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvKhachThue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewPhong.Items.Clear();
            Load_CBLoaiPhong();
        }

        private void cbChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewPhong.Items.Clear();
            Load_ListViewPhong();
        }

        private void ListViewPhong_Click(object sender, EventArgs e)
        {
            string khuVuc = cbKhuVuc.SelectedValue.ToString();
            string tenPhong = ListViewPhong.SelectedItems[0].Text;
            var mp = dbPhong.LayPhongDaThue_MaKV_TenP(khuVuc, tenPhong);

            string maphong = mp.Rows[0][0].ToString();
            var dsphong = dbPhong.LayPhong_MaP(maphong);
            string tenphong = dsphong.Rows[0][0].ToString();
            string gia = string.Format("{0:#,##0}", Int32.Parse(dsphong.Rows[0][3].ToString()));

            lblMaPhong.Text = maphong; lblMaPhong.ForeColor = Color.Red;
            lblTenPhong.Text = tenphong; lblTenPhong.ForeColor = Color.Red;
            lblGia.Text = gia + " vnd"; lblGia.ForeColor = Color.Red;

            Load_ListKhach(maphong);
        }

        private void Load_ListKhach(string maphong)
        {
            lblGioiHan.Visible =false;
            groupBox1.Enabled = true ;
            var listkhach = dbKhach.LayThongTinKhachQuaMaPhong(maphong);
            lvKhachThue.Items.Clear();
            for (int i = 0; i < listkhach.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(listkhach.Rows[i][0].ToString());
                if (listkhach.Rows[i][2].ToString().Trim() == "Nam") item.ImageIndex = 3;
                else item.ImageIndex = 2;
                item.SubItems.Add(listkhach.Rows[i][1].ToString());
                item.SubItems.Add(listkhach.Rows[i][3].ToString());
                item.SubItems.Add(listkhach.Rows[i][5].ToString());
                lvKhachThue.Items.Add(item);
            }
            lblSoNguoi.Text = listkhach.Rows.Count.ToString();
            if (listkhach.Rows.Count == 4)
            {
                lblGioiHan.Visible = true;
                groupBox1.Enabled = false;
                
            }
        }

        private void ClearAll()
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtCMND.Text = "";
            txtNgheNghiep.Text = "";
            txtQueQuan.Text = "";
            txtTienDatCoc.Text = "";
            cbGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Lay thong tin bang ThongTinKhach
            ho = txtHo.Text.Trim();
            ten = txtTen.Text.Trim();
            ngaysinh = dtpNgaySinh.Value;
            if (cbGioiTinh.SelectedIndex == 0)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            cmnd = txtCMND.Text.Trim();
            quequan = txtQueQuan.Text.Trim();
            nghenghiep = txtNgheNghiep.Text.Trim();
            maphong = lblMaPhong.Text.Trim();
            BLTTThuePhong dbThuePhong = new BLTTThuePhong();
            DateTime ngaythue = dtpNgayThue.Value;

            if (MessageBox.Show("Bạn có muốn lưu?", "Mã khách trọ: " + makhach, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbKhach.ThemKhach( ho+" "+ten, gioitinh, ngaysinh, cmnd, quequan, nghenghiep, maphong);
                //Refresh Form
                ListViewPhong.Items.Clear();
                Load_ListViewPhong();
                ClearAll();
                Load_ListKhach(maphong);
                MessageBox.Show("Đã thêm thành công!");
            }
        }


    }
}
