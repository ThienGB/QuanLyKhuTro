namespace QuanLyNhaTro
{
    partial class TinhTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhTien));
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.TwImgList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHD = new System.Windows.Forms.Label();
            this.dtLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pSoNguoi = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienNuoc2 = new System.Windows.Forms.TextBox();
            this.rdSoNguoi = new System.Windows.Forms.RadioButton();
            this.rdNuoc = new System.Windows.Forms.RadioButton();
            this.nuoc_cbSoKhoi = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoKhoi = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTienDien2 = new System.Windows.Forms.TextBox();
            this.Dien_cbSoKi = new System.Windows.Forms.CheckBox();
            this.txtSoKi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTienNha = new System.Windows.Forms.TextBox();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.cbMaKhachThue = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.dtNgayThue = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pSoNguoi.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Location = new System.Drawing.Point(174, 11);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(175, 33);
            this.cbKhuVuc.TabIndex = 25;
            this.cbKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbKhuVuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chọn khu vực";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.lvPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1583, 130);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng chưa lập hóa đơn";
            // 
            // lvPhong
            // 
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.HideSelection = false;
            this.lvPhong.LargeImageList = this.TwImgList;
            this.lvPhong.Location = new System.Drawing.Point(3, 26);
            this.lvPhong.Margin = new System.Windows.Forms.Padding(4);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(1577, 101);
            this.lvPhong.TabIndex = 2;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            this.lvPhong.SelectedIndexChanged += new System.EventHandler(this.lvPhong_SelectedIndexChanged);
            this.lvPhong.Click += new System.EventHandler(this.lvPhong_Click);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.lblHD);
            this.groupBox2.Controls.Add(this.dtLapHoaDon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(17, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1539, 606);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHD.ForeColor = System.Drawing.Color.Black;
            this.lblHD.Location = new System.Drawing.Point(664, -2);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(146, 29);
            this.lblHD.TabIndex = 28;
            this.lblHD.Text = "Lập hóa đơn";
            // 
            // dtLapHoaDon
            // 
            this.dtLapHoaDon.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLapHoaDon.Enabled = false;
            this.dtLapHoaDon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLapHoaDon.Location = new System.Drawing.Point(252, 43);
            this.dtLapHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtLapHoaDon.Name = "dtLapHoaDon";
            this.dtLapHoaDon.Size = new System.Drawing.Size(168, 32);
            this.dtLapHoaDon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày lập hóa đơn:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnTinh);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtTienNha);
            this.groupBox4.Controls.Add(this.txtTongCong);
            this.groupBox4.Controls.Add(this.txtLoaiPhong);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox4.Location = new System.Drawing.Point(861, 68);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(580, 453);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DỊCH VỤ SỬ DỤNG";
            // 
            // btnTinh
            // 
            this.btnTinh.ForeColor = System.Drawing.Color.Black;
            this.btnTinh.Location = new System.Drawing.Point(41, 379);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(96, 41);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pSoNguoi);
            this.groupBox6.Controls.Add(this.rdSoNguoi);
            this.groupBox6.Controls.Add(this.rdNuoc);
            this.groupBox6.Controls.Add(this.nuoc_cbSoKhoi);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtSoKhoi);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.txtTienNuoc);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(29, 202);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(536, 143);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tiền nước:";
            // 
            // pSoNguoi
            // 
            this.pSoNguoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSoNguoi.Controls.Add(this.label15);
            this.pSoNguoi.Controls.Add(this.txtSoNguoi);
            this.pSoNguoi.Controls.Add(this.label8);
            this.pSoNguoi.Controls.Add(this.txtTienNuoc2);
            this.pSoNguoi.Location = new System.Drawing.Point(3, 78);
            this.pSoNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.pSoNguoi.Name = "pSoNguoi";
            this.pSoNguoi.Size = new System.Drawing.Size(532, 47);
            this.pSoNguoi.TabIndex = 5;
            this.pSoNguoi.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGreen;
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Số người:";
            // 
            // txtSoNguoi
            // 
            this.txtSoNguoi.Enabled = false;
            this.txtSoNguoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNguoi.Location = new System.Drawing.Point(159, 9);
            this.txtSoNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNguoi.Name = "txtSoNguoi";
            this.txtSoNguoi.Size = new System.Drawing.Size(99, 27);
            this.txtSoNguoi.TabIndex = 2;
            this.txtSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(295, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Thành tiền:";
            // 
            // txtTienNuoc2
            // 
            this.txtTienNuoc2.Enabled = false;
            this.txtTienNuoc2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNuoc2.Location = new System.Drawing.Point(411, 11);
            this.txtTienNuoc2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNuoc2.Name = "txtTienNuoc2";
            this.txtTienNuoc2.Size = new System.Drawing.Size(112, 27);
            this.txtTienNuoc2.TabIndex = 2;
            // 
            // rdSoNguoi
            // 
            this.rdSoNguoi.AutoSize = true;
            this.rdSoNguoi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoNguoi.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdSoNguoi.Location = new System.Drawing.Point(301, 30);
            this.rdSoNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.rdSoNguoi.Name = "rdSoNguoi";
            this.rdSoNguoi.Size = new System.Drawing.Size(106, 27);
            this.rdSoNguoi.TabIndex = 4;
            this.rdSoNguoi.Text = "Số người";
            this.rdSoNguoi.UseVisualStyleBackColor = true;
            this.rdSoNguoi.CheckedChanged += new System.EventHandler(this.rdSoNguoi_CheckedChanged);
            // 
            // rdNuoc
            // 
            this.rdNuoc.AutoSize = true;
            this.rdNuoc.Checked = true;
            this.rdNuoc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNuoc.ForeColor = System.Drawing.Color.DarkGreen;
            this.rdNuoc.Location = new System.Drawing.Point(172, 32);
            this.rdNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.rdNuoc.Name = "rdNuoc";
            this.rdNuoc.Size = new System.Drawing.Size(92, 27);
            this.rdNuoc.TabIndex = 4;
            this.rdNuoc.TabStop = true;
            this.rdNuoc.Text = "Số khối";
            this.rdNuoc.UseVisualStyleBackColor = true;
            this.rdNuoc.CheckedChanged += new System.EventHandler(this.rdNuoc_CheckedChanged);
            // 
            // nuoc_cbSoKhoi
            // 
            this.nuoc_cbSoKhoi.AutoSize = true;
            this.nuoc_cbSoKhoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuoc_cbSoKhoi.ForeColor = System.Drawing.Color.Black;
            this.nuoc_cbSoKhoi.Location = new System.Drawing.Point(43, 81);
            this.nuoc_cbSoKhoi.Margin = new System.Windows.Forms.Padding(4);
            this.nuoc_cbSoKhoi.Name = "nuoc_cbSoKhoi";
            this.nuoc_cbSoKhoi.Size = new System.Drawing.Size(126, 25);
            this.nuoc_cbSoKhoi.TabIndex = 3;
            this.nuoc_cbSoKhoi.Text = "Số khối nước";
            this.nuoc_cbSoKhoi.UseVisualStyleBackColor = true;
            this.nuoc_cbSoKhoi.CheckedChanged += new System.EventHandler(this.nuoc_cbSoKhoi_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tính theo:";
            // 
            // txtSoKhoi
            // 
            this.txtSoKhoi.Enabled = false;
            this.txtSoKhoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKhoi.Location = new System.Drawing.Point(185, 78);
            this.txtSoKhoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoKhoi.Name = "txtSoKhoi";
            this.txtSoKhoi.Size = new System.Drawing.Size(81, 27);
            this.txtSoKhoi.TabIndex = 2;
            this.txtSoKhoi.TextChanged += new System.EventHandler(this.txtSoKhoi_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(305, 86);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 21);
            this.label23.TabIndex = 1;
            this.label23.Text = "Thành tiền:";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Enabled = false;
            this.txtTienNuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNuoc.Location = new System.Drawing.Point(428, 79);
            this.txtTienNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(103, 27);
            this.txtTienNuoc.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtTienDien2);
            this.groupBox5.Controls.Add(this.Dien_cbSoKi);
            this.groupBox5.Controls.Add(this.txtSoKi);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(29, 76);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(536, 121);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tiền điện:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(297, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "Thành tiền:";
            // 
            // txtTienDien2
            // 
            this.txtTienDien2.Enabled = false;
            this.txtTienDien2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDien2.Location = new System.Drawing.Point(416, 54);
            this.txtTienDien2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienDien2.Name = "txtTienDien2";
            this.txtTienDien2.Size = new System.Drawing.Size(115, 27);
            this.txtTienDien2.TabIndex = 2;
            // 
            // Dien_cbSoKi
            // 
            this.Dien_cbSoKi.AutoSize = true;
            this.Dien_cbSoKi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dien_cbSoKi.ForeColor = System.Drawing.Color.Black;
            this.Dien_cbSoKi.Location = new System.Drawing.Point(43, 57);
            this.Dien_cbSoKi.Margin = new System.Windows.Forms.Padding(4);
            this.Dien_cbSoKi.Name = "Dien_cbSoKi";
            this.Dien_cbSoKi.Size = new System.Drawing.Size(104, 25);
            this.Dien_cbSoKi.TabIndex = 3;
            this.Dien_cbSoKi.Text = "Số kí điện";
            this.Dien_cbSoKi.UseVisualStyleBackColor = true;
            this.Dien_cbSoKi.CheckedChanged += new System.EventHandler(this.Dien_cbSoKi_CheckedChanged);
            // 
            // txtSoKi
            // 
            this.txtSoKi.Enabled = false;
            this.txtSoKi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoKi.Location = new System.Drawing.Point(161, 54);
            this.txtSoKi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoKi.Name = "txtSoKi";
            this.txtSoKi.Size = new System.Drawing.Size(81, 27);
            this.txtSoKi.TabIndex = 2;
            this.txtSoKi.TextChanged += new System.EventHandler(this.txtSoKi_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(196, 388);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 24);
            this.label19.TabIndex = 1;
            this.label19.Text = "Tổng cộng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(347, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tiền nhà:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(25, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Loại phòng";
            // 
            // txtTienNha
            // 
            this.txtTienNha.Enabled = false;
            this.txtTienNha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNha.Location = new System.Drawing.Point(453, 36);
            this.txtTienNha.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienNha.Name = "txtTienNha";
            this.txtTienNha.Size = new System.Drawing.Size(117, 27);
            this.txtTienNha.TabIndex = 2;
            // 
            // txtTongCong
            // 
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.Location = new System.Drawing.Point(343, 388);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(221, 27);
            this.txtTongCong.TabIndex = 2;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(140, 38);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(173, 27);
            this.txtLoaiPhong.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtNS);
            this.groupBox3.Controls.Add(this.txtSoluong);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNN);
            this.groupBox3.Controls.Add(this.cbMaKhachThue);
            this.groupBox3.Controls.Add(this.txtCMND);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(466, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(360, 453);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN CHỦ THUÊ";
            // 
            // txtNS
            // 
            this.txtNS.Enabled = false;
            this.txtNS.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNS.Location = new System.Drawing.Point(144, 249);
            this.txtNS.Margin = new System.Windows.Forms.Padding(4);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(203, 27);
            this.txtNS.TabIndex = 2;
            this.txtNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(217, 25);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(133, 27);
            this.txtSoluong.TabIndex = 2;
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(59, 252);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nơi sinh:";
            // 
            // txtNN
            // 
            this.txtNN.Enabled = false;
            this.txtNN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNN.Location = new System.Drawing.Point(144, 192);
            this.txtNN.Margin = new System.Windows.Forms.Padding(4);
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(203, 27);
            this.txtNN.TabIndex = 2;
            this.txtNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMaKhachThue
            // 
            this.cbMaKhachThue.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhachThue.FormattingEnabled = true;
            this.cbMaKhachThue.Location = new System.Drawing.Point(144, 79);
            this.cbMaKhachThue.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaKhachThue.Name = "cbMaKhachThue";
            this.cbMaKhachThue.Size = new System.Drawing.Size(203, 29);
            this.cbMaKhachThue.TabIndex = 2;
            this.cbMaKhachThue.SelectedIndexChanged += new System.EventHandler(this.cbMaKhachThue_SelectedIndexChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(144, 134);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(203, 27);
            this.txtCMND.TabIndex = 2;
            this.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(29, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nghề nghiệp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên người thuê:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng người hiện tại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(72, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "CMND:";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.btnLuuHoaDon);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txtMaPhong);
            this.groupBox7.Controls.Add(this.dtNgayThue);
            this.groupBox7.Controls.Add(this.txtTenPhong);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox7.Location = new System.Drawing.Point(60, 97);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(360, 424);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "THÔNG TIN PHÒNG THUÊ";
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnLuuHoaDon.Location = new System.Drawing.Point(60, 321);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(145, 80);
            this.btnLuuHoaDon.TabIndex = 4;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày thuê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhong.Location = new System.Drawing.Point(144, 36);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(181, 27);
            this.txtMaPhong.TabIndex = 2;
            this.txtMaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtNgayThue
            // 
            this.dtNgayThue.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThue.Enabled = false;
            this.dtNgayThue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThue.Location = new System.Drawing.Point(144, 133);
            this.dtNgayThue.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayThue.Name = "dtNgayThue";
            this.dtNgayThue.Size = new System.Drawing.Size(181, 32);
            this.dtNgayThue.TabIndex = 3;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(144, 84);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(181, 27);
            this.txtTenPhong.TabIndex = 2;
            this.txtTenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã phòng:";
            // 
            // TinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbKhuVuc);
            this.Controls.Add(this.label1);
            this.Name = "TinhTien";
            this.Size = new System.Drawing.Size(1583, 830);
            this.Load += new System.EventHandler(this.TinhTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pSoNguoi.ResumeLayout(false);
            this.pSoNguoi.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.DateTimePicker dtLapHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTienNuoc2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdSoNguoi;
        private System.Windows.Forms.RadioButton rdNuoc;
        private System.Windows.Forms.CheckBox nuoc_cbSoKhoi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSoKhoi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTienDien2;
        private System.Windows.Forms.CheckBox Dien_cbSoKi;
        private System.Windows.Forms.TextBox txtSoKi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTienNha;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.ComboBox cbMaKhachThue;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.DateTimePicker dtNgayThue;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pSoNguoi;
        private System.Windows.Forms.ImageList TwImgList;
    }
}
