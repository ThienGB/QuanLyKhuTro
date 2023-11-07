namespace QuanLyNhaTro
{
    partial class TrangThai
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangThai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grTTPT = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaphong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.lbgia = new System.Windows.Forms.Label();
            this.grKhach = new System.Windows.Forms.GroupBox();
            this.listKhach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.TwImgList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grTTPT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grKhach.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.grTTPT);
            this.groupBox1.Controls.Add(this.grKhach);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1439, 743);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.img_170494;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(1355, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(53, 52);
            this.btnRefresh.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refesh data");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grTTPT
            // 
            this.grTTPT.BackColor = System.Drawing.Color.SkyBlue;
            this.grTTPT.Controls.Add(this.panel2);
            this.grTTPT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTPT.ForeColor = System.Drawing.Color.Blue;
            this.grTTPT.Location = new System.Drawing.Point(1033, 59);
            this.grTTPT.Margin = new System.Windows.Forms.Padding(4);
            this.grTTPT.Name = "grTTPT";
            this.grTTPT.Padding = new System.Windows.Forms.Padding(4);
            this.grTTPT.Size = new System.Drawing.Size(431, 318);
            this.grTTPT.TabIndex = 5;
            this.grTTPT.TabStop = false;
            this.grTTPT.Text = "Thông tin phòng trống";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DiaChi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbMaphong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbLoaiPhong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbDienTich);
            this.panel2.Controls.Add(this.lbgia);
            this.panel2.Location = new System.Drawing.Point(8, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 282);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // DiaChi
            // 
            this.DiaChi.BackColor = System.Drawing.Color.White;
            this.DiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.ForeColor = System.Drawing.Color.Blue;
            this.DiaChi.Location = new System.Drawing.Point(165, 191);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(202, 76);
            this.DiaChi.TabIndex = 5;
            this.DiaChi.Text = "......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá (vnd):";
            // 
            // lbMaphong
            // 
            this.lbMaphong.AutoSize = true;
            this.lbMaphong.BackColor = System.Drawing.Color.White;
            this.lbMaphong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaphong.ForeColor = System.Drawing.Color.Blue;
            this.lbMaphong.Location = new System.Drawing.Point(165, 30);
            this.lbMaphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaphong.Name = "lbMaphong";
            this.lbMaphong.Size = new System.Drawing.Size(46, 24);
            this.lbMaphong.TabIndex = 3;
            this.lbMaphong.Text = "......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Diện tích:";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.BackColor = System.Drawing.Color.White;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.lbLoaiPhong.Location = new System.Drawing.Point(165, 66);
            this.lbLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(46, 24);
            this.lbLoaiPhong.TabIndex = 3;
            this.lbLoaiPhong.Text = "......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loại phòng:";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.BackColor = System.Drawing.Color.White;
            this.lbDienTich.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienTich.ForeColor = System.Drawing.Color.Blue;
            this.lbDienTich.Location = new System.Drawing.Point(165, 107);
            this.lbDienTich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(46, 24);
            this.lbDienTich.TabIndex = 3;
            this.lbDienTich.Text = "......";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.BackColor = System.Drawing.Color.White;
            this.lbgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgia.ForeColor = System.Drawing.Color.Blue;
            this.lbgia.Location = new System.Drawing.Point(165, 144);
            this.lbgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(46, 24);
            this.lbgia.TabIndex = 3;
            this.lbgia.Text = "......";
            // 
            // grKhach
            // 
            this.grKhach.BackColor = System.Drawing.Color.SkyBlue;
            this.grKhach.Controls.Add(this.listKhach);
            this.grKhach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grKhach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grKhach.ForeColor = System.Drawing.Color.Green;
            this.grKhach.Location = new System.Drawing.Point(27, 418);
            this.grKhach.Margin = new System.Windows.Forms.Padding(4);
            this.grKhach.Name = "grKhach";
            this.grKhach.Padding = new System.Windows.Forms.Padding(4);
            this.grKhach.Size = new System.Drawing.Size(1395, 297);
            this.grKhach.TabIndex = 3;
            this.grKhach.TabStop = false;
            this.grKhach.Text = "Danh sách khách thuê";
            // 
            // listKhach
            // 
            this.listKhach.BackColor = System.Drawing.Color.LightBlue;
            this.listKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKhach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
            this.listKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKhach.FullRowSelect = true;
            this.listKhach.GridLines = true;
            this.listKhach.HideSelection = false;
            this.listKhach.Location = new System.Drawing.Point(4, 29);
            this.listKhach.Margin = new System.Windows.Forms.Padding(4);
            this.listKhach.MultiSelect = false;
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(1387, 264);
            this.listKhach.TabIndex = 0;
            this.listKhach.UseCompatibleStateImageBehavior = false;
            this.listKhach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày sinh";
            this.columnHeader7.Width = 116;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quê quán";
            this.columnHeader9.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nghề nghiệp";
            this.columnHeader8.Width = 149;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(17, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(989, 345);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRẠNG THÁI THUÊ PHÒNG TRỌ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.treeView2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(481, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(496, 299);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách các phòng còn trống";
            // 
            // treeView2
            // 
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.TwImgList;
            this.treeView2.Location = new System.Drawing.Point(8, 47);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4);
            this.treeView2.Name = "treeView2";
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(480, 242);
            this.treeView2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.treeView2, "Danh sách phòng trống ");
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // TwImgList
            // 
            this.TwImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TwImgList.ImageStream")));
            this.TwImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.TwImgList.Images.SetKeyName(0, "Places-user-home-icon.png");
            this.TwImgList.Images.SetKeyName(1, "house-icon.png");
            this.TwImgList.Images.SetKeyName(2, "Age-Child-Female-Light-icon.png");
            this.TwImgList.Images.SetKeyName(3, "Age-Child-Male-Light-icon.png");
            this.TwImgList.Images.SetKeyName(4, "Actions-document-edit-icon.png");
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(0, 32);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(465, 299);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách các phòng đã được thuê";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.TwImgList;
            this.treeView1.Location = new System.Drawing.Point(8, 39);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(452, 249);
            this.treeView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.treeView1, "Danh sách phòng đã thuê");
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái phòng ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            this.columnHeader3.Width = 129;
            // 
            // TrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangThai";
            this.Size = new System.Drawing.Size(1468, 756);
            this.toolTip1.SetToolTip(this, "Refresh data");
            this.Load += new System.EventHandler(this.TrangThai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grTTPT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grKhach.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.GroupBox grTTPT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.GroupBox grKhach;
        private System.Windows.Forms.ListView listKhach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ImageList TwImgList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
