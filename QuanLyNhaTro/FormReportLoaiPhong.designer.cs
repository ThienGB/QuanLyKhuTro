namespace QuanLyNhaTro
{
    partial class FormReportLoaiPhong
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.thongKe = new QuanLyNhaTro.ThongKe();
            this.loaiPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiPhongTableAdapter = new QuanLyNhaTro.ThongKeTableAdapters.LoaiPhongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.loaiPhongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyNhaTro.ReportLoaiPhong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(886, 516);
            this.reportViewer1.TabIndex = 0;
            // 
            // thongKe
            // 
            this.thongKe.DataSetName = "ThongKe";
            this.thongKe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiPhongBindingSource
            // 
            this.loaiPhongBindingSource.DataMember = "LoaiPhong";
            this.loaiPhongBindingSource.DataSource = this.thongKe;
            // 
            // loaiPhongTableAdapter
            // 
            this.loaiPhongTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportLoaiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportLoaiPhong";
            this.Load += new System.EventHandler(this.FormReportLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ThongKe thongKe;
        private System.Windows.Forms.BindingSource loaiPhongBindingSource;
        private ThongKeTableAdapters.LoaiPhongTableAdapter loaiPhongTableAdapter;
    }
}