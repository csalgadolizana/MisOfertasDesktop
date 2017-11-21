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
    public partial class Descuentos_Entregados : Form
    {
        public Descuentos_Entregados()
        {
            InitializeComponent();
        }

        private void Descuentos_Entregados_Load(object sender, EventArgs e)
        {

            this.DescuentosEntregados.RefreshReport();
        }

        private void DescuentosEntregados_Load(object sender, EventArgs e)
        {
            try
            {
                Service_Descuento.DescuentoServiceClient des = new Service_Descuento.DescuentoServiceClient();
                List<Service_Descuento.descuento> lisDescuentos = des.Listado_descuento().ToList();
                descuentoBindingSource.DataSource = lisDescuentos.ToList();
                //localBindingSource.DataSource = lisUsurio.Where(u => u.Equals("activo")).ToList();
                DescuentosEntregados.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
