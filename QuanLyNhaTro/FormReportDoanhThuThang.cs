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
    public partial class FormReportDoanhThuThang : Form
    {
        
        
        public FormReportDoanhThuThang()
        {
            InitializeComponent();

        }

        private void FormReportDoanhThuThang_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM-yyyy";
            this.phieuThuTableAdapter.Fill(this.dataSet1.PhieuThu);
            this.reportViewer1.RefreshReport();

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            this.phieuThuTableAdapter.FillBy(this.dataSet1.PhieuThu, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.phieuThuTableAdapter.Fill(this.dataSet1.PhieuThu);
            this.reportViewer1.RefreshReport();

        }
    }
}
