using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    internal class Permiso
    {
        public int IdPermiso { get; set; }
        public int IdRol { get; set; }
        public string NombreMenu { get; set; }
        public string FechaCreacion { get; set; }
    }
}
