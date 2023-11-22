using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int  tiendien, tiennuoc2;
        public TinhTien()
        {
            InitializeComponent();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {
            
            Load_CBKV();
            lvPhong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            txtMoiTruong.Enabled = true;
        }

        private void Load_CBKV()
        {
            var kv = dbkv.LayKhuVuc();
            cbKhuVuc.ValueMember = "MaKhuTro";
            cbKhuVuc.DisplayMember = "TenKhuTro";
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
            cbMaKhachThue.ValueMember = "MaKT";
            cbMaKhachThue.DataSource = khach;

            //Load Thong Tin Dich Vu
            var dichvu = dbphong.LayPhong_MaP(maphong);

            
        }

        private void cbMaKhachThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load chi tiet thong tin khach
            string makhach = cbMaKhachThue.SelectedValue.ToString();
            var thongtinkhach = dbttkhach.LayThongTinKhachQuaID(makhach);

            txtCMND.Text = thongtinkhach.Rows[0][6].ToString();
            txtNN.Text = thongtinkhach.Rows[0][4].ToString();
            txtNS.Text = thongtinkhach.Rows[0][5].ToString();
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
            
            var dichvu = dbdv.LoadTienDichVu("sonuoc");
            string str_soki = txtSoKi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][2].ToString());
            if (txtSoKi.Text != "")
                soki = Convert.ToInt32(str_soki);
            //Tinh
            tiendien = soki * gia;
            //Xuat
            txtDien.Text = string.Format("{0:#,##0}", Int32.Parse(tiendien.ToString()));
        }

        private void dtLapHoaDon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            Load_CBKV();
        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoKhoi_TextChanged(object sender, EventArgs e)
        {
            int sokhoi = 0;
            //Load tien dich vu
            var dichvu = dbdv.LoadTienDichVu("sodien");
            string str_sokhoi = txtSoKhoi.Text;
            int gia = Convert.ToInt32(dichvu.Rows[0][2].ToString());
            if (txtSoKhoi.Text != "")
                sokhoi = Convert.ToInt32(str_sokhoi);
            //Tinh            
            tiennuoc2 = sokhoi * gia;
            //Xuat
            txtNuoc.Text = string.Format("{0:#,##0}", Int32.Parse(tiennuoc2.ToString()));
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = dtLapHoaDon.Value;
            int sokidien = Convert.ToInt32(txtSoKi.Text);
            int sonuoc = Convert.ToInt32(txtSoKhoi.Text);
            int phiMT= Convert.ToInt32(txtMoiTruong.Text);
            string maphong = txtMaPhong.Text;
            if (MessageBox.Show("Thời gian lập hóa đơn: \n" + ngaylap.ToString() + "\nMã Phòng: " + maphong, "Xác nhận lập hóa đơn: " , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Insert vao bang phieu thu
                bool i = dbpt.ThemPhieuThu(maphong,phiMT,sokidien,sonuoc);
                if (i == true)
                    MessageBox.Show("Lập hóa đơn thành công");
            }
            var pt = dbpt.LayPhieuThuTheoMaPhong(maphong);
            txt_TienDien.Text=string.Format("{0:#,##0}", txtDien.Text);
            txtTienMT.Text =  string.Format("{0:#,##0}", txtMoiTruong.Text);
            txtTienNuoc.Text =  string.Format("{0:#,##0}", txtNuoc.Text);
            txtTienNha.Text =   string.Format("{0:#,##0}", pt.Rows[0][7].ToString());
            txtTongCong.Text= string.Format("{0:#,##0}", pt.Rows[0][8].ToString());
            txtTienDV.Text = string.Format("{0:#,##0}", pt.Rows[0][5].ToString());
        }

        private void ClearAll()
        {
            txtTenPhong.Text = "";
            txtTienNuoc.Text = "";
            txtTienDV.Text = "";
            txtTienMT.Text = "";
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            dtNgayThue.Value = DateTime.Today;
            txtSoluong.Text = "";
            cbMaKhachThue.Text = "";
            txtCMND.Text = "";
            txtNN.Text = "";
            txtNS.Text = "";
            txtTienNha.Text = "";
            txtSoKi.Text = "";
            txtDien.Text = "";
            txtSoKhoi.Text = "";
            txtNuoc.Text = ""; txtTongCong.Text = "";
        }
    }
}