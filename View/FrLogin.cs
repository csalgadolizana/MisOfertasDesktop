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
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrHomeAdmin home = new FrHomeAdmin();
            home.Show();
            Hide();
        }        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Service_Usuario.UsuarioServiceClient serv = new Service_Usuario.UsuarioServiceClient();
            var usuario = serv.Autenticacion(txtUsuario.Text, txtPassword.Text);
            if (usuario.idUsuario != 0)
            {
                MessageBox.Show("Bienvenido " + usuario.personaIdpersona.nombre);
                FrHomeAdmin admin = new FrHomeAdmin();
                admin.Show();
                Hide();
            }
            else {
                MessageBox.Show("El Correo Electronico o La Contraseña que ingresaste no coinciden con ninguna cuenta. " );
            }
           
            
            if (txtUsuario.Text == "admin" && txtPassword.Text == "admin")
            {
                FrHomeAdmin home = new FrHomeAdmin();
                home.Show();
                Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario y/o Contraseña son Incorrectos ";
            }

            

            if (txtUsuario.Text == "tienda" && txtPassword.Text == "tienda")
            {
                FrHomeEncargadoTienda tien = new FrHomeEncargadoTienda();
                tien.Show();
                Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario y/o Contraseña son Incorrectos ";
            }

            if (txtUsuario.Text == "gerente" && txtPassword.Text == "gerente")
            {
                FrHomeGerenteAsociacion geren = new FrHomeGerenteAsociacion();
                geren.Show();
                Hide();
            }
            else
            {
                lblMensaje.Text = "Usuario y/o Contraseña son Incorrectos ";
            }

        }

        private void FrLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
