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
    public partial class FrHomeAdmin : Form
    {
        public FrHomeAdmin()
        {
            InitializeComponent();
            cbbCargoUsuario.Items.Clear();

            Service_Cargo.CargoServiceClient cargo = new Service_Cargo.CargoServiceClient();            
            List<Service_Cargo.cargo> lisCargos = cargo.Listado_cargos().ToList();

            foreach (Service_Cargo.cargo item in lisCargos)
            {
                cbbCargoUsuario.Items.Insert(int.Parse(item.idcargo.ToString())-1, item.descripcion);
            }                 
                        
        }             

        private void btnLimpiarAgregar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
            txtApellidoPersona.Text = "";
            txtCorreoUsuario.Text = "";
            txtCorreoUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            txtRutPersona.Text = "";
            cboSexo.Text = "";
            dtFechaInicio.Value = DateTime.Now;
            dtFechaActualizacion.Value = DateTime.Now;
            cbbCargoUsuario.Text = "";                       
        }        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCorreoUsuario.Text = "";
            txtContrasenaUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
            dtFechaInicio.Value = DateTime.Now;
            dtFechaActualizacion.Value = DateTime.Now;            
                        
        }    


        private void btnLimpiarAE_Click_1(object sender, EventArgs e)
        {
            txtRutEmpresa.Text = "";
            txtNombreEmpresa.Text = "";
            txtDescripcionEmpresa.Text = "";
            dtFechaInicioEmpresa.Value = DateTime.Now;
            dtFechaActualizacionEmpresa.Value = DateTime.Now;
            txtEstado.Text = "";
        }
                
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }       

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Service_Persona.PersonaServiceClient perso = new Service_Persona.PersonaServiceClient();
            perso.Crear_persona (0,txtNombrePersona.Text,txtApellidoPersona.Text,txtRutPersona.Text,cboSexo.SelectedIndex +1);
            //perso.Listado_personas();
            Service_Persona.persona persona1 = perso.Listado_personas().OrderByDescending(x=>x.idpersona).First();
            MessageBox.Show("Persona " + persona1.idpersona);

            Service_Usuario.UsuarioServiceClient usu = new Service_Usuario.UsuarioServiceClient();             
            usu.CREAR_USUARIO(0, txtCorreoUsuario.Text, txtContrasenaUsuario.Text, int.Parse(txtTelefonoUsuario.Text), DateTime.Parse(dtFechaInicio.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacion.Value.ToShortDateString()),1,int.Parse(persona1.idpersona.ToString()), cbbCargoUsuario.SelectedIndex +1);
                        
        }

        private void btnGuardaEmpresa_Click(object sender, EventArgs e)
        {
            Service_Empresa.EmpresaServiceClient empre = new Service_Empresa.EmpresaServiceClient();
            //empre.Crear_empresa(0, txtRutEmpresa.Text, txtNombreEmpresa.Text, txtDescripcionEmpresa.Text, DateTime.Parse(dtFechaInicioEmpresa.Value.ToShortDateString()), DateTime.Parse(dtFechaActualizacionEmpresa.Value.ToShortDateString()),txtEstado.Text);

            Service_Empresa.empresa empre1 = empre.Listado_empresa().OrderByDescending(x => x.idEmpresa).First();
            MessageBox.Show("Empresa " + empre1.idEmpresa);
        }
    }
}
