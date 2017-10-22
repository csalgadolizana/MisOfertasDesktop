using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Entidades
{
    class cl_Oferta
    {
        public int id_oferta { get; set; }
        public string nombre_oferta { get; set; }
        public string descripcion_oferta { get; set; }
        public int precio_normal { get; set; }
        public int precio_oferta { get; set; }
        public int numero_visitas { get; set; }
        public int minimo_compra { get; set; }
        public cl_Local nombre_local { get; set; }


    }
}
