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
    public partial class frm_Login : Form
    {
        BLDangNhap bLDangNhap = new BLDangNhap();
        BLDangNhap bLLogin = new BLDangNhap();

        string err;
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Global.username = this.txtUsername.Text;
            Global.password = this.txtPassword.Text;
            
            try {
                bool login = bLLogin.DangNhap(this.txtUsername.Text, this.txtPassword.Text);
                frm_Admin frm_Admin = new frm_Admin(this.txtUsername.Text, this.txtPassword.Text);
                frm_Admin.ShowDialog();
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
