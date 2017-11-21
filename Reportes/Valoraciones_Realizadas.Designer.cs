namespace Desk.Reportes
{
    partial class Valoraciones_Realizadas
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
            this.valoracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ValoracionesRealizadas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // valoracionBindingSource
            // 
            this.valoracionBindingSource.DataSource = typeof(Desk.Service_Valoracion.valoracion);
            // 
            // ValoracionesRealizadas
            // 
            this.ValoracionesRealizadas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Valoraciones_Realizadas";
            reportDataSource1.Value = this.valoracionBindingSource;
            this.ValoracionesRealizadas.LocalReport.DataSources.Add(reportDataSource1);
            this.ValoracionesRealizadas.LocalReport.ReportEmbeddedResource = "Desk.View.Valoraciones_Realizadas.rdlc";
            this.ValoracionesRealizadas.Location = new System.Drawing.Point(0, 0);
            this.ValoracionesRealizadas.Name = "ValoracionesRealizadas";
            this.ValoracionesRealizadas.Size = new System.Drawing.Size(713, 468);
            this.ValoracionesRealizadas.TabIndex = 0;
            this.ValoracionesRealizadas.Load += new System.EventHandler(this.ValoracionesRealizadas_Load);
            // 
            // Valoraciones_Realizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 468);
            this.Controls.Add(this.ValoracionesRealizadas);
            this.Name = "Valoraciones_Realizadas";
            this.Text = "Valoraciones_Realizadas";
            this.Load += new System.EventHandler(this.Valoraciones_Realizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valoracionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ValoracionesRealizadas;
        private System.Windows.Forms.BindingSource valoracionBindingSource;
    }
}