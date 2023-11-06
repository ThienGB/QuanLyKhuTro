namespace QuanLyNhaTro
{
    partial class frm_TKNgThue
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TKNgThue));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKe = new QuanLyNhaTro.ThongKe();
            this.thongTinKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinKhachTableAdapter = new QuanLyNhaTro.ThongKeTableAdapters.ThongTinKhachTableAdapter();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKhachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.thongTinKhachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportTTKhach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 587);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongKe
            // 
            this.thongKe.DataSetName = "ThongKe";
            this.thongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinKhachBindingSource
            // 
            this.thongTinKhachBindingSource.DataMember = "ThongTinKhach";
            this.thongTinKhachBindingSource.DataSource = this.thongKe;
            // 
            // thongTinKhachTableAdapter
            // 
            this.thongTinKhachTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ShowAll.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.Users_icon;
            this.btn_ShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowAll.Location = new System.Drawing.Point(541, 5);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(75, 70);
            this.btn_ShowAll.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btn_ShowAll, "Hiện danh sách tất cả khách hàng ");
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập mã khách ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhach.Location = new System.Drawing.Point(214, 27);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(145, 26);
            this.txtMaKhach.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtMaKhach, "Nhập mã khách hàng");
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackgroundImage = global::QuanLyNhaTro.Properties.Resources.OIP__3__removebg_preview;
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(377, 24);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(35, 32);
            this.btn_Tim.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_Tim, "Tìm kiếm");
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // frm_TKNgThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1200, 693);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_TKNgThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TKNgThue";
            this.Load += new System.EventHandler(this.frm_TKNgThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKhachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ThongKe thongKe;
        private System.Windows.Forms.BindingSource thongTinKhachBindingSource;
        private ThongKeTableAdapters.ThongTinKhachTableAdapter thongTinKhachTableAdapter;
        private System.Windows.Forms.Button btn_ShowAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Button btn_Tim;
    }
}