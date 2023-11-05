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
    public partial class FormReportDichVu : Form
    {
        public FormReportDichVu()
        {
            InitializeComponent();
        }

        private void FormReportDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongKe.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.thongKe.DichVu);
            this.reportViewer1.RefreshReport();
        }
    }
}
