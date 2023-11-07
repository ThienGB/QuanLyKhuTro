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
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.ValueMember = "MaKhuVuc";
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
            cbChonPhong.ValueMember = "MaLoaiPhong";
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
                string ho, ten, gioitinh, cmnd, quequan, nghenghiep, maphong, ghichu, makhach;
                DateTime ngaysinh;
                //Sinh Ma Khach moi
                
                makhach = bLTTKhach.LayIDMoi();
                //Lay thong tin bang ThongTinKhach
                ho = txtHo.Text.Trim();
                ten = txtTen.Text.Trim();
                ngaysinh = dtpNgaySinh.Value;
                gioitinh = cbGioiTinh.SelectedItem.ToString();
                cmnd = txtCMND.Text.Trim();
                quequan = txtQueQuan.Text.Trim();
                nghenghiep = txtNgheNghiep.Text.Trim();
                maphong = lblMaphong.Text.Trim();
                ghichu = "1";
                List<string> tmp = new List<string>();
                tmp.Add(ho);
                tmp.Add(ten);
                tmp.Add(gioitinh);
                tmp.Add(nghenghiep);
                tmp.Add(quequan);
                tmp.Add(cmnd);
                tmp.Add(txtTienDatCoc.Text);
                foreach (string chuoi in tmp)
                {
                    if (chuoi == "")
                    {
                        kiemtra = 1;
                    }
                }
                if (kiemtra == 1)
                {
                    MessageBox.Show("Quý khách phải nhập đủ thông tin!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu?", "Mã khách trọ: " + makhach, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Them vao bang ThongTinKhach               
                        bool themKhach = bLTTKhach.ThemKhach(ho, gioitinh, cmnd, quequan, nghenghiep, maphong, ngaysinh);
                        if (themKhach)
                        {
                            //Them vao bang ThongTinThuePhong
                            //Lay thong tin
                            string idtttp = bLTTThuePhong.LayIDMoi().ToString();
                            string select_maphong = lblMaphong.Text;
                            DateTime ngaythue = dtpNgayThue.Value;
                            tiendatcoc = Convert.ToInt32(txtTienDatCoc.Text);

                            //INSERT vao bang
                            bool themTTThue = bLTTThuePhong.ThemThongTinThue(idtttp, makhach, maphong, ngaythue, tiendatcoc);

                            //Cap nhat trang thai phong
                            bLPhong.UpdateTrangThai(select_maphong, "Đã thuê");


                            //Xoa Khach tu DS Dang Ky
                            if (radDSDK.Checked == true)
                            {
                                ListViewItem item = listKDK.SelectedItems[0];
                                int id_kdk = Convert.ToInt32(item.Text);
                                bool xoa = bLTTDkiPhong.Xoa(id_kdk);
                            }


                            //Refresh Form
                            lvPhong.Items.Clear();
                            LoadData_ListPhong();
                            Load_ListKDK();
                            MessageBox.Show("Đã thêm thành công!");
                        }
                        else MessageBox.Show("Không thể thêm ");
                    }
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
            tmp.Add(txtCMND); tmp.Add(txtHo); tmp.Add(txtNgheNghiep); tmp.Add(txtQueQuan); tmp.Add(txtTen); tmp.Add(txtTienDatCoc);
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
            string id = item.Text;            
            var khachdk = bLTTDkiPhong.LayThongTinQuaID(Convert.ToInt32(id));

            txtHo.Text = khachdk.Rows[0][1].ToString();
            txtTen.Text = khachdk.Rows[0][2].ToString();
            cbGioiTinh.Text = khachdk.Rows[0][3].ToString();
            dtpNgaySinh.Text = khachdk.Rows[0][4].ToString();
            txtCMND.Text = khachdk.Rows[0][5].ToString();
            txtQueQuan.Text = khachdk.Rows[0][6].ToString();
            txtNgheNghiep.Text = khachdk.Rows[0][7].ToString();

            string maloaiphong = khachdk.Rows[0][9].ToString();
            var tenphong = bLTTDkiPhong.LayTenLoaiPhong( maloaiphong );
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
    }
}
