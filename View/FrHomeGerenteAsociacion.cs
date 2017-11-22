using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Desk.Reportes;

namespace Desk.View
{
    public partial class FrHomeGerenteAsociacion : Form
    {
        Service_Empresa.EmpresaServiceClient empresaService = new Service_Empresa.EmpresaServiceClient();


        public FrHomeGerenteAsociacion()
        {
            InitializeComponent();
            
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrLogin logi = new FrLogin();
            logi.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrLogin lo = new FrLogin();
            lo.ShowDialog();
            this.Close();
        }
        
        private void reporteLocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Locales local = new Reporte_Locales();
            PanelPrincipal.Controls.Clear();
            local.TopLevel = false;
            local.Parent = PanelPrincipal;
            local.FormBorderStyle = FormBorderStyle.None;
            local.Dock = DockStyle.Fill;
            local.Show();
        }

        private void usuariosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Usuarios_Registrados usu = new Usuarios_Registrados();
            PanelPrincipal.Controls.Clear();
            usu.TopLevel = false;
            usu.Parent = PanelPrincipal;
            usu.FormBorderStyle = FormBorderStyle.None;
            usu.Dock = DockStyle.Fill;
            usu.Show();
        }

        private void descuentosEntregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descuentos_Entregados des = new Descuentos_Entregados();
            PanelPrincipal.Controls.Clear();
            des.TopLevel = false;
            des.Parent = PanelPrincipal;
            des.FormBorderStyle = FormBorderStyle.None;
            des.Dock = DockStyle.Fill;
            des.Show();
        }

        private void valoracionesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Valoraciones_Realizadas valo = new Valoraciones_Realizadas();
            PanelPrincipal.Controls.Clear();
            valo.TopLevel = false;
            valo.Parent = PanelPrincipal;
            valo.FormBorderStyle = FormBorderStyle.None;
            valo.Dock = DockStyle.Fill;
            valo.Show();
        }
    }
}
