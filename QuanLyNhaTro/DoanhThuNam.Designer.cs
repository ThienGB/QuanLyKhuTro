namespace QuanLyNhaTro
{
    partial class DoanhThuNam
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
            this.dgvDoanhThuNam = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThuNam
            // 
            this.dgvDoanhThuNam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoanhThuNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuNam.Location = new System.Drawing.Point(12, 183);
            this.dgvDoanhThuNam.Name = "dgvDoanhThuNam";
            this.dgvDoanhThuNam.RowHeadersWidth = 51;
            this.dgvDoanhThuNam.RowTemplate.Height = 24;
            this.dgvDoanhThuNam.Size = new System.Drawing.Size(863, 418);
            this.dgvDoanhThuNam.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_title.Location = new System.Drawing.Point(283, 62);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(297, 45);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Doanh thu năm";
            // 
            // DoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 613);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgvDoanhThuNam);
            this.Name = "DoanhThuNam";
            this.Text = "DoanhThuNam";
            this.Load += new System.EventHandler(this.DoanhThuNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThuNam;
        private System.Windows.Forms.Label lbl_title;
    }
}