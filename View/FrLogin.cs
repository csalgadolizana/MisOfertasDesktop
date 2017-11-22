using Desk.Utils;
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
            Service_Usuario.WebServiceAuthUserClient serviceclient = new Service_Usuario.WebServiceAuthUserClient();
            //www.sha1-online.com conversor
            //Tienes que hacer el using Desk.Utils; arriba
            //luego llamas directamente a la clase estatica(no se le puede hacer un new ...)
            //y escribiendo SHA1Util. puedes llamar al metodo encriptarSHA1(string)
            //que recive un string por parametros y eso lo puedes guardar en una varible
            //aqui estoy guardandolo en string pass para luego usar pass en el servicio
            //holaa bebe
            string pass = SHA1Util.encriptarSHA1(txtPassword.Text.Trim());
            //MessageBox.Show("pass "+pass);
            var usuario = serviceclient.AutenticarTrabajador(txtUsuario.Text.Trim(), pass);            
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
