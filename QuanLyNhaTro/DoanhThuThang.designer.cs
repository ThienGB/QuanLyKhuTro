namespace QuanLyNhaTro
{
    partial class DoanhThuThang
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
            this.dgvDoanhThuThang = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThuThang
            // 
            this.dgvDoanhThuThang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoanhThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuThang.Location = new System.Drawing.Point(12, 183);
            this.dgvDoanhThuThang.Name = "dgvDoanhThuThang";
            this.dgvDoanhThuThang.RowHeadersWidth = 51;
            this.dgvDoanhThuThang.RowTemplate.Height = 24;
            this.dgvDoanhThuThang.Size = new System.Drawing.Size(863, 418);
            this.dgvDoanhThuThang.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(239, 52);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(400, 55);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Doanh thu tháng";
            // 
            // DoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 613);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgvDoanhThuThang);
            this.Name = "DoanhThuThang";
            this.Text = "DoanhThuThang";
            this.Load += new System.EventHandler(this.DoanhThuThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThuThang;
        private System.Windows.Forms.Label lbl_title;
    }
}