using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class ClassEntidades
    {
        public string Nombre{ get; set; }
        public string Descripcion { get; set;}

        public int Stock { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }
    }
}
