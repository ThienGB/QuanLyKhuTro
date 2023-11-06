namespace QuanLyNhaTro
{
    partial class frm_MyApp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MyApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_guest = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyNhaTro.Properties.Resources.motel2;
            this.pictureBox1.Location = new System.Drawing.Point(-52, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_guest
            // 
            this.btn_guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guest.Location = new System.Drawing.Point(60, 203);
            this.btn_guest.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Padding = new System.Windows.Forms.Padding(3);
            this.btn_guest.Size = new System.Drawing.Size(174, 85);
            this.btn_guest.TabIndex = 2;
            this.btn_guest.Text = "Đăng ký phòng";
            this.btn_guest.UseVisualStyleBackColor = false;
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.Location = new System.Drawing.Point(612, 203);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Admin.Size = new System.Drawing.Size(174, 85);
            this.btn_Admin.TabIndex = 3;
            this.btn_Admin.Text = "Chủ trọ";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(50, 40);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(725, 55);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "PHẦN MỀM QUẢN LÝ NHÀ TRỌ";
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(360, 133);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(0, 16);
            this.lbl_select.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(174, 85);
            this.button1.TabIndex = 6;
            this.button1.Text = "Khách thuê ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_MyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_guest);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MyApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_guest;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Button button1;
    }
}