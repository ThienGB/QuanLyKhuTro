using DevComponents.DotNetBar;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using QuanLyNhaTro.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro.FrmMain
{
    public partial class frm_Admin : Form
    {
        string userName,PASS;
        public frm_Admin()
        {
            InitializeComponent();
        }
        public frm_Admin(string username,string pass ):this()
        {
            userName = username;
            PASS = pass;
        }
        private void TabTrangThai()
        {
            //Khoi tao 
            TrangThai ucTrangThai = new TrangThai();
            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel TrangThaiThue";
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(178)))), ((int)(((byte)(222)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(192)))), ((int)(((byte)(222)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------Them tab page---------------------
            Random ran = new Random();
            newTabPage.Name = "TrangThaiThue" + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = "Trạng thái thuê";
            ucTrangThai.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucTrangThai);

            //------------Them Tab page vao Tab control-------------
            tabMain.Controls.Add(newTabPanel);
            tabMain.Tabs.Add(newTabPage);
            tabMain.SelectedTab = newTabPage;
            newTabPage.ImageIndex = 6;
            newTabPage.CloseButtonVisible = false;

        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            labelX2.Text = "Xin chào "+ userName;
            TabTrangThai();
            Load_CB_KV();
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }
        //Ham thoat
        public void CloseThis()
        {
            TabItem selectedTab = tabMain.SelectedTab;
            if (MessageBox.Show("Bạn có muốn tắt trang: \"" + selectedTab.Text + "\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (tabMain.SelectedTabIndex != 0)
                    tabMain.Tabs.Remove(selectedTab);
        }


        // chuột phải đóng trang
        private void tabMain_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            CloseThis();
        }



        // Ham Add-Tab
        public void addNewTab(string strTabName, UserControl ucContent, int imgindex)
        {
            //-----------If exist tabpage then exit---------------
            foreach (TabItem tabPage in tabMain.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabMain.SelectedTab = tabPage;
                    return;
                }
            //-------------------------Clear Tab Before---------------
            //if (tabMain.Tabs.Count > 1)
            //    tabMain.Tabs.RemoveAt(1);

            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            //newTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(tabItem_MouseDown);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------New  tab page---------------------
            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);
            //------------add Tab page to Tab control-------------
            tabMain.Controls.Add(newTabPanel);
            tabMain.Tabs.Add(newTabPage);
            tabMain.SelectedTab = newTabPage;
            newTabPage.ImageIndex = imgindex;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            addNewTab("Doanh thu", dt, 11);
        }

        private void btnDsNgThue_Click(object sender, EventArgs e)
        {
            frm_TKNgThue dsnt= new frm_TKNgThue();
            dsnt.Show();
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            TrangThai trangThai = new TrangThai();
            addNewTab("Trạng thái thuê", trangThai, 6);
        }

        private void btnDsThuTien_Click(object sender, EventArgs e)
        {
            Dsthutien dt = new Dsthutien();
            addNewTab("Danh sách thu tiền", dt, 10);
        }

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            ChoThue choThue = new ChoThue();
            addNewTab("Cho thuê", choThue, 4);
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi();
            addNewTab("Thêm người", themNguoi, 5);
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            frmTraPhong traphong =new frmTraPhong();
            addNewTab("Trả phòng", traphong, 3);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            TinhTien tinhTien = new TinhTien();
            addNewTab("Tính tiền", tinhTien, 1);
        }

        private void cbKV_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLPhong bLPhong = new BLPhong();
            string makv = cbKV.SelectedValue.ToString();
            var phongtrong = bLPhong.Layphong_TT_MaKV("Trống", makv);
            var phongdathue = bLPhong.Layphong_TT_MaKV("Đã thuê", makv);
            numTrong.Text = phongtrong.Rows.Count.ToString();
            numRent.Text = phongdathue.Rows.Count.ToString();
        }
        public void Load_CB_KV()
        {
            //Load ComboBox Khu Vuc
            BLKhuVuc bLKhuVuc = new BLKhuVuc();
            cbKV.DisplayMember = "TenKhuVuc";
            cbKV.ValueMember = "MaKhuVuc";
            cbKV.DataSource = bLKhuVuc.LayKhuVuc();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong themphong = new ThemPhong();
            addNewTab("Thêm phòng", themphong, 0);
        }

        private void btnThemKV_Click(object sender, EventArgs e)
        {
            ThemKV thKV = new ThemKV();
            addNewTab("Thêm khu vực", thKV, 9);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass(userName,PASS);
            frmChangePass.ShowDialog();
        }

        private void btn_QLyDV_Click(object sender, EventArgs e)
        {
            QLDichVu qLDichVu = new QLDichVu();
            qLDichVu.ShowDialog();
        }

        private void btn_QLyLPhong_Click(object sender, EventArgs e)
        {
            QLLoaiPhong qLLoaiPhong = new QLLoaiPhong();
            qLLoaiPhong.ShowDialog();
        }

        private void btn_ttTK_Click(object sender, EventArgs e)
        {
            AccountInformation accountInformation = new AccountInformation(userName, PASS);
            accountInformation.ShowDialog();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass(userName, PASS);
            frmChangePass.ShowDialog();
        }

        private void btn_themtk_Click(object sender, EventArgs e)
        {
            ThemTK themTK = new ThemTK();
            themTK.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonItem5_Click(object sender, EventArgs e)
        {
            frmHopDong form = new frmHopDong();
            addNewTab("Hợp đồng", form, 12);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            frmSuDungDichVu frmSuDungDichVu = new frmSuDungDichVu();
            addNewTab("Sử dụng dịch vụ", frmSuDungDichVu, 13);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            TaoPhieuChi taophieuchi = new TaoPhieuChi();
            addNewTab("Tạo phiếu chi", taophieuchi, 14);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            AccountInformation accountInformation = new AccountInformation(userName,PASS);
            accountInformation.ShowDialog();
        }
    }
}
