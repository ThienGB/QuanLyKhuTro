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
    public partial class QLKhachThue : Form
    {
        bool Them;
        BLTTKhach bLTTKhach = new BLTTKhach();

        public QLKhachThue()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvQLPT.DataSource = bLTTKhach.LayThongTinKhach();
                dgvQLPT.AutoResizeColumns();
                this.txtKT.ResetText();
                this.txtMP.ResetText();
                this.txtHT.ResetText();
                this.txtGT.ResetText();
                this.txtNN.ResetText();
                this.txtCMND.ResetText();
                this.txtQQ.ResetText();
                this.dtPNS.ResetText();
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
            this.txtKT.ResetText();
            this.txtMP.ResetText();
            this.txtHT.ResetText();
            this.txtGT.ResetText();
            this.txtNN.ResetText();
            this.txtCMND.ResetText();
            this.txtQQ.ResetText();
            this.dtPNS.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtKT.Enabled = true;
            this.txtKT.Focus();
            txtKT.Enabled = false;
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
            this.txtKT.Enabled = false;
            this.txtMP.Focus();
            this.txtKT.Enabled = true;
            txtKT.Enabled = false;

        }

        private void dgvQLLP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvQLPT.CurrentCell.RowIndex;
            this.txtKT.Text = dgvQLPT.Rows[current].Cells[0].Value.ToString();
            this.txtMP.Text = dgvQLPT.Rows[current].Cells[1].Value.ToString();
            this.txtHT.Text = dgvQLPT.Rows[current].Cells[2].Value.ToString();
            this.txtGT.Text = dgvQLPT.Rows[current].Cells[3].Value.ToString();
            this.txtNN.Text = dgvQLPT.Rows[current].Cells[4].Value.ToString();
            this.txtCMND.Text = dgvQLPT.Rows[current].Cells[5].Value.ToString();
            this.txtQQ.Text = dgvQLPT.Rows[current].Cells[6].Value.ToString();
            if (dgvQLPT.Rows[current].Cells[7].Value.ToString() != "")
                this.dtPNS.Value = DateTime.Parse(dgvQLPT.Rows[current].Cells[7].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtKT.ResetText();
            groupBox2.Enabled = false;
            this.txtMP.ResetText();
            this.txtHT.ResetText();
            this.txtGT.ResetText();
            this.txtNN.ResetText();
            this.txtCMND.ResetText();
            this.txtQQ.ResetText();
            this.dtPNS.ResetText();
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
                    bLTTKhach.ThemKhach(this.txtMP.Text, this.txtHT.Text, this.txtGT.Text, this.txtNN.Text, this.txtQQ.Text, this.txtCMND.Text, this.dtPNS.Value);
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

                bLTTKhach.CapNhatThongTinKhach(this.txtKT.Text, this.txtMP.Text, this.txtHT.Text, this.txtGT.Text, this.txtNN.Text, this.txtQQ.Text, this.txtCMND.Text, this.dtPNS.Value);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvQLPT.CurrentCell.RowIndex;
                string MaKT = dgvQLPT.Rows[current].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    bLTTKhach.XoaKhach(MaKT);
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
