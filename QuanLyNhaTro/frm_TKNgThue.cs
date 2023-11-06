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
    public partial class frm_TKNgThue : Form
    {
        public frm_TKNgThue()
        {
            InitializeComponent();
        }

        private void frm_TKNgThue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thongKe.ThongTinKhach' table. You can move, or remove it, as needed.
            this.thongTinKhachTableAdapter.Fill(this.thongKe.ThongTinKhach);
            this.reportViewer1.RefreshReport();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportKhach.rdlc";
            this.thongTinKhachTableAdapter.FillBy(this.thongKe.ThongTinKhach,txtMaKhach.Text );
            this.reportViewer1.RefreshReport();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportTTKhach.rdlc";
            this.thongTinKhachTableAdapter.Fill(this.thongKe.ThongTinKhach);
            this.reportViewer1.RefreshReport();
        }
    }
}
