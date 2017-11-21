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
    public partial class Reporte_Locales : Form
    {
        public Reporte_Locales()
        {
            InitializeComponent();
        }

        private void Reporte_Locales_Load(object sender, EventArgs e)
        {

            this.ReporteLocales.RefreshReport();
        }

        private void ReporteLocales_Load(object sender, EventArgs e)
        {
            try
            {
                Service_Local.LocalServiceClient cli = new Service_Local.LocalServiceClient();
                List<Service_Local.local> lisLocal = cli.Listado_local().ToList();
                localBindingSource.DataSource = lisLocal.ToList();
                //localBindingSource.DataSource = lisUsurio.Where(u => u.Equals("activo")).ToList();
                ReporteLocales.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
