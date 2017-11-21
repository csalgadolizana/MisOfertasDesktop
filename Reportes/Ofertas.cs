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
    public partial class Ofertas : Form
    {
        public Ofertas()
        {
            InitializeComponent();
        }

        private void Ofertas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
