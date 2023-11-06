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
    public partial class FormReportDSPhong : Form
    {
        public FormReportDSPhong()
        {
            InitializeComponent();
        }

        private void FormReportDSPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongKe.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.thongKe.DataTable1);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportPhong.rdlc";
            this.dataTable1TableAdapter.FillBy(this.thongKe.DataTable1,txtMaPhong.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportDsPhong.rdlc";
            this.dataTable1TableAdapter.Fill(this.thongKe.DataTable1);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
