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
    public partial class QLPhongTro : Form
    {
        bool Them;
        BLPhong dbPhong = new BLPhong();

        public QLPhongTro()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvQLPT.DataSource = dbPhong.LayPhongTro();
                dgvQLPT.AutoResizeColumns();
                this.txtMP.ResetText();
                this.txtMKT.ResetText();
                this.txtTT.ResetText();
                this.txtTP.ResetText();
                this.txtMLP.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                dgvQLLP_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Phong_Tro. Lỗi rồi!!!");
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
            this.txtMP.ResetText();
            this.txtMKT.ResetText();
            this.txtTT.ResetText();
            this.txtTP.ResetText();
            this.txtMLP.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMP.Enabled = true;
            this.txtMP.Focus();
            txtMP.Enabled = false;
            txtTT.Enabled = false;
            txtTT.Text = "Trống";
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
            this.txtMP.Enabled = false;
            this.txtMKT.Focus();
            this.txtMP.Enabled = true;
            txtMP.Enabled = false;

        }

        private void dgvQLLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvQLPT.CurrentCell.RowIndex;
            this.txtMP.Text = dgvQLPT.Rows[current].Cells[0].Value.ToString();
            this.txtMKT.Text = dgvQLPT.Rows[current].Cells[1].Value.ToString();
            this.txtTT.Text = dgvQLPT.Rows[current].Cells[2].Value.ToString();
            this.txtTP.Text = dgvQLPT.Rows[current].Cells[3].Value.ToString();
            this.txtMLP.Text = dgvQLPT.Rows[current].Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMP.ResetText();
            groupBox2.Enabled = false;
            this.txtMKT.ResetText();
            this.txtTT.ResetText();
            this.txtTP.ResetText();
            this.txtMLP.ResetText();
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
                    dbPhong.ThemPhongTro(this.txtMKT.Text, this.txtTP.Text, this.txtMLP.Text);
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

                dbPhong.CapNhatPhongTro(this.txtMP.Text, this.txtMKT.Text, this.txtTT.Text, this.txtTP.Text, this.txtMLP.Text);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvQLPT.CurrentCell.RowIndex;
                string MaPhong = dgvQLPT.Rows[current].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbPhong.XoaPhongTro(MaPhong);
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
