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
            Service_Usuario.UsuarioServiceClient serviceclient = new Service_Usuario.UsuarioServiceClient();

            var usuario = serviceclient.Autenticacion(txtUsuario.Text.Trim().ToLower(), txtPassword.Text.Trim().ToLower());
            if (int.Parse(usuario.idUsuario.ToString()) != 0)
            {
                MessageBox.Show("bienvenido " + usuario.personaIdpersona.nombre);
                switch (int.Parse(usuario.cargoIdcargo.idcargo.ToString()))
                {
                    case 1:
                        FrHomeGerenteAsociacion gerenteAsociacion = new FrHomeGerenteAsociacion();
                        gerenteAsociacion.Show();
                        this.Hide();
                        break;
                    case 2:
                        FrHomeAdmin admin = new FrHomeAdmin();
                        admin.Show();
                        this.Hide();
                        break;
                    case 3:
                        FrHomeEncargadoTienda encargadoTienda = new FrHomeEncargadoTienda();
                        encargadoTienda.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Ha ocurrido un error /n" +
                            "contacte al administrador");
                        break;
                }
            }
            else
            {
                MessageBox.Show("el correo electronico o la contraseña que ingresaste no coinciden con ninguna cuenta. ");
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
