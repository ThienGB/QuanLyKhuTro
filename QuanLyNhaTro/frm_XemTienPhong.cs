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
    public partial class frm_XemTienPhong : UserControl
    {
        string userName;
        string MaKT;
        BLPhieuThu dbphieuthu = new BLPhieuThu();
        BLPhong blPhong = new BLPhong();
        public frm_XemTienPhong()
        {
            InitializeComponent();
        }
        public frm_XemTienPhong(string userName, string MaKT) : this()
        {
            this.userName = userName;
            this.MaKT = MaKT;
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadThang();
        }

        private void LoadThang()
        {
            List<string> list = new List<string>();
            string MaPhong = blPhong.LayMaPhongBangMaKT(MaKT);
            DataTable table = dbphieuthu.LayThangPhieuThuTheoMaPhong(MaPhong);
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
            ListViewItem item = lvThang.SelectedItems[0];
            string thangNam = item.Text;
            lblTT.Text = thangNam;
            string MaPhong = blPhong.LayMaPhongBangMaKT(MaKT);
            DataTable table = dbphieuthu.LayPTTheoMaPhongvaThang(MaPhong, thangNam);
            lblMPT.Text = table.Rows[0][1].ToString().TrimEnd();
            lblNLPT.Text = table.Rows[0][2].ToString().TrimEnd();
            lblSN.Text = table.Rows[0][3].ToString().TrimEnd();
            lblPMT.Text = table.Rows[0][4].ToString().TrimEnd();
            lblPDV.Text = table.Rows[0][5].ToString().TrimEnd();
            lblSD.Text = table.Rows[0][6].ToString().TrimEnd();
            lblTN.Text = table.Rows[0][7].ToString().TrimEnd();
            lblTT.Text = table.Rows[0][8].ToString().TrimEnd();
            lblTrangThai.Text = table.Rows[0][9].ToString().TrimEnd();
            if (lblTrangThai.Text == "Đã đóng")
            {
                lblTrangThai.BackColor = Color.LightGreen;
            }    
            else
            {
                lblTrangThai.BackColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
