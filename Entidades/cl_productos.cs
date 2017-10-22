using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Entidades
{
    public class cl_productos
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_productos { get; set; }
        public cl_empresas nombreEmpresa { get; set; }
        public int precio_producto { get; set; }
        public string imagen_producto { get; set; }

    }
}
