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
        public TaoPhieuChi()
        {
            InitializeComponent();

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = dtLap.Value;
                int sotien = Convert.ToInt32(txtSoTien.Text);
                bLPhieuChi.InsertPhieuChi(dateTime, sotien, txtNoiDung.Text);
                MessageBox.Show("Bạn đã thêm thành công phiếu chi !!");
                txtNoiDung.Text = "";
                txtSoTien.Text = "";
            }
            catch
            {
                MessageBox.Show("Phiếu chi ko đc thêm thành công !!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
            txtSoTien.Text = "";
        }
    }
}
