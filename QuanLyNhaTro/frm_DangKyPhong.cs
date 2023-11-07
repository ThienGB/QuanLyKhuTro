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
    public partial class frm_DangKyPhong : Form
    {
        BLTTDkiPhong bLTTDkiPhong = new BLTTDkiPhong();
        BLKhuVuc bLKhuVuc = new BLKhuVuc();
        BLPhong bLPhong = new BLPhong();
        BLLoaiPhong BLLoaiPhong = new BLLoaiPhong();

        public frm_DangKyPhong()
        {
            InitializeComponent();
        }
        int check;

        private void frmDKPhong_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;

        }
        public void Load_CB_KV()
        {
            cbKhuVuc.DisplayMember = "TenKhuTro";
            cbKhuVuc.ValueMember = "MaKhuTro";
            cbKhuVuc.DataSource = bLKhuVuc.LayKhuVuc();
        }

        public void Load_cb_gia()
        {
            cb_Gia.DisplayMember = "GiaThue";
            cb_Gia.ValueMember = "GiaThue";
            cb_Gia.DataSource = BLLoaiPhong.LayGiaPhong();
        }

        public void Load_cb_DienTich()
        {
            cb_DienTich.DisplayMember = "Dientich";
            cb_DienTich.ValueMember = "Dientich";
            cb_DienTich.DataSource = BLLoaiPhong.LayDienTich();
        }


        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLoaiPhong.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();
            var loaiphong = bLPhong.LayPhongtrong(makv);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][3].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][4].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][5].ToString().TrimEnd());
                item.SubItems.Add(cbKhuVuc.Text);
                lstLoaiPhong.Items.Add(item);
            }
        }

        private void cb_Gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLoaiPhong.Items.Clear();
            string gia = cb_Gia.SelectedValue.ToString();
            var loaiphong = bLPhong.LayPhongtrong_gia(gia);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][8].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][5].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][4].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][6].ToString().TrimEnd());

                lstLoaiPhong.Items.Add(item);
            }
        }

        private void cb_DienTich_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstLoaiPhong.Items.Clear();
            string Dt = cb_DienTich.SelectedValue.ToString();
            var loaiphong = bLPhong.LayPhongtrong_dientich(Dt);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][8].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][5].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][4].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][6].ToString().TrimEnd());
                lstLoaiPhong.Items.Add(item);
            }
        }

        private void lstLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLoaiPhong.SelectedItems.Count == 0)
                return;
            else
            {
                ListViewItem item = lstLoaiPhong.SelectedItems[0];
                lblLoai.Text = item.SubItems[1].Text;
                lblKhuvuc.Text = item.SubItems[4].Text;
                lblGia.Text = item.SubItems[3].Text;
                lblDienTich.Text = item.SubItems[2].Text;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                string ho, ten, cmnd, quequan, nghenghiep;
                DateTime ngaysinh;
                
                ho = txtHo.Text;
                ten = txtTen.Text;
                ngaysinh = dtiNgaySinh.Value;
                cmnd = txtCmnd.Text;
                quequan = txtQuequan.Text;
                nghenghiep = txtNghenghiep.Text;
                //maloaiphong = lstLoaiPhong.SelectedItems[0].Text;
                List<string> lc = new List<string>();
                lc.Add(ho); lc.Add(ten); lc.Add(cmnd); lc.Add(lblKhuvuc.Text); lc.Add(lblLoai.Text); lc.Add(quequan);
                lc.Add(nghenghiep); lc.Add(ngaysinh.ToString()); lc.Add(cbKhuVuc.SelectedItem.ToString());
                foreach (string c in lc)
                {
                    if (c == "")
                    {
                        check = 1;
                    }
                }
                if (check == 1)
                {
                    check = 0;
                    MessageBox.Show("Phải nhập đầy đủ thông tin!");
                }
                else
                {
                    bool dki = bLTTDkiPhong.ThemThongTinDangKy(lstLoaiPhong.SelectedItems[0].Text, ho, ten, cbGioiTinh.SelectedItem.ToString(), ngaysinh, cmnd, quequan, nghenghiep);

                    MessageBox.Show("Đã thêm thành công!");
                }
            }
            catch (FormatException)
            {
                //MessageBox.Show("Phải nhập đầy đủ thông tin!");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtCmnd.Text = "";
            txtQuequan.Text = "";
            txtNghenghiep.Text = "";
        }

        private void frmDKPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            if (comboBox1.SelectedItem.Equals( "Giá"))
            {
                Load_cb_gia();
                cb_Gia.Visible = true;
                cb_DienTich.Visible = false;
                cbKhuVuc.Visible = false;
            }
            else if (comboBox1.SelectedItem.Equals( "Khu Trọ "))
            {
                Load_CB_KV();
                cb_Gia.Visible = false;
                cb_DienTich.Visible = false;
                cbKhuVuc.Visible = true;
            }
            else if (comboBox1.SelectedItem.Equals( "Diện tích "))
            {
                Load_cb_DienTich();
                cb_Gia.Visible = false;
                cb_DienTich.Visible = true;
                cbKhuVuc.Visible = false;
            }
        }
    }
}
