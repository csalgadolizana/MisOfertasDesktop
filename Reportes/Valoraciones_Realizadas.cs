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
    public partial class Valoraciones_Realizadas : Form
    {
        public Valoraciones_Realizadas()
        {
            InitializeComponent();
        }

        private void Valoraciones_Realizadas_Load(object sender, EventArgs e)
        {

            this.ValoracionesRealizadas.RefreshReport();
        }

        private void ValoracionesRealizadas_Load(object sender, EventArgs e)
        {
            try
            {
                Service_Valoracion.ValoracionServiceClient val = new Service_Valoracion.ValoracionServiceClient();
                List<Service_Valoracion.valoracion> lisValoracion = val.Listado_valoraciones().ToList();
                valoracionBindingSource.DataSource = lisValoracion.ToList();
                //localBindingSource.DataSource = lisUsurio.Where(u => u.Equals("activo")).ToList();
                ValoracionesRealizadas.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
