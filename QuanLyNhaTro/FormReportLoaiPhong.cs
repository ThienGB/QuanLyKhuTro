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
    public partial class FormReportLoaiPhong : Form
    {
        public FormReportLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormReportLoaiPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongKe.LoaiPhong' table. You can move, or remove it, as needed.
            this.loaiPhongTableAdapter.Fill(this.thongKe.LoaiPhong);
            // TODO: This line of code loads data into the 'dataSet1.LoaiPhong' table. You can move, or remove it, as needed.    
            this.reportViewer1.RefreshReport();
        }
    }
}
