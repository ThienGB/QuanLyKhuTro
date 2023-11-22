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
using QuanLyNhaTro.FrmMain;

namespace QuanLyNhaTro
{
    public partial class frm_LoginGuest : Form
    {
        BLDangNhap bLLogin = new BLDangNhap();
        string err;
        public frm_LoginGuest()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.username = this.txtUsername.Text;
            Global.password = this.txtPassword.Text;
            
            try
            {
                bool login = bLLogin.DangNhapKhachThue(this.txtUsername.Text, this.txtPassword.Text);
                this.Hide();
                string MaKT = bLLogin.LayMaKT(this.txtUsername.Text);
                frm_Guest frm_guest = new frm_Guest(this.txtUsername.Text, MaKT);
                frm_guest.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ten dang nhap hoac mat khau sai !!", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
        
        private void picHienMatKhau_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picHienMatKhau.Visible = false;
            picAnMK.Visible = true;

        }

        private void picAnMK_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true ;
            picHienMatKhau.Visible = true;
            picAnMK.Visible = false;
        }
    }
}
