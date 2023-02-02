
namespace WindowsFormsApp3
{
    partial class Form_Report
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
            this.uSPGetHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangThoiTrangDataSet1 = new WindowsFormsApp3.QuanLyCuaHangThoiTrangDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_GetHoaDonTableAdapter = new WindowsFormsApp3.QuanLyCuaHangThoiTrangDataSet1TableAdapters.USP_GetHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangThoiTrangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPGetHoaDonBindingSource
            // 
            this.uSPGetHoaDonBindingSource.DataMember = "USP_GetHoaDon";
            this.uSPGetHoaDonBindingSource.DataSource = this.quanLyCuaHangThoiTrangDataSet1;
            // 
            // quanLyCuaHangThoiTrangDataSet1
            // 
            this.quanLyCuaHangThoiTrangDataSet1.DataSetName = "QuanLyCuaHangThoiTrangDataSet1";
            this.quanLyCuaHangThoiTrangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGetHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(715, 399);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // uSP_GetHoaDonTableAdapter
            // 
            this.uSP_GetHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 402);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangThoiTrangDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPGetHoaDonBindingSource;
        private QuanLyCuaHangThoiTrangDataSet1 quanLyCuaHangThoiTrangDataSet1;
        private QuanLyCuaHangThoiTrangDataSet1TableAdapters.USP_GetHoaDonTableAdapter uSP_GetHoaDonTableAdapter;
    }
}