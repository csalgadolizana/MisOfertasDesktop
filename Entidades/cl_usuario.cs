using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Entidades
{
    public class cl_usuario
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string cargo_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string contrasena_usuario { get; set; }
        public int telefono_usuario { get; set; }
    }
}
