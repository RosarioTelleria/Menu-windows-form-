using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidad;
using System.Data.SqlTypes;
using System.Globalization;

namespace Datos
{
    public class CD_Productos
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {

            //Realizar el intercambio de valores en SQL
            cmd.Connection = conexion.Open();
            cmd.CommandText = "MostrarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            conexion.Close();
            return tabla;
        }
        public void Insertar(int IdProducto, string Nombre, string Descripcion, int Stock, DateTime FechaCreacion, DateTime FechaVencimiento, decimal PrecioCompra, decimal PrecioVenta)
        {
            cmd.Connection = conexion.Open();
            cmd.CommandText = "InsertarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            // Agregar parámetrosq
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void EditarProducto(int IdProducto, string Nombre, string Descripcion, int Stock, DateTime FechaCreacion, DateTime FechaVencimiento, decimal PrecioCompra, decimal PrecioVenta)
        {
            cmd.Connection = conexion.Open();
            cmd.CommandText = "EditarProductos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@FechaCreacion", FechaCreacion);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@PrecioCompra", PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Eliminar(int IdProducto)
        {
            cmd.Connection = conexion.Open();
            cmd.CommandText = "EliminarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idPro", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
