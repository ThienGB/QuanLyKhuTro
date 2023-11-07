namespace QuanLyNhaTro
{
    partial class frm_XemTienPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvThang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMPT = new System.Windows.Forms.Label();
            this.lblNLPT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPMT = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTN = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.lblPDV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.lvThang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(226, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tháng";
            // 
            // lvThang
            // 
            this.lvThang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThang.FullRowSelect = true;
            this.lvThang.HideSelection = false;
            this.lvThang.Location = new System.Drawing.Point(25, 41);
            this.lvThang.Margin = new System.Windows.Forms.Padding(4);
            this.lvThang.Name = "lvThang";
            this.lvThang.Size = new System.Drawing.Size(176, 384);
            this.lvThang.TabIndex = 1;
            this.lvThang.UseCompatibleStateImageBehavior = false;
            this.lvThang.View = System.Windows.Forms.View.Details;
            this.lvThang.Click += new System.EventHandler(this.lvThang_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tháng";
            this.columnHeader1.Width = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(501, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Xem tiền phòng";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(39, 67);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(173, 29);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Mã phòng trọ:";
            // 
            // lblMPT
            // 
            this.lblMPT.AutoSize = true;
            this.lblMPT.BackColor = System.Drawing.Color.Azure;
            this.lblMPT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPT.Location = new System.Drawing.Point(249, 73);
            this.lblMPT.Name = "lblMPT";
            this.lblMPT.Size = new System.Drawing.Size(24, 25);
            this.lblMPT.TabIndex = 22;
            this.lblMPT.Text = "...";
            // 
            // lblNLPT
            // 
            this.lblNLPT.AutoSize = true;
            this.lblNLPT.BackColor = System.Drawing.Color.Azure;
            this.lblNLPT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNLPT.Location = new System.Drawing.Point(249, 139);
            this.lblNLPT.Name = "lblNLPT";
            this.lblNLPT.Size = new System.Drawing.Size(24, 25);
            this.lblNLPT.TabIndex = 24;
            this.lblNLPT.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày lập PT:";
            // 
            // lblPMT
            // 
            this.lblPMT.AutoSize = true;
            this.lblPMT.BackColor = System.Drawing.Color.Azure;
            this.lblPMT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMT.Location = new System.Drawing.Point(249, 207);
            this.lblPMT.Name = "lblPMT";
            this.lblPMT.Size = new System.Drawing.Size(24, 25);
            this.lblPMT.TabIndex = 26;
            this.lblPMT.Text = "...";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(39, 201);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(189, 29);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Phí môi trường:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblTrangThai);
            this.groupBox2.Controls.Add(this.lblTN);
            this.groupBox2.Controls.Add(this.lblSN);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTT);
            this.groupBox2.Controls.Add(this.lblSD);
            this.groupBox2.Controls.Add(this.lblPDV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPMT);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.lblNLPT);
            this.groupBox2.Controls.Add(this.lblMPT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(299, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(945, 455);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "Trạng thái:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(536, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số nước:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.BackColor = System.Drawing.Color.Azure;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(250, 390);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(39, 35);
            this.lblTrangThai.TabIndex = 37;
            this.lblTrangThai.Text = "...";
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.BackColor = System.Drawing.Color.Azure;
            this.lblTN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTN.Location = new System.Drawing.Point(658, 202);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(24, 25);
            this.lblTN.TabIndex = 34;
            this.lblTN.Text = "...";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.Color.Azure;
            this.lblSN.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(658, 136);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(24, 25);
            this.lblSN.TabIndex = 32;
            this.lblSN.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(536, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 29);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tiền nhà:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tổng Tiền:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phí dịch vụ";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.BackColor = System.Drawing.Color.Azure;
            this.lblTT.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.Location = new System.Drawing.Point(702, 276);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(39, 35);
            this.lblTT.TabIndex = 36;
            this.lblTT.Text = "...";
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.BackColor = System.Drawing.Color.Azure;
            this.lblSD.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSD.Location = new System.Drawing.Point(658, 69);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(24, 25);
            this.lblSD.TabIndex = 30;
            this.lblSD.Text = "...";
            // 
            // lblPDV
            // 
            this.lblPDV.AutoSize = true;
            this.lblPDV.BackColor = System.Drawing.Color.Azure;
            this.lblPDV.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDV.Location = new System.Drawing.Point(249, 274);
            this.lblPDV.Name = "lblPDV";
            this.lblPDV.Size = new System.Drawing.Size(24, 25);
            this.lblPDV.TabIndex = 28;
            this.lblPDV.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "Số điện:";
            // 
            // frm_XemTienPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_XemTienPhong";
            this.Size = new System.Drawing.Size(1256, 567);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvThang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMPT;
        private System.Windows.Forms.Label lblNLPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPMT;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblPDV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
