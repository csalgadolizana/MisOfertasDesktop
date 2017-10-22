using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Entidades
{
    class cl_cliente
    {
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string apellido_cliente { get; set; }
        public string rut_cliente { get; set; }
        public string sexo { get; set; }
        public DateTime fechaNacimiento_cliente { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public int telefono { get; set; }

    }
}
