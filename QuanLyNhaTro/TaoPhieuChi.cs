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
    public partial class TaoPhieuChi : UserControl
    {
        BLPhieuChi bLPhieuChi = new BLPhieuChi();
        bool Them;
        public TaoPhieuChi()
        {
            InitializeComponent();
            dtLap.Enabled = true;

        }

        void LoadData()
        {
            try
            {
                try
                {
                    dgvPhieuChi.DataSource = bLPhieuChi.layPhieuChi();
                    groupBox4.Enabled = false;
                    this.txtid.ResetText();
                    this.dtLap.ResetText();
                    this.txtSoTien.ResetText();
                    this.txtNoiDung.ResetText();
                    this.btnLuu.Enabled = false;
                    this.btnHuy.Enabled = false;
                    this.btnThem.Enabled = true;
                    this.btnSua.Enabled = true;
                    this.btnXoa.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Không lấy được nội dung . Lỗi rồi!!!");
                }



                dgvPhieuChi.AutoResizeColumns();
                this.txtid.ResetText();
                this.txtSoTien.ResetText();
                this.txtNoiDung.ResetText();
                this.dtLap.ResetText();
               

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            groupBox4.Enabled = true;
            this.txtid.ResetText();
            this.txtSoTien.ResetText();
            this.txtNoiDung.ResetText();
            this.dtLap.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtSoTien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            groupBox4.Enabled = true;
            dgvPhieuChi_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtNoiDung.Focus();
        }

        private void dgvPhieuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvPhieuChi.CurrentCell.RowIndex;
            this.txtid.Text = dgvPhieuChi.Rows[current].Cells[0].Value.ToString();
            this.txtSoTien.Text = dgvPhieuChi.Rows[current].Cells[2].Value.ToString();
            this.txtNoiDung.Text = dgvPhieuChi.Rows[current].Cells[3].Value.ToString();
            object cellValue = dgvPhieuChi.Rows[current].Cells[1].Value;

            // Kiểm tra và chuyển đổi thành DateTime
            if (cellValue != null && DateTime.TryParse(cellValue.ToString(), out DateTime dateTimeValue))
            {
                // Gán giá trị kiểu DateTime vào dtLap.Value
                this.dtLap.Value = dateTimeValue;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtSoTien.ResetText();
            this.txtid.ResetText();
            groupBox4.Enabled = false;
            this.txtNoiDung.ResetText();
            this.dtLap.ResetText();
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            dgvPhieuChi_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            if (Them)
            {
                try
                {
                    DateTime ngayLap = dtLap.Value;
                    string sotien = txtSoTien.Text;
                    bLPhieuChi.InsertPhieuChi(ngayLap, sotien, txtNoiDung.Text);
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

                string  id = this.txtid.Text;
                string gia = this.txtSoTien.Text;
                string noidung = this.txtNoiDung.Text;
                string ngayLap = this.dtLap.Text;
                bLPhieuChi.updatePhieuChi(id, gia,noidung, ngayLap);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvPhieuChi.CurrentCell.RowIndex;
                string id = txtid.Text;
                
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    bLPhieuChi.DeletePhieuChi(id);
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

        private void TaoPhieuChi_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
