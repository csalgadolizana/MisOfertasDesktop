using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Reportes
{
    public partial class Usuarios_Registrados : Form
    {
        public Usuarios_Registrados()
        {
            InitializeComponent();
        }

        private void Usuarios_Registrados_Load(object sender, EventArgs e)
        {

            this.UsuariosRegistrados.RefreshReport();
        }

        private void UsuariosRegistrados_Load(object sender, EventArgs e)
        {
            try
            {            

                Service_Usuario.UsuarioServiceClient usu = new Service_Usuario.UsuarioServiceClient();
                List<Service_Usuario.usuario> lisUsurio = usu.Listado_usuarios().ToList();
                usuarioBindingSource.DataSource = lisUsurio.ToList();

                //localBindi localBindingSource.DataSource = lisUsurio.Where(u => u.Equals("activo")).ToList();
                UsuariosRegistrados.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
