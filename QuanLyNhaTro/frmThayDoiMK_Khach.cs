using QuanLyNhaTro.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace QuanLyNhaTro
{
    public partial class frmThayDoiMK_Khach : Form
    {
        private string id, pass;
        BLDangNhap TL=new BLDangNhap();
        public frmThayDoiMK_Khach()
        {
            InitializeComponent();
        }
        public frmThayDoiMK_Khach(string username, string pas):this()
        {
            id = username;
            pass = pas;
        }
        

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string TK, newP, rewrite,oldP;
            TK = txtTK.Text;
            oldP= txtoldpass.Text;
            newP = txtNewPass.Text;
            rewrite = txtRewrite.Text;
            if (TK == "" || newP == "" || rewrite == "")
            {
                    MessageBox.Show("Vui lòng điền đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (id == TK && oldP==pass )
                {
                    if (newP == rewrite)
                    {
                        TL.DoiMatKhau(TK, oldP, newP);
                        MessageBox.Show("Thay đổi thành công");
                        Close();
                    }
                    else
                        MessageBox.Show("Vui lòng nhập lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
