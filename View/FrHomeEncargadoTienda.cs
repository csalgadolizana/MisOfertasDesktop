using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.View
{
    public partial class FrHomeEncargadoTienda : Form
    {
        public FrHomeEncargadoTienda()
        {
            InitializeComponent();
        }
                
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLimpiarAO_Click(object sender, EventArgs e)
        {
            txtNombreOferta.Text = "";
            txtDescipcionOferta.Text = "";
            txtPrecioNormal.Text = "";
            txtPrecioOferta.Text = "";
            txtVisitas.Text = "";
            txtMinCompras.Text = "";
            txtMaxCompra.Text = "";
            dtInicioOferta.Value = DateTime.Now;
            dtActualizacionOferta.Value = DateTime.Now;
         
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Service_Oferta.OfertaServiceClient ofer = new Service_Oferta.OfertaServiceClient();
            ofer.Crear_oferta(0, txtNombreOferta.Text, txtDescipcionOferta.Text, int.Parse(txtPrecioNormal.ToString()), int.Parse(txtPrecioOferta.Text, int.Parse(txtMinCompras.ToString()), int.Parse(txtMaxCompra.ToString()), DateTime.Parse(dtInicioOferta.Value.ToShortDateString()), DateTime.Parse(dtActualizacionOferta.Value.ToShortDateString(),1);
            //listar Oferta
            Service_Oferta.oferta oferta1 = ofer.Listado_oferta().OrderByDescending(x => x.idOferta).First();
            MessageBox.Show("Oferta " + oferta1.idOferta);            
        }
    }
}
