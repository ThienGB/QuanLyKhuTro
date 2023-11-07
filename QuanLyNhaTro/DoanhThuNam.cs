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
    public partial class DoanhThuNam : UserControl
    {
        BLDoanhThuNam dtn=new BLDoanhThuNam();
        public DoanhThuNam()
        {
            InitializeComponent();
        }

        private void DoanhThuNam_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dgvDoanhThuNam.DataSource = dtn.LayDoanhThuNam();
                dgvDoanhThuNam.AutoResizeColumns();
                //dgvDSKT_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Doanh thu năm. Lỗi rồi!!!");
            }
        }
    }
}
