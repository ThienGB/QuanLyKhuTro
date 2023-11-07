using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using QuanLyNhaTro.BS_layer;
using System.IO;

namespace MotelRoomManagement
{  
    public partial class frm_Information : Form
    {
        BLTTKhach bLTTKhach = new BLTTKhach();
        bool chonAnh = false;
        //string a;
        string _id, ho, ten, birthday, cmnd, quequan, job, gioitinh, ghichu;
        byte[] binaryData=null;

        private void ptbAnh34_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                chonAnh = true;
                string filePath = openFileDialog.FileName;
                ptbAnh34.Image = Image.FromFile(filePath);
                binaryData = System.IO.File.ReadAllBytes(filePath);
            }
        }

        public frm_Information()
        {
            InitializeComponent();
            
        }

        public frm_Information(string id):this()
        {
            _id = id;

        }
        private void frmInformation_Load(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            txtHo.Enabled = false;
            txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGioiTinh.Enabled = false;
            txtCMND.Enabled = false;
            txtQue.Enabled = false;
            txtNghe.Enabled = false;
            txtGhiChu.Enabled = false;
            var tmp = bLTTKhach.LayThongTinKhachQuaID(_id);
            lbMaKt.DataBindings.Add("Text", tmp, "MaKhachTro");
            cbGioiTinh.DataBindings.Add("Text", tmp, "GioiTinh");
            txtTen.DataBindings.Add("Text", tmp, "Ten");
            txtHo.DataBindings.Add("Text", tmp, "Ho"); ;
            txtHoTen.Text = txtHo.Text + " " + txtTen.Text;
            dtpNgaySinh.DataBindings.Add("Text", tmp, "NgaySinh");
            txtCMND.DataBindings.Add("Text", tmp, "CMND");
            txtQue.DataBindings.Add("Text", tmp, "QueQuan");
            txtNghe.DataBindings.Add("Text", tmp, "NgheNghiep");
            txtGhiChu.DataBindings.Add("Text", tmp, "GhiChu");

            byte[] imageData = bLTTKhach.LayAnh(_id);
            if ( imageData != null )
            {
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(memoryStream);
                    ptbAnh34.Image = image;
                }
            }
            if (cbGioiTinh.Text == "Nam")
                cbGioiTinh.SelectedItem = 0;
            else if (cbGioiTinh.Text == "Nữ")
                cbGioiTinh.SelectedItem = 1;
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            btn_ChonAnh.Visible = true;
            txtHo.Enabled = true; 
            txtTen.Enabled = true; 
            txtHoTen.Visible = false;
            dtpNgaySinh.Enabled = true;
            cbGioiTinh.Enabled = true;
            txtCMND.Enabled = true;
            txtQue.Enabled = true;
            txtNghe.Enabled = true;
            txtGhiChu.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnUpdate.Visible = false;
            btnExit.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtHo.Enabled = false; 
            txtTen.Enabled = false;
            txtHoTen.Visible = true; txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGioiTinh.Enabled = false;
            txtCMND.Enabled = false;
            txtQue.Enabled = false;
            txtNghe.Enabled = false;
            txtGhiChu.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = true;
            btnExit.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(chonAnh== false )
            {
                binaryData = bLTTKhach.LayAnh(_id);
            }
            ho = txtHo.Text.Trim();
            ten = txtTen.Text;
            txtHoTen.Text = ho + ' ' + ten;
            birthday = dtpNgaySinh.Text.Trim();
            if (cbGioiTinh.Text == "Nam")
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            cmnd = txtCMND.Text.Trim();
            quequan = txtQue.Text.Trim();
            job = txtNghe.Text.Trim();
            ghichu = txtGhiChu.Text.Trim();

            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtHoTen.Visible = true; txtHoTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGioiTinh.Enabled = false;
            txtCMND.Enabled = false;
            txtQue.Enabled = false;
            txtNghe.Enabled = false;
            txtGhiChu.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = true;
            btnExit.Visible = true;
            btn_ChonAnh.Visible = false;

            //bool a = bLTTKhach.CapNhatThongTinKhach(_id, ho, ten, gioitinh, DateTime.Parse(birthday), cmnd, quequan, job, ghichu, binaryData);
/*            if (a)
                MessageBox.Show("Đã sửa thông tin khách!");
            else
                MessageBox.Show("Error","Sua ko thanh cong",MessageBoxButtons.OK);*/
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
