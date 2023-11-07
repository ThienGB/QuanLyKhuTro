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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyNhaTro
{
    public partial class QLDichVu : Form
    {
        bool Them;
        BLDichVu dbDV = new BLDichVu();
        public QLDichVu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
           
        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            groupBox2.Enabled = true;
            this.txtID.ResetText();
            this.txtTDV.ResetText();
            this.txtDG.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtID.Enabled = true;
            this.txtID.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            groupBox2.Enabled = true;
            dgvQLDV_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtID.Enabled = false;
            this.txtTDV.Focus();
        }

        private void dgvQLDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvQLDV.CurrentCell.RowIndex;
            this.txtID.Text = dgvQLDV.Rows[current].Cells[0].Value.ToString();
            this.txtTDV.Text = dgvQLDV.Rows[current].Cells[1].Value.ToString();
            this.txtDG.Text = dgvQLDV.Rows[current].Cells[2].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtID.ResetText();
            groupBox2.Enabled = false;
            this.txtTDV.ResetText();
            this.txtDG.ResetText();
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            dgvQLDV_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            if (Them)
            {
                try
                {
                   
                    int id = int.Parse(this.txtID.Text);
                    long gia = long.Parse(this.txtDG.Text);
                    dbDV.ThemDichVu(id, this.txtTDV.Text, gia);
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
                
                int id = int.Parse(this.txtID.Text);
                long gia = long.Parse(this.txtDG.Text);
                dbDV.CapNhatDichVu(id, this.txtTDV.Text, gia);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvQLDV.CurrentCell.RowIndex;
                string tmp = dgvQLDV.Rows[current].Cells[0].Value.ToString();
                int id = int.Parse(tmp);
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbDV.XoaDichVu(id);
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
