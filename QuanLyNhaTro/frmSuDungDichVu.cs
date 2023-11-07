using QuanLyNhaTro.BS_layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class frmSuDungDichVu : UserControl
    {
        bool Them;
        private int tiendatcoc;
        BLDichVu dbdichvu=new BLDichVu();
        BLPhong dbphong=new BLPhong();

        public frmSuDungDichVu()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;

        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            unactive_input();

            LoadListSDDichVu();
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


        public void HienThiDuLieuLen_SDDichVu(DataTable dt, ListView listView)
        {
            listView.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaDv"].ToString()); // Giả sử cột "MaPhong" trong DataTable
                item.SubItems.Add(row["MaPhong"].ToString()); // Giả sử cột "TenPhong" trong DataTable
                item.SubItems.Add(row["SoLuong"].ToString()); // Giả sử cột "MaLoaiPhong" trong DataTable
                listView.Items.Add(item); // Thêm mục vào ListView
            }
        }


        private void LoadListSDDichVu()
        {
            lvSuDungDV.Items.Clear();
            var data = dbdichvu.ViewSuDungDichVu();
            HienThiDuLieuLen_SDDichVu(data, lvSuDungDV);
        }
        /*
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
                }*/

/*        private void LoadBangDKDichVu(string maDV)
        {
            ClearAll();
            unactive_input();
            txtMaDV.Text = maDV;


        }*/

/*        private void lvKhach_Click(object sender, EventArgs e)
        {
            ListViewItem a = lvDichVu.SelectedItems[0];
            string makhach = a.Text;
            LoadKhachDau(makhach);
        }*/

        private void ClearAll()
        {
            txtMaDV.Text = "";
            txtPhong.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Them = true;
            ClearAll();
            active_input();
            this.txtMaDV.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }



        private void lvSuDungDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a =lvSuDungDV.SelectedItems[0];
            string maDV = a.Text;
            ClearAll();
            txtMaDV.Text = maDV;
            txtPhong.Text= a.SubItems[1].Text;
            txtSoLuong.Text = a.SubItems[2].Text;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            active_input();
            this.txtMaDV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Them = false;
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dbdichvu.DeleteSuDungDichVu(txtMaDV.Text,txtPhong.Text);
                LoadListSDDichVu();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    dbdichvu.InsertSuDungDichVu(txtMaDV.Text, txtPhong.Text, txtSoLuong.Text);
                    LoadListSDDichVu();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                dbdichvu.UpdateSuDungDichVu(txtMaDV.Text, txtPhong.Text, txtSoLuong.Text);
                LoadListSDDichVu();
                MessageBox.Show("Đã sửa xong!");
            }
            ClearAll();

        }
    }
}
