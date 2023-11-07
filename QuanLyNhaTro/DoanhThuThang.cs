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
    public partial class DoanhThuThang : UserControl
    {
        BLDoanhThuThang dtt = new BLDoanhThuThang();
        public DoanhThuThang()
        {
            InitializeComponent();
        }

        private void DoanhThuThang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dgvDoanhThuThang.DataSource = dtt.LayDoanhThuThang();
                dgvDoanhThuThang.AutoResizeColumns();
                //dgvDSKT_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Doanh thu Tháng. Lỗi rồi!!!");
            }
        }
    }
}
