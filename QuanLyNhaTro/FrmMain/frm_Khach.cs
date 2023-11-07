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
    public partial class frm_Khach : Form
    {
        string userName,PASS;
        public frm_Khach()
        {
            InitializeComponent();
        }
        public frm_Khach(string username,string pass ):this()
        {
            userName = username;
            PASS = pass;
        }
        

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            labelX2.Text = "Xin chào "+ userName;
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

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            TinhTien tinhTien = new TinhTien();
            addNewTab("Tính tiền", tinhTien, 1);
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            ThemNguoi themNguoi = new ThemNguoi();
            addNewTab("Thêm người", themNguoi, 5);
        }

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            ChoThue choThue = new ChoThue();
            addNewTab("Cho thuê", choThue, 4);
        }

        private void btnDsThuTien_Click(object sender, EventArgs e)
        {
            TaoPhieuChi TPC = new TaoPhieuChi();
            addNewTab("Tạo phiếu chi ", TPC, 7);
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            string mp = "101";
            DichVuGuest dvguest = new DichVuGuest(mp);
            addNewTab("DV guest", dvguest, 6);
        }

       
    }
}
