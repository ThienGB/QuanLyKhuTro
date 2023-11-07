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
        private string id, MaKT;
        BLDangNhap TL=new BLDangNhap();
        public frmThayDoiMK_Khach()
        {
            InitializeComponent();
        }
        public frmThayDoiMK_Khach(string username, string pas):this()
        {
            id = username;
            MaKT = pas;
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
                string err = "";
                bool c = TL.DoiMatKhau(TK, oldP, newP, out err);
                if (!c)
                {
                    MessageBox.Show(err);
                }    
                else
                {
                    MessageBox.Show("Thay đổi thành công");
                    Close();
                }  
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
