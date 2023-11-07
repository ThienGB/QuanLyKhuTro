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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyNhaTro.FrmMain
{
    public partial class ChoThue : UserControl
    {
        BLPhong bLPhong = new BLPhong();
        BLKhuVuc bLKhuVuc = new BLKhuVuc();
        BLTTDkiPhong bLTTDkiPhong = new BLTTDkiPhong();
        BLTTKhach bLTTKhach = new BLTTKhach();
        BLTTThuePhong bLTTThuePhong = new BLTTThuePhong();
        BLDangNhap blTaiKhoan= new BLDangNhap();

        string madon;
        int kiemtra;
        private int tiendatcoc;
        public ChoThue()
        {
            InitializeComponent();
        }

        private void ChoThue_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            Load_CB_KV();
            Load_CBLoaiPhong();
            lvPhong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);          
        }

        public void Load_CB_KV()
        {
            //Load ComboBox Khu Vuc
            cbKhuVuc.DisplayMember = "TenKhuTro";
            cbKhuVuc.ValueMember = "MaKhuTro";
            cbKhuVuc.DataSource = bLKhuVuc.LayKhuVuc();
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            Load_CBLoaiPhong();
            Load_ListKDK();
        }

        private void Load_CBLoaiPhong()
        {
            var loaiphong = bLPhong.LayLoaiPhong();
            cbChonPhong.ValueMember = "MaLP";
            cbChonPhong.DisplayMember = "TenLoaiPhong";
            cbChonPhong.DataSource = loaiphong;
        }

        private void Load_ListKDK()
        {
            listKDK.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();
            var khachdk = bLTTDkiPhong.LayThongTinQuaMaKhuVuc( makv ); 

            for (int i = 0; i < khachdk.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(khachdk.Rows[i][0].ToString());
                if (khachdk.Rows[i][3].ToString().Trim() == "Nam") item.ImageIndex = 3; else item.ImageIndex = 2;
                item.SubItems.Add(khachdk.Rows[i][1].ToString() + " " + khachdk.Rows[i][2].ToString());
                listKDK.Items.Add(item);
            }
        }

        private void LoadData_ListPhong()
        {
            string khuvuc = cbKhuVuc.SelectedValue.ToString();
            string loaiphong = cbChonPhong.SelectedValue.ToString();
            var phong = bLPhong.LayPhongtrong(khuvuc,loaiphong);

            for (int i = 0; i < phong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(phong.Rows[i][3].ToString());
                item.SubItems.Add(phong.Rows[i][0].ToString());
                item.ImageIndex = 0;
                lvPhong.Items.Add(item);
            }
        }

        private void cbChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPhong.Items.Clear();
            LoadData_ListPhong();
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            string kv = cbKhuVuc.SelectedValue.ToString();
            string tp = lvPhong.SelectedItems[0].Text;
            var mp = bLPhong.LayPhongtrong_MaKV_TenP(kv,tp);

            
            string maphong = mp.Rows[0][0].ToString();
            var dsphong = bLPhong.LayPhong_MaP(maphong);
            string tenphong = dsphong.Rows[0][0].ToString();
            string gia = string.Format("{0:#,##0}", Int32.Parse(dsphong.Rows[0][3].ToString()));
            lblMaphong.Text = maphong; lblMaphong.ForeColor = Color.Red;
            lblTenPhong.Text = tenphong; lblTenPhong.ForeColor = Color.Red;
            lblGia.Text = gia + " vnd"; lblGia.ForeColor = Color.Red;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten, gioitinh, cmnd, quequan, nghenghiep, maphong, makhach;
                DateTime ngaysinh;
                //Sinh Ma Khach moi
                
                //Lay thong tin bang ThongTinKhach
                hoten = txtHo.Text.Trim();
                ngaysinh = dtpNgaySinh.Value;
                gioitinh = cbGioiTinh.SelectedItem.ToString();
                cmnd = txtCMND.Text.Trim();
                quequan = txtQueQuan.Text.Trim();
                nghenghiep = txtNgheNghiep.Text.Trim();
                maphong = lblMaphong.Text.Trim();
                tiendatcoc = Convert.ToInt32(txtTienDatCoc.Text);
               
               
                {
                    if (MessageBox.Show("Bạn có muốn lưu?", "Khách "+hoten , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (rdnTuNhap.Checked)
                        {
                            bLTTKhach.ThemKhach( hoten, gioitinh, ngaysinh, cmnd, quequan, nghenghiep, maphong);

                            DataTable Kt= bLTTKhach.LayMaKT_CMND(cmnd);
                            string makt = Kt.Rows[0][0].ToString();
                            //Thêm vào HOP_DONG 
                            bLTTThuePhong.ThemThongTinThue(makt,maphong,DateTime.Now,tiendatcoc);

                            //Thêm vào Tai_KHOAN

                            blTaiKhoan.InsertTaiKhoan(cmnd, maphong,makt);
                            //Cập nhật lại PHONG_TRO 
                            bLPhong.UpdateTrangThai(maphong,"Đã thuê");

                            lvPhong.Items.Clear();
                            LoadData_ListPhong();
                            Load_ListKDK();
                            MessageBox.Show("Đã thêm thành công!     Tài khoản :"+cmnd+ "     Mật khẩu : "+ maphong);
                        }            
                        
                        else if (radDSDK.Checked)
                        {
                            textBox1.Text = madon;
                            bLTTDkiPhong.updateTrangThaiDangKy(madon);
                            //Refresh Form
                            lvPhong.Items.Clear();
                            LoadData_ListPhong();
                            Load_ListKDK();
                            MessageBox.Show("Đã thêm thành công!       Tài khoản: "+cmnd+ "     Mật khẩu: "+ maphong);
                        }
                        

                       
                    }
                    else MessageBox.Show("Không thể thêm ");
                }
            }
            catch (FormatException)
            {

            }
        }

        // Nút Clear
        private void ClearAll()
        {
            dtpNgaySinh.Value = DateTime.Today;
            List<TextBox> tmp = new List<TextBox>();
            tmp.Add(txtCMND); tmp.Add(txtHo); tmp.Add(txtNgheNghiep); tmp.Add(txtQueQuan); tmp.Add(txtTienDatCoc);
            foreach (TextBox txtbox in tmp)
            {
                txtbox.Text = "";
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void listKDK_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            ListViewItem item = listKDK.SelectedItems[0];
            string id =madon= item.Text;
            var khachdk = bLTTDkiPhong.LayThongTinQuaID(Convert.ToInt32(id));

            txtHo.Text = khachdk.Rows[0][2].ToString();
            cbGioiTinh.Text = khachdk.Rows[0][3].ToString();
            dtpNgaySinh.Text = khachdk.Rows[0][4].ToString();
            txtCMND.Text = khachdk.Rows[0][5].ToString();
            txtQueQuan.Text = khachdk.Rows[0][6].ToString();
            txtNgheNghiep.Text = khachdk.Rows[0][7].ToString();

            string maphong = khachdk.Rows[0][1].ToString();
            var tenphong = bLTTDkiPhong.LayTenLoaiPhong( maphong );
            lblKhachChon.Text = tenphong.Rows[0][0].ToString();
        }

        private void radDSDK_CheckedChanged(object sender, EventArgs e)
        {
            if (radDSDK.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
                groupBox2.Enabled = false;
        }

        private void rdnTuNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnTuNhap.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled=false;
                ClearAll();
            }
            else
                groupBox1.Enabled = false;
        }

        private void listKDK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
