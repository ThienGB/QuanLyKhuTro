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
    public partial class DichVuGuest : UserControl
    {
        string MaPhong;
        public DichVuGuest(string maphong)
        {
            MaPhong = maphong;
            InitializeComponent();
        }
        BLDichVu dbDV = new BLDichVu();
        void LoadData()
        {
            try
            {
                try
                {
                    dgvDV.DataSource = dbDV.LayThongTinDichVu();
                }
                catch {
                    MessageBox.Show("Không lấy được nội dung Thongtindichvu. Lỗi rồi!!!");
                }

                try
                {
                    dgvDVthue.DataSource = dbDV.LayThongTinDichVuSuDung(MaPhong);
                }
                catch
                {
                    MessageBox.Show("Không lấy được nội dung ThongtindichvuSuDung. Lỗi rồi!!!");
                }
                dgvDV.AutoResizeColumns();
                this.txtID.ResetText();
                this.txtTDV.ResetText();
                this.txtSoLuong.ResetText();
                this.tbSoLuong.ResetText();
                dgvDV.Visible = false;
                btnThem.Visible = false;
                lblSoLuong.Visible = false;
                tbSoLuong.Visible = false;
                dgvDVthue_CellClick(null, null);
                btnLuu.Visible = false;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }

        private void DichVuGuest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ThemDV_Click(object sender, EventArgs e)
        {
            dgvDV.Visible = true;
            btnThem.Visible = true;
            lblSoLuong.Visible = true;
            tbSoLuong.Visible=true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvDV.CurrentCell.RowIndex;
                string MaDV = dgvDV.Rows[current].Cells[0].Value.ToString();
                int Soluong = int.Parse(this.tbSoLuong.Text);               
                dbDV.ThemDichVuSuDung(MaPhong,MaDV,Soluong);
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
            catch
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }        
        }

        private void XoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                int current = dgvDVthue.CurrentCell.RowIndex;
                string MaDV = dgvDVthue.Rows[current].Cells[0].Value.ToString();
                
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    dbDV.XoaDichVuSuDung(MaDV,MaPhong);
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

        private void dgvDVthue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = dgvDVthue.CurrentCell.RowIndex;
            this.txtID.Text = dgvDVthue.Rows[current].Cells[0].Value.ToString();
            this.txtTDV.Text = dgvDVthue.Rows[current].Cells[1].Value.ToString();
            this.txtDonGia.Text = dgvDVthue.Rows[current].Cells[2].Value.ToString();
            this.txtSoLuong.Text= dgvDVthue.Rows[current].Cells[3].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThemDV.Enabled = true;
            btnXoaDV.Enabled = true;
            txtSoLuong.Enabled = false;
            groupBox2.Enabled=false;
            try
            {
                string MaDV = txtID.Text;
                int Soluong = int.Parse(this.txtSoLuong.Text);
                dbDV.CapNhatDichVuSuDung(MaPhong, MaDV, Soluong);
                LoadData();
                MessageBox.Show("Đã sửa thành công ");
                btnLuu.Visible = false;
            }
            catch { MessageBox.Show("sửa ko  thành công "); }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            btnThemDV.Enabled = false;
            btnXoaDV.Enabled = false;
            this.txtID.Enabled = false;
            this.txtTDV.Enabled = false;
            this.txtSoLuong.Enabled = true;
            this.txtDonGia.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
