namespace Desk.Reportes
{
    partial class Reporte_Locales
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
            this.localBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteLocales = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // localBindingSource
            // 
            this.localBindingSource.DataSource = typeof(Desk.Service_Local.local);
            // 
            // ReporteLocales
            // 
            this.ReporteLocales.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.localBindingSource;
            this.ReporteLocales.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteLocales.LocalReport.ReportEmbeddedResource = "Desk.View.Reporte_Locales.rdlc";
            this.ReporteLocales.Location = new System.Drawing.Point(0, 0);
            this.ReporteLocales.Name = "ReporteLocales";
            this.ReporteLocales.Size = new System.Drawing.Size(712, 466);
            this.ReporteLocales.TabIndex = 0;
            this.ReporteLocales.Load += new System.EventHandler(this.ReporteLocales_Load);
            // 
            // Reporte_Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 466);
            this.Controls.Add(this.ReporteLocales);
            this.Name = "Reporte_Locales";
            this.Text = "Panel_Primario";
            this.Load += new System.EventHandler(this.Reporte_Locales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteLocales;
        private System.Windows.Forms.BindingSource localBindingSource;
    }
}