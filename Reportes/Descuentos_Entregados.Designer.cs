namespace Desk.Reportes
{
    partial class Descuentos_Entregados
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
            this.descuentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescuentosEntregados = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descuentoBindingSource
            // 
            this.descuentoBindingSource.DataSource = typeof(Desk.Service_Descuento.descuento);
            // 
            // DescuentosEntregados
            // 
            this.DescuentosEntregados.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDescuento";
            reportDataSource1.Value = this.descuentoBindingSource;
            this.DescuentosEntregados.LocalReport.DataSources.Add(reportDataSource1);
            this.DescuentosEntregados.LocalReport.ReportEmbeddedResource = "Desk.Reportes.Descuentos_Entregados.rdlc";
            this.DescuentosEntregados.Location = new System.Drawing.Point(0, 0);
            this.DescuentosEntregados.Name = "DescuentosEntregados";
            this.DescuentosEntregados.Size = new System.Drawing.Size(714, 501);
            this.DescuentosEntregados.TabIndex = 0;
            this.DescuentosEntregados.Load += new System.EventHandler(this.DescuentosEntregados_Load);
            // 
            // Descuentos_Entregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 501);
            this.Controls.Add(this.DescuentosEntregados);
            this.Name = "Descuentos_Entregados";
            this.Text = "Descuentos_Entregados";
            this.Load += new System.EventHandler(this.Descuentos_Entregados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descuentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DescuentosEntregados;
        private System.Windows.Forms.BindingSource descuentoBindingSource;
    }
}