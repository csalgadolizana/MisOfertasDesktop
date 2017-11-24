using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk.Grafico
{
    public partial class FormGraficoMensual : Form
    {
        public FormGraficoMensual()
        {
            InitializeComponent();

            Service_OfertaVisita.OfertaVistaServiceClient ofertaVistaServ = new Service_OfertaVisita.OfertaVistaServiceClient();
            List<Service_OfertaVisita.ofertavisi> lis = ofertaVistaServ.Listado_oferta_visitas().ToList();
            int enero = lis.Count(x => x.fechaVisita.ToString("MM") == "1");
            int febre = lis.Count(x => x.fechaVisita.ToString("MM") == "2");
            int marzo = lis.Count(x => x.fechaVisita.ToString("MM") == "3");
            int abril = lis.Count(x => x.fechaVisita.ToString("MM") == "4");
            int mayo = lis.Count(x => x.fechaVisita.ToString("MM") == "5");
            int junio = lis.Count(x => x.fechaVisita.ToString("MM") == "6");
            Console.WriteLine("\n enero " + enero + "\n febre " + febre + "\n enero " + marzo + "\n marzo " + abril + "\n abril " + mayo + "\n mayo " + junio);
            int julio = lis.Count(x => x.fechaVisita.ToString("MM") == "7");
            int agost = lis.Count(x => x.fechaVisita.ToString("MM") == "8");
            int septi = lis.Count(x => x.fechaVisita.ToString("MM") == "9");
            int octub = lis.Count(x => x.fechaVisita.ToString("MM") == "10");
            int novie = lis.Count(x => x.fechaVisita.ToString("MM") == "11");
            int dicie = lis.Count(x => x.fechaVisita.ToString("MM") == "12");
            int[] visitasPorMes = new int[] { enero, febre, marzo, abril, mayo, junio, julio, agost, septi, octub, novie, dicie };
            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("\n julio " + julio + "\n agost " + agost + "\n septi " + septi + "\n octub " + octub + "\n novie " + novie + "\n dicie " + dicie);
            chartAnual.Series["Series1"].Points.DataBindXY(meses,visitasPorMes);
            chartAnual.Titles.Clear();
            chartAnual.Titles.Add("Cantidad de visitas");
            chartAnual.Legends.Clear();
            //chartAnual.Legends.Add("Cantidad de visitas");

        }
    }
}
