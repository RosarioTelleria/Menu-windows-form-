using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using System.Data;
using System.Data.SqlTypes;

namespace Negocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd() { 

        DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
                }
        public void InsertarProducto(string IdProducto, string Nombre, string Descripcion, string Stock, string FechaCreacion, string FechaVencimiento, string PrecioCompra, string PrecioVenta)
        {
            objetoCD.Insertar(Convert.ToInt32(IdProducto), Nombre, Descripcion, Convert.ToInt32(Stock), Convert.ToDateTime(FechaCreacion), Convert.ToDateTime(FechaVencimiento), Convert.ToDecimal(PrecioCompra), Convert.ToDecimal(PrecioVenta));
        }


        public void Editarprod(string IdProducto, string Nombre, string Descripcion, string Stock, string FechaCreacion, string FechaVencimiento, string PrecioCompra, string PrecioVenta)
        {
            objetoCD.EditarProducto(
                Convert.ToInt32(IdProducto),
                Nombre,
                Descripcion,
                Convert.ToInt32(Stock),
                Convert.ToDateTime(FechaCreacion),
                Convert.ToDateTime(FechaVencimiento),
                Convert.ToDecimal(PrecioCompra),
                Convert.ToDecimal(PrecioVenta)
            );
        }
        public void Eliminarprod(string IdProducto)
        {
            objetoCD.Eliminar(Convert.ToInt32(IdProducto));

        }

    }
}
