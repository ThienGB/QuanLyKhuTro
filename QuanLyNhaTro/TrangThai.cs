using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotelRoomManagement;
using QuanLyNhaTro.BS_layer;

namespace QuanLyNhaTro
{
    public partial class TrangThai : UserControl
    {
        BLKhuTro bLKhuVuc = new BLKhuTro();
        BLPhong bLPhong = new BLPhong();
        BLTTKhach bLTTKhach = new BLTTKhach();

        public TrangThai()
        {
            InitializeComponent();
        }

        private void TrangThai_Load(object sender, EventArgs e)
        {
            Load_Data_TreeView1();
            Load_Data_TreeView2();
            Load_CB_KV();
        }

        public void Load_CB_KV()
        {
            //Load ComboBox Khu Vuc
            
            cbKV.DisplayMember = "TenKhuVuc";
            cbKV.ValueMember = "MaKhuVuc";
            cbKV.DataSource = bLKhuVuc.LayKhuTro();


        }
        //Load du lieu
        private void cbKV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makv = cbKV.SelectedValue.ToString();
            var phongtrong = bLPhong.Layphong_TT_MaKV("Trống", makv);
            var phongdathue = bLPhong.Layphong_TT_MaKV("Đã thuê", makv);
            numTrong.Text = phongtrong.Rows.Count.ToString();
            numRent.Text = phongdathue.Rows.Count.ToString();
        }

        private void Load_Data_TreeView1()
        {
            treeView1.ImageList = TwImgList;
            for (int i = 0; i < bLKhuVuc.LayKhuTro().Rows.Count; i++)
            {
                string item_TenKV = bLKhuVuc.LayKhuTro().Rows[i][1].ToString();
                string item_MaKV = bLKhuVuc.LayKhuTro().Rows[i][0].ToString();
                TreeNode nodecha = treeView1.Nodes.Add(item_TenKV);
                treeView1.Nodes[i].Tag = "1";
                nodecha.ImageIndex = 0;
                for (int j = 0; j < bLPhong.Layphong_TT_MaKV("Đã thuê", item_MaKV).Rows.Count; j++)
                {
                    TreeNode nodecon = treeView1.Nodes[i].Nodes.Add(bLPhong.Layphong_TT_MaKV("Đã thuê", item_MaKV).Rows[j][1].ToString());
                    treeView1.Nodes[i].Nodes[j].Tag = "2";
                    treeView1.Nodes[i].Nodes[j].Name = bLPhong.Layphong_TT_MaKV("Đã thuê", item_MaKV).Rows[j][0].ToString();
                    nodecon.ImageIndex = 1;
                    nodecon.SelectedImageIndex = 1;
                }


            }
        }

        private void Load_Data_TreeView2()
        {
            treeView2.ImageList = TwImgList;
            for (int i = 0; i < bLKhuVuc.LayKhuTro().Rows.Count; i++)
            {
                string item_MaKV = bLKhuVuc.LayKhuTro().Rows[i][0].ToString();
                string item_TenKV = bLKhuVuc.LayKhuTro().Rows[i][1].ToString();

                TreeNode nodecha = treeView2.Nodes.Add(item_TenKV);
                treeView2.Nodes[i].Tag = "1";
                nodecha.ImageIndex = 0;
                for (int j = 0; j < bLPhong.Layphong_TT_MaKV("Trống", item_MaKV).Rows.Count; j++)
                {
                    TreeNode nodecon = treeView2.Nodes[i].Nodes.Add(bLPhong.Layphong_TT_MaKV("Trống", item_MaKV).Rows[j][1].ToString());
                    treeView2.Nodes[i].Nodes[j].Tag = "2";
                    treeView2.Nodes[i].Nodes[j].Name = bLPhong.Layphong_TT_MaKV("Trống", item_MaKV).Rows[j][0].ToString();
                    nodecon.ImageIndex = 1;
                    nodecon.SelectedImageIndex = 1;
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            listKhach.Items.Clear();
            TreeNode theNode = this.treeView1.SelectedNode;
            if (theNode.Tag.ToString() == "2")
            {
                panel2.Visible = false;
                string node = theNode.Name.ToString();
                var list_khach = bLTTKhach.LayThongTinKhachQuaMaPhong(node);
                for (int i = 0; i < list_khach.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(list_khach.Rows[i][0].ToString());
                    if (list_khach.Rows[i][2].ToString() == "Nam") item.ImageIndex = 3; else item.ImageIndex = 2;
                    item.SubItems.Add(list_khach.Rows[i][1].ToString()+" "+ list_khach.Rows[i][2].ToString());
                    item.SubItems.Add(list_khach.Rows[i][4].ToString());
                    item.SubItems.Add(list_khach.Rows[i][6].ToString());
                    item.SubItems.Add(list_khach.Rows[i][7].ToString());
                    listKhach.Items.Add(item);
                }
            }
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listKhach.Items.Clear();
            TreeNode theNode = this.treeView2.SelectedNode;
            string dkphong = theNode.Name.ToString();
            var ttp = bLPhong.LayPhong_MaP(  dkphong );
            if (theNode.Tag.ToString() == "2")
            {
                lbMaphong.Text = dkphong;
                lbLoaiPhong.Text = ttp.Rows[0][1].ToString();
                lbDienTich.Text = ttp.Rows[0][2].ToString();
                lbgia.Text = string.Format("{0:#,##0}", Int32.Parse(ttp.Rows[0][3].ToString()));
                panel2.Visible = true;
            }
        }

        private void listKhach_Click(object sender, EventArgs e)
        {
            ListViewItem item = listKhach.SelectedItems[0];
            string id = item.Text;
            frm_Information frmInfo = new frm_Information(id);
            frmInfo.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            listKhach.Items.Clear();
            Load_Data_TreeView1();
            Load_Data_TreeView2();
            panel2.Visible = false;
        }
       
    }
}
