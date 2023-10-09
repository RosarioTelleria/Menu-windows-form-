using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        //Aqui se realiza los diversos apartados de conexion para SQL
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private SqlConnection SqlCon = new SqlConnection("Data Source=localhost;Initial Catalog=Inventario;Integrated Security=True");


        public SqlConnection Open()
        {
            if (SqlCon.State == ConnectionState.Closed)

                SqlCon.Open();
            return SqlCon;
        }

        public SqlConnection Close()
        {
            if (SqlCon.State == ConnectionState.Open)
                SqlCon.Close();
            return SqlCon;
        }


    }
}
