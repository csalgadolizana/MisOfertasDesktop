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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Service_Usuario.UsuarioServiceClient serviceclient = new Service_Usuario.UsuarioServiceClient();
            var usuario = serviceclient.AutenticarTrabajador(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
            if (int.Parse(usuario.idUsuario.ToString()) != 0)
            {                
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

        }

        
    }
}
