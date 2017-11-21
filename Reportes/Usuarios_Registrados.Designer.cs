namespace Desk.Reportes
{
    partial class Usuarios_Registrados
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
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuariosRegistrados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Desk.Service_Usuario.usuario);
            // 
            // UsuariosRegistrados
            // 
            this.UsuariosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Usuarios";
            reportDataSource1.Value = this.clienteBindingSource;
            this.UsuariosRegistrados.LocalReport.DataSources.Add(reportDataSource1);
            this.UsuariosRegistrados.LocalReport.ReportEmbeddedResource = "Desk.Reportes.Report1.rdlc";
            this.UsuariosRegistrados.Location = new System.Drawing.Point(0, 0);
            this.UsuariosRegistrados.Name = "UsuariosRegistrados";
            this.UsuariosRegistrados.Size = new System.Drawing.Size(708, 428);
            this.UsuariosRegistrados.TabIndex = 0;
            this.UsuariosRegistrados.Load += new System.EventHandler(this.UsuariosRegistrados_Load);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Desk.Service_Usuario.cliente);
            // 
            // Usuarios_Registrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 428);
            this.Controls.Add(this.UsuariosRegistrados);
            this.Name = "Usuarios_Registrados";
            this.Text = "Usuarios_Registrados";
            this.Load += new System.EventHandler(this.Usuarios_Registrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer UsuariosRegistrados;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
    }
}