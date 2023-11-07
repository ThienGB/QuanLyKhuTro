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
    public partial class QLLoaiPhong : Form
    {
        bool Them;
        BLLoaiPhong dbLP = new BLLoaiPhong();

        public QLLoaiPhong()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvQLLP.DataSource = dbLP.LayLoaiPhong();
                dgvQLLP.AutoResizeColumns();
                this.txtMLP.ResetText();
                this.txtTLP.ResetText();
                this.txtDT.ResetText();
                this.txtGia.ResetText();
                this.txtGhiChu.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                dgvQLLP_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table LoaiPhong. Lỗi rồi!!!");
            }
        }

        private void QLLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            groupBox2.Enabled = true;
            this.txtMLP.ResetText();
            this.txtTLP.ResetText();
            this.txtDT.ResetText();
            this.txtGia.ResetText();
            this.txtGhiChu.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMLP.Enabled = true;
            this.txtMLP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            groupBox2.Enabled = true;
            dgvQLLP_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMLP.Enabled = false;
            this.txtTLP.Focus();
            this.txtMLP.Enabled = true;

        }

        private void dgvQLLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvQLLP.CurrentCell.RowIndex;
            this.txtMLP.Text = dgvQLLP.Rows[current].Cells[0].Value.ToString();
            this.txtTLP.Text = dgvQLLP.Rows[current].Cells[1].Value.ToString();
            this.txtDT.Text = dgvQLLP.Rows[current].Cells[2].Value.ToString();
            this.txtGia.Text = dgvQLLP.Rows[current].Cells[3].Value.ToString();
            this.txtGhiChu.Text = dgvQLLP.Rows[current].Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMLP.ResetText();
            groupBox2.Enabled = false;
            this.txtTLP.ResetText();
            this.txtDT.ResetText();
            this.txtGia.ResetText();
            this.txtGhiChu.ResetText();
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            dgvQLLP_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if (Them)
            {
                try
                {
                    int DienTich = int.Parse(this.txtDT.Text);
                    int Gia = int.Parse(this.txtGia.Text);
                    dbLP.ThemLoaiPhong(this.txtMLP.Text, this.txtTLP.Text, DienTich, Gia);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                int  DienTich = int.Parse(this.txtDT.Text);
                int Gia = int.Parse(this.txtGia.Text); ;
                dbLP.CapNhatLoaiPhong(this.txtMLP.Text, this.txtTLP.Text, DienTich, Gia);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvQLLP.CurrentCell.RowIndex;
                string MaLoaiPhong = dgvQLLP.Rows[current].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbLP.XoaLoaiPhong(MaLoaiPhong);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }
      
    }
}
