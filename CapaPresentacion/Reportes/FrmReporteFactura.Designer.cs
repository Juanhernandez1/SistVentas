namespace CapaPresentacion
{
    partial class FrmReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteFactura));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sdPrincipal = new CapaPresentacion.sdPrincipal();
            this.sp_reporte_factura1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_reporte_factura1TableAdapter = new CapaPresentacion.sdPrincipalTableAdapters.sp_reporte_factura1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sdPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_factura1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSGenerarFactura";
            reportDataSource1.Value = this.sp_reporte_factura1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.GenerarFacturardlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 547);
            this.reportViewer1.TabIndex = 0;
            // 
            // sdPrincipal
            // 
            this.sdPrincipal.DataSetName = "sdPrincipal";
            this.sdPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_reporte_factura1BindingSource
            // 
            this.sp_reporte_factura1BindingSource.DataMember = "sp_reporte_factura1";
            this.sp_reporte_factura1BindingSource.DataSource = this.sdPrincipal;
            // 
            // sp_reporte_factura1TableAdapter
            // 
            this.sp_reporte_factura1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 547);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sdPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_reporte_factura1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_reporte_factura1BindingSource;
        private sdPrincipal sdPrincipal;
        private sdPrincipalTableAdapters.sp_reporte_factura1TableAdapter sp_reporte_factura1TableAdapter;
    }
}