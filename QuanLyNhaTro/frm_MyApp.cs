using QuanLyNhaTro.FrmMain;
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
    public partial class frm_MyApp : Form
    {
        public frm_MyApp()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangKyPhong frm_guest = new frm_DangKyPhong();
            frm_guest.ShowDialog();
            this.Show();

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login frm_Login = new frm_Login();  
            frm_Login.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_LoginGuest frm_loginGuest = new frm_LoginGuest();
            frm_loginGuest.ShowDialog();
            this.Show();
        }
    }
}
