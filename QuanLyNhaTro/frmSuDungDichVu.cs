using QuanLyNhaTro.BS_layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class frmSuDungDichVu : UserControl
    {
        private int tiendatcoc;
        BLDichVu dbdichvu=new BLDichVu();


        public frmSuDungDichVu()
        {
            InitializeComponent();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            unactive_input();
        }
        private void unactive_input() {
            txtMaDV.Enabled = false;
            txtPhong.Enabled = false;
            txtSoLuong.Enabled = false;
        }
        private void active_input()
        {
            txtMaDV.Enabled = true;
            txtPhong.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        public void HienThiDuLieuLen_DichVu(DataTable dt, ListView listView)
        {
            listView.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDV"].ToString()); // Giả sử cột "MaPhong" trong DataTable
                item.SubItems.Add(row["TenDichVu"].ToString()); // Giả sử cột "TenPhong" trong DataTable
                item.SubItems.Add(row["GiaTien"].ToString()); // Giả sử cột "MaLoaiPhong" trong DataTable

                listView.Items.Add(item); // Thêm mục vào ListView
            }
        }

        private void LoadListPhong()
        {
            lvDichVu.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();
            
            var data = dbPhong.LayPhongDaThue_MaKV(makv);
            HienThiDuLieuLenListView(data, lvSuDungDV);
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            lvDichVu.Items.Clear();
            ListViewItem a = lvSuDungDV.SelectedItems[0];
            string maphong = a.Text;
            string id;
            var data = dbKhach.LayThongTinKhachQuaMaPhong(maphong);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                item.SubItems.Add(data.Rows[i][1].ToString()+" "+ data.Rows[i][2].ToString());
                item.SubItems.Add(data.Rows[i][3].ToString());
                item.SubItems.Add(data.Rows[i][6].ToString());
                lvDichVu.Items.Add(item);
            }
            id = data.Rows[0][0].ToString();
            LoadKhachDau(id);
        }

        private void LoadKhachDau(string id)
        {
            var data = dbKhach.LayThongTinKhachQuaID(id);
            txtPhong.Text = data.Rows[0][1].ToString();
            txtTen.Text = data.Rows[0][2].ToString();
            dtpNgaySinh.Text = data.Rows[0][5].ToString();
            cbGioiTinh.Text = data.Rows[0][3].ToString();
            txtCMND.Text = data.Rows[0][6].ToString();
            txtQueQuan.Text = data.Rows[0][7].ToString();
            txtNgheNghiep.Text = data.Rows[0][8].ToString();
            lblMaKhach.Text = data.Rows[0][0].ToString();

            var dataThuePhong = dbThuePhong.LayThongTinThue();
            lblMaHopDong.Text = dataThuePhong.Rows[0][0].ToString();
            txtMaPhong.Text = dataThuePhong.Rows[0][2].ToString();
            dtpNgayThue.Text = dataThuePhong.Rows[0][3].ToString();
            int result = 0;
            bool isSuccess = int.TryParse(dataThuePhong.Rows[0][4].ToString(), out result);
            if (isSuccess)
            {
                tiendatcoc = Convert.ToInt32(dataThuePhong.Rows[0][4].ToString());
            }
            else
            {
                tiendatcoc = result;
            }
            txtTienDatCoc.Text = string.Format("{0:#,##0}", tiendatcoc);
        }

        private void lvKhach_Click(object sender, EventArgs e)
        {
            ListViewItem a = lvDichVu.SelectedItems[0];
            string makhach = a.Text;
            LoadKhachDau(makhach);
        }

        private void ClearAll()
        {
            dtpNgaySinh.Value = DateTime.Today;
            txtPhong.Text = "";
            txtTen.Text = "";
            txtCMND.Text = "";
            cbGioiTinh.Text = "";
            txtNgheNghiep.Text = "";
            txtMaPhong.Text = "";
            txtQueQuan.Text = "";
            txtTienDatCoc.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string maphong = txtMaPhong.Text;
            string maHopDong = lblMaHopDong.Text;
            int id = dbThuePhong.LayIDMoi();
            DateTime ngaythue, ngaytra;
            ngaythue = dtpNgayThue.Value;
            ngaytra = dtpNgayTra.Value;
            string maKhach = lblMaKhach.Text;
            string str_tdc = string.Format("{0:#,##0}", tiendatcoc);

            if (MessageBox.Show("Ngày thuê: " + dtpNgayThue.Text.ToString() + "\nTiền đặt cọc: " + str_tdc + " vnd", "Xác nhận trả phòng: " + maphong, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool a= dbThuePhong.TraPhong(maphong);
                bool b= dbPhong.UpdateTrangThai(maphong,"Trống");
                bool c = dbKhach.TraPhong(maphong);
                

                //Refresh
                LoadListPhong();
                ClearAll();
                lvDichVu.Items.Clear();
            }

        }

        private void lvKhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
