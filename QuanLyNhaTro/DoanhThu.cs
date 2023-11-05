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
    public partial class DoanhThu : UserControl
    {
        BLPhieuThu dbphieuthu = new BLPhieuThu();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadThang();

            var tongtien = dbphieuthu.TongDaThu();
            txtTDT.Text = string.Format("{0:#,##0}", Int32.Parse(tongtien.ToString().TrimEnd()));
        }

        private void LoadThang()
        {
            List<string> list = new List<string>();
            DataTable table = dbphieuthu.LayThangPhieuThu();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string item = table.Rows[i][0].ToString().TrimEnd();
                if (!list.Contains(item.ToString()))
                    list.Add(item.ToString());
            }
            foreach (string i in list)
                lvThang.Items.Add(i);
        }

        private void lvThang_Click(object sender, EventArgs e)
        {
            lvHD.Items.Clear();
            ListViewItem item = lvThang.SelectedItems[0];
            string thang = item.Text;
            label4.Text = thang;
            DataTable table = dbphieuthu.LayPhieuThuTheoThang(thang);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem items = new ListViewItem(table.Rows[i][0].ToString().TrimEnd());
                items.SubItems.Add(table.Rows[i][1].ToString().TrimEnd());
                items.SubItems.Add(table.Rows[i][2].ToString().TrimEnd());
                lvHD.Items.Add(items);
            }


            var TongTien = dbphieuthu.TongDoanhThuThang(thang);
            txtTTT.Text = string.Format("{0:#,##0}", Int32.Parse(TongTien.ToString().TrimEnd()));
        }

        private void lvHD_Click(object sender, EventArgs e)
        {

            lvTP.Items.Clear();
            ListViewItem item = lvHD.SelectedItems[0];
            int maPT = int.Parse(item.Text); 
            DataTable table = dbphieuthu.LayPhieuThuTheoMa(maPT);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem items = new ListViewItem(table.Rows[i][1].ToString().TrimEnd());
                label6.Text = table.Rows[i][1].ToString().TrimEnd();
                items.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][4].ToString().TrimEnd())));
                lvTP.Items.Add(items);
            }

            lvDV.Items.Clear();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem items1 = new ListViewItem(string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][6].ToString().TrimEnd())));
                items1.SubItems.Add(string.Format("{0:#,##0}", Int32.Parse(table.Rows[i][8].ToString().TrimEnd())));
                lvDV.Items.Add(items1);
            }

            txtTTP.Text = string.Format("{0:#,##0}", Int32.Parse(table.Rows[0][9].ToString().TrimEnd()));
        }
    }
}
