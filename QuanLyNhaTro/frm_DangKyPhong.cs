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
    public partial class frmDangKyPhong : Form
    {
        BLTTDkiPhong bLTTDkiPhong = new BLTTDkiPhong();
        BLKhuVuc bLKhuVuc = new BLKhuVuc();
        BLPhong bLPhong = new BLPhong();

        public frmDangKyPhong()
        {
            InitializeComponent();
        }
        int check;

        private void frmDKPhong_Load(object sender, EventArgs e)
        {
            cbGioiTinh.SelectedIndex = 0;
            Load_CB_KV();
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
            lstLoaiPhong.Items.Clear();
            string makv = cbKhuVuc.SelectedValue.ToString();
            var loaiphong = bLPhong.LayPhongtrong(makv);
            for (int i = 0; i < loaiphong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(loaiphong.Rows[i][0].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][1].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][2].ToString().TrimEnd());
                item.SubItems.Add(loaiphong.Rows[i][3].ToString().TrimEnd());
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
                lblKhuvuc.Text = cbKhuVuc.Text;
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
                string ho, ten, cmnd, quequan, nghenghiep, makhuvuc;
                DateTime ngaysinh;
                var table = bLTTDkiPhong.LayThongTinDangKy();
                table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };
                int id, k;
                for (k = 1; k <= table.Rows.Count; k++)
                {
                    if (table.Rows.Find(k) == null)
                    {
                        break;
                    }
                }
                id = k;
                ho = txtHo.Text;
                ten = txtTen.Text;
                ngaysinh = dtiNgaySinh.Value;
                cmnd = txtCmnd.Text;
                quequan = txtQuequan.Text;
                nghenghiep = txtNghenghiep.Text;
                makhuvuc = cbKhuVuc.SelectedValue.ToString();
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
                    bool dki = bLTTDkiPhong.ThemThongTinDangKy(id, ho, ten, cbGioiTinh.SelectedItem.ToString(), ngaysinh, cmnd, quequan, nghenghiep, makhuvuc, lstLoaiPhong.SelectedItems[0].Text);

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
    }
}
