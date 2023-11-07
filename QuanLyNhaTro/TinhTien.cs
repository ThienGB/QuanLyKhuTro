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
    public partial class TinhTien : UserControl
    {

        BLPhong dbphong = new BLPhong();

        BLPhieuThu dbpt = new BLPhieuThu();

        public TinhTien()
        {
            InitializeComponent();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {

            load_phong();
            lvPhong.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }



        //Load Phòng chưa lập hóa đơn
        private void load_phong()
        {
            lvPhong.Items.Clear();

            var phong = dbphong.ViewChuaTaoPhieuThu();

            for (int i = 0; i < phong.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(phong.Rows[i][0].ToString());
                item.ImageIndex = 1 ;
                lvPhong.Items.Add(item);
            }

        }



        private void lvPhong_Click(object sender, EventArgs e)
        {

            ListViewItem a = lvPhong.SelectedItems[0];
            string maphong = a.SubItems[0].Text;
            txtMaPhong.Text = maphong;
            txtTenPhong.Text=maphong;
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled=false;
            txtNuoc.Enabled = true;
            txtPhiMT.Enabled = true;   
            txtSoDien.Enabled = true;
        }


      
        private void txtSoKi_TextChanged(object sender, EventArgs e)
        {
    
        }


        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            dbpt.TaoPhieuThu(txtMaPhong.Text, txtPhiMT.Text, txtSoDien.Text, txtNuoc.Text);
                load_phong();
                ClearAll();
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;

        }

        private void ClearAll()
        {
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtSoDien.Text = "";
            txtNuoc.Text = "";
            txtPhiMT.Text = "";
          
        }
    }
}