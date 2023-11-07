using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.BS_layer;

namespace QuanLyNhaTro
{
    public partial class TinhTien : UserControl
    {
        BLKhuVuc dbkv = new BLKhuVuc();
        BLPhong dbphong = new BLPhong();
        BLTTKhach dbttkhach = new BLTTKhach();
        BLDichVu dbdv = new BLDichVu();
        BLPhieuThu dbpt = new BLPhieuThu();
        private int tiennha, tiendien, tiennuoc, tiennuoc2, tongtien;
        public TinhTien()
        {
            InitializeComponent();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {
            
            Load_CBKV();
            lvPhong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Load_CBKV()
        {
            var kv = dbkv.LayKhuVuc();
            cbKhuVuc.ValueMember = "MaKhuVuc";
            cbKhuVuc.DisplayMember = "TenKhuVuc";
            cbKhuVuc.DataSource = kv;
        }

        //Load Phòng chưa lập hóa đơn
        private void load_phong()
        {
            lvPhong.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();
            int thismonth = DateTime.Now.Month;
            int thisyear = DateTime.Now.Year;
            var phong =dbphong.LayPhongChuaLapHD(makv, thismonth , thisyear);

            for (int i = 0; i < phong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(phong.Rows[i][3].ToString());
                item.ImageIndex = 1 ;
                lvPhong.Items.Add(item);
            }

            lblHD.Text = "Lập hóa đơn tháng " + thismonth;
        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_phong();
        }

        private void lvPhong_Click(object sender, EventArgs e)
        {
            //Lay ma phong chon tu list
            string kv = cbKhuVuc.SelectedValue.ToString();
            string tp = lvPhong.SelectedItems[0].Text;
            
            var mp = dbphong.LayMaPhong(tp, kv);

            //Load Thong Tin Phong Thue
            string maphong = mp.Rows[0][0].ToString();
            var phong = dbphong.LayP_dathue_TTThue(maphong);

            txtMaPhong.Text = maphong;
            txtTenPhong.Text = phong.Rows[0][1].ToString();
            string ngay = phong.Rows[0][2].ToString();
            dtNgayThue.Text = ngay;

            //Load Thong Tin Chu Thue
            var khach = dbttkhach.LayThongTinKhach_ThongTinThue(maphong);

            //combobox Ten Chu Thue
            txtSoluong.Text = khach.Rows.Count.ToString();
            cbMaKhachThue.DisplayMember = "HoTen";
            cbMaKhachThue.ValueMember = "MaKhachTro";
            cbMaKhachThue.DataSource = khach;

            //Load Thong Tin Dich Vu
            var dichvu = dbphong.LayPhong_MaP(maphong);

            txtLoaiPhong.Text = dichvu.Rows[0][1].ToString();
            tiennha = Convert.ToInt32(dichvu.Rows[0][3].ToString());
            string gia = string.Format("{0:#,##0}", Int32.Parse(dichvu.Rows[0][3].ToString()));
            txtTienNha.Text = gia;
        }

        private void cbMaKhachThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load chi tiet thong tin khach
            string makhach = cbMaKhachThue.SelectedValue.ToString();
            var thongtinkhach = dbttkhach.LayThongTinKhachQuaID(makhach);

            txtCMND.Text = thongtinkhach.Rows[0][6].ToString();
            txtNN.Text = thongtinkhach.Rows[0][8].ToString();
            txtNS.Text = thongtinkhach.Rows[0][7   ].ToString();
        }

        private void rdNuoc_CheckedChanged(object sender, EventArgs e)
        {
            pSoNguoi.Visible = false;
        }

        private void rdSoNguoi_CheckedChanged(object sender, EventArgs e)
        {

            pSoNguoi.Visible = true;
            if (rdSoNguoi.Checked)
            {
                int songuoi = 0;
                //Load tien dich vu
                var dichvu = dbdv.LoadTienDichVu("Nước_2");
                txtSoNguoi.Text = txtSoluong.Text;
                string str_songuoi = txtSoNguoi.Text;
                int gia = Convert.ToInt32(dichvu.Rows[0][2].ToString());
                if (txtSoNguoi.Text != "")
                    songuoi = Convert.ToInt32(str_songuoi);
                //Tinh
                tiennuoc = songuoi * gia;
                //Xuat
                txtTienNuoc2.Text = string.Format("{0:#,##0}", Int32.Parse(tiennuoc.ToString()));
            }
        }

        private void Dien_cbSoKi_CheckedChanged(object sender, EventArgs e)
        {
            if (Dien_cbSoKi.Checked)
                txtSoKi.Enabled = true;
            else
                txtSoKi.Enabled = false;
        }

        private void nuoc_cbSoKhoi_CheckedChanged(object sender, EventArgs e)
        {
            if (nuoc_cbSoKhoi.Checked)
                txtSoKhoi.Enabled = true;
            else
                txtSoKhoi.Enabled = false;
        }

        private void txtSoKi_TextChanged(object sender, EventArgs e)
        {
            int soki = 0;
            //Load tien dich vu
            
            var dichvu = dbdv.LoadTienDichVu("Điện");
            string str_soki = txtSoKi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][2].ToString());
            if (txtSoKi.Text != "")
                soki = Convert.ToInt32(str_soki);
            //Tinh
            tiendien = soki * gia;
            //Xuat
            txtTienDien2.Text = string.Format("{0:#,##0}", Int32.Parse(tiendien.ToString()));

        }


        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoKhoi_TextChanged(object sender, EventArgs e)
        {
            int sokhoi = 0;
            //Load tien dich vu
            var dichvu = dbdv.LoadTienDichVu("Nước");
            string str_sokhoi = txtSoKhoi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][2].ToString());
            if (txtSoKhoi.Text != "")
                sokhoi = Convert.ToInt32(str_sokhoi);
            //Tinh            
            tiennuoc2 = sokhoi * gia;
            //Xuat
            txtTienNuoc.Text = string.Format("{0:#,##0}", Int32.Parse(tiennuoc2.ToString()));
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (rdNuoc.Checked)
            {
                tongtien = tiennha + tiendien + tiennuoc2;
                txtTongCong.Text = string.Format("{0:#,##0}", Int32.Parse(tongtien.ToString())) + " vnd";
            }
            else
            {
                tongtien = tiennha + tiendien + tiennuoc;
                txtTongCong.Text = string.Format("{0:#,##0}", Int32.Parse(tongtien.ToString())) + " vnd";
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            //Lay du lieu bang phieu thu
            double idPT = dbpt.LayIDMoi();
            string maphong = txtMaPhong.Text;
            DateTime ngaylap = dtLapHoaDon.Value;
            DateTime ngaythu = DateTime.MinValue; 
            int sokidien = Convert.ToInt32(txtSoKi.Text);
            int PT_tiennuoc, sokhoinuoc;
            if (rdNuoc.Checked)
            {
                sokhoinuoc = Convert.ToInt32(txtSoKhoi.Text);
                PT_tiennuoc = tiennuoc2;
            }
            else
            {
                sokhoinuoc = 0;
                PT_tiennuoc = tiennuoc;
            }

            //Xac Nhan
            if (MessageBox.Show("Thời gian lập hóa đơn: \n" + ngaylap.ToString() + "\nMã Phòng: " + maphong, "Xác nhận lập hóa đơn: " + idPT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Insert vao bang phieu thu
                bool i = dbpt.ThemPhieuThu(idPT, maphong, ngaylap, ngaythu, tiennha, sokidien, tiendien, sokhoinuoc, PT_tiennuoc, tongtien);
                if (i == true)
                    MessageBox.Show("Lập hóa đơn thành công");
                

            }
            //Refresh
            load_phong();
            ClearAll();
        }

        private void ClearAll()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            dtNgayThue.Value = DateTime.Today;
            txtSoluong.Text = "";
            cbMaKhachThue.Text = "";
            txtCMND.Text = "";
            txtNN.Text = "";
            txtNS.Text = "";
            txtLoaiPhong.Text = "";
            txtTienNha.Text = "";
            txtSoKi.Text = "";
            txtTienDien2.Text = "";
            txtSoKhoi.Text = "";
            txtTienNuoc.Text = ""; txtTienNuoc2.Text = ""; txtSoNguoi.Text = ""; txtTongCong.Text = "";
            rdNuoc.Checked = true;
        }
    }
}