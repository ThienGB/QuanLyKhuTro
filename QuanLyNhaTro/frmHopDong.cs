using QuanLyNhaTro.BS_layer;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class frmHopDong : UserControl
    {
        private int tiendatcoc;

        BLTTKhach dbKhach = new BLTTKhach();
        BLHopDong dbHopDong = new BLHopDong();
//        BLKhuVuc dbKhuVuc=new BLKhuVuc();

        public frmHopDong()
        {
            InitializeComponent();
            
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            LoadListHopDong();
            //Load_CBKV();
        }

/*        private void Load_CBKV()
        {
            var kv = dbKhuVuc.LayKhuVuc();
            cbKhuVuc.ValueMember = "MaKhuVuc";
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.DataSource = kv;
        }*/

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListHopDong();
        }
        public void HienThiDuLieuLenListView(DataTable dt, ListView listView)
        {
            listView.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["MaPhong"].ToString()); // Giả sử cột "MaPhong" trong DataTable
                item.SubItems.Add(row["MaPhong"].ToString()); // Giả sử cột "TenPhong" trong DataTable
                item.SubItems.Add(row["MaKT"].ToString()); // Giả sử cột "MaLoaiPhong" trong DataTable
                item.SubItems.Add(row["TienDatCoc"].ToString()); // Giả sử cột "Day" trong DataTable
                item.SubItems.Add(row["NgayBatDau"].ToString()); // Giả sử cột "Day" trong DataTable
                item.SubItems.Add(row["NgayKetThuc"].ToString()); // Giả sử cột "Day" trong DataTable


                listView.Items.Add(item); // Thêm mục vào ListView
            }
        }

        private void LoadListHopDong()
        {
            lvHopDong.Items.Clear();
         //   string makv = cbKhuVuc.SelectedValue.ToString();

            var data = dbHopDong.LayHopDong();
            HienThiDuLieuLenListView(data, lvHopDong);
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadKhachDau(string maKT)
        {
            var data = dbKhach.LayThongTinKhach_DungMaKT(maKT);
            txtHo.Text = data.Rows[0][2].ToString();
 
            dtpNgaySinh.Text = data.Rows[0][7].ToString();
            cbGioiTinh.Text = data.Rows[0][3].ToString();
            txtCMND.Text = data.Rows[0][6].ToString();
            txtQueQuan.Text = data.Rows[0][5].ToString();
            txtNgheNghiep.Text = data.Rows[0][4].ToString();
            lblMaKhach.Text = data.Rows[0][0].ToString();

 
           
   
        }


        private void ClearAll()
        {
            dtpNgaySinh.Value = DateTime.Today;
            txtHo.Text = "";

            txtCMND.Text = "";
            cbGioiTinh.Text = ""; 
            txtNgheNghiep.Text = "";
            txtMaPhong.Text = "";
            txtQueQuan.Text = "";

        }

     
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

   
        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a = lvHopDong.SelectedItems[0];
            string maKT = a.SubItems[2].Text;
            LoadKhachDau(maKT);
 
            txtMaPhong.Text = (lvHopDong.SelectedItems[0]).Text;
 


            txtTienCoc.Text =  (lvHopDong.SelectedItems[0].SubItems[3]).Text;
           
        }
    }
}
