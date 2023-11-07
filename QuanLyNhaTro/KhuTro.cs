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
    public partial class KhuVuc : UserControl
    {
        bool Them;
        BLKhuVuc dbKT = new BLKhuVuc();
        public KhuVuc()
        {
            InitializeComponent();
        }

        private void KhuVuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            groupBox2.Enabled = true;
            this.txtMKT.ResetText();
            this.txtTKT.ResetText();
            this.txtDiaChi.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMKT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            groupBox2.Enabled = true;
            dgvDSKT_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMKT.Enabled = false;
            this.txtTKT.Focus();
            this.txtMKT.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvDSKT.CurrentCell.RowIndex;
                string MaLoaiPhong = dgvDSKT.Rows[current].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbKT.XoaKhuTro(MaLoaiPhong);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if (Them)
            {
                try
                {
                    dbKT.ThemKhuTro(this.txtTKT.Text, this.txtDiaChi.Text);
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
                dbKT.SuaKhuTro(this.txtMKT.Text, this.txtTKT.Text, this.txtDiaChi.Text);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMKT.ResetText();
            groupBox2.Enabled = false;
            this.txtTKT.ResetText();
            this.txtDiaChi.ResetText();
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            dgvDSKT_CellClick(null, null);
        }

        private void dgvDSKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvDSKT.CurrentCell.RowIndex;
            this.txtMKT.Text = dgvDSKT.Rows[current].Cells[0].Value.ToString();
            this.txtTKT.Text = dgvDSKT.Rows[current].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvDSKT.Rows[current].Cells[2].Value.ToString();
        }
        void LoadData()
        {
            try
            {
                dgvDSKT.DataSource = dbKT.LayKhuTro();
                dgvDSKT.AutoResizeColumns();
                this.txtMKT.ResetText();
                this.txtTKT.ResetText();
                this.txtDiaChi.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                dgvDSKT_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table KhuTro. Lỗi rồi!!!");
            }
        }
    }
}