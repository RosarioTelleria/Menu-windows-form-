using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Menu.GestionInv;

namespace Menu
{
    public partial class GestionInv : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
       private bool Editar=false;
        public GestionInv()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void MostrarProductos()
        {

            CN_Productos objetos = new CN_Productos();
            dataGridView1.DataSource = objetos.MostrarProd();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void GestionInv_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se coloca cada uno de las columnas de la base de datos puesto que, el sistema de busqueda tiene que resultar a partir de estos valores
            //Obtiene un Value que es el valor en cuestion de las celdas seleccionadas, .ToString() que convierte esos valores a caracteres
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtNombre.Text = dataGridView1[0, fila].Value.ToString();
            txtDescripcion.Text = dataGridView1[1, fila].Value.ToString();
            txtStock.Text = dataGridView1[2, fila].Value.ToString();
            txtFechaCreacion.Text = dataGridView1[3, fila].Value.ToString();
            txtFechaVencimiento.Text = dataGridView1[4, fila].Value.ToString();
            txtPrecioCompra.Text = dataGridView1[5, fila].Value.ToString();
            txtPrecioVenta.Text = dataGridView1[6, fila].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    // Verificar si el campo de stock está vacío
                    if (string.IsNullOrWhiteSpace(txtStock.Text))
                    {
                        MessageBox.Show("El campo de stock no puede estar vacío.");
                        return;
                    }
                    // Verificar si el campo de stock es un número entero
                    if (!int.TryParse(txtStock.Text, out int stock) || stock <= 0)
                    {
                        MessageBox.Show("El campo de stock debe ser un número entero.");
                        return;
                    }
                    // Verificar si el campo de precio de compra es un número decimal y no es negativo
                    if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
                    {
                        MessageBox.Show("El campo de precio de compra debe ser un número válido.");
                        return;
                    }

                    // Verificar si el campo de precio de venta es un número decimal y no es negativo
                    if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) || precioVenta <= 0)
                    {
                        MessageBox.Show("El campo de precio de venta debe ser un número válido.");
                        return;
                    }
                    // Verificar si el campo de fecha de creación está vacío o tiene un formato incorrecto
                    if (!DateTime.TryParse(txtFechaCreacion.Text, out DateTime fechaCreacion))
                    {
                        MessageBox.Show("El campo de fecha de creación no tiene un formato de fecha válido.");
                        return;
                    }

                    // Verificar si el campo de fecha de vencimiento está vacío o tiene un formato incorrecto
                    if (!DateTime.TryParse(txtFechaVencimiento.Text, out DateTime fechaVencimiento))
                    {
                        MessageBox.Show("El campo de fecha de vencimiento no tiene un formato de fecha válido.");
                        return;
                    }

                    // Realizar una inserción
                    objetoCN.InsertarProducto(idProducto, txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtFechaCreacion.Text, txtFechaVencimiento.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                    MessageBox.Show("Se registró correctamente");
                    MostrarProductos();

                    // Limpiar cuadros de texto
                    LimpiarCampos();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar los datos por: " + ex.Message);
                }
            }
            else // Edición
            {
                try
                {
                    // Verificar si el campo de stock está vacío
                    if (string.IsNullOrWhiteSpace(txtStock.Text))
                    {
                        MessageBox.Show("El campo de stock no puede estar vacío.");
                        return;
                    }
                    // Verificar si el campo de stock es un número entero
                    if (!int.TryParse(txtStock.Text, out int stock) || stock <= 0)
                    {
                        MessageBox.Show("El campo de stock debe ser un número entero.");
                        return;
                    }
                    // Verificar si el campo de precio de compra es un número decimal y no es negativo
                    if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
                    {
                        MessageBox.Show("El campo de precio de compra debe ser un número válido.");
                        return;
                    }

                    // Verificar si el campo de precio de venta es un número decimal y no es negativo
                    if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) || precioVenta <= 0)
                    {
                        MessageBox.Show("El campo de precio de venta debe ser un número válido.");
                        return;
                    }
                    // Verificar si el campo de fecha de creación está vacío o tiene un formato incorrecto
                    if (!DateTime.TryParse(txtFechaCreacion.Text, out DateTime fechaCreacion))
                    {
                        MessageBox.Show("El campo de fecha de creación no tiene un formato de fecha válido.");
                        return;
                    }

                    // Verificar si el campo de fecha de vencimiento está vacío o tiene un formato incorrecto
                    if (!DateTime.TryParse(txtFechaVencimiento.Text, out DateTime fechaVencimiento))
                    {
                        MessageBox.Show("El campo de fecha de vencimiento no tiene un formato de fecha válido.");
                        return;
                    }

                    // Realizar una edición
                    objetoCN.Editarprod(idProducto, txtNombre.Text, txtDescripcion.Text, txtStock.Text, txtFechaCreacion.Text, txtFechaVencimiento.Text, txtPrecioCompra.Text, txtPrecioVenta.Text);
                    MessageBox.Show("Se editó correctamente");
                    MostrarProductos();
                    Editar = false;

                    // Limpiar cuadros de texto
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtFechaCreacion.Text = "";
            txtFechaVencimiento.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
        }

        //Eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
                objetoCN.Eliminarprod(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            MessageBox.Show("Seleccione una fila por favor");
            }
        //Editar
        private void button3_Click(object sender, EventArgs e)
        {

                if (dataGridView1.SelectedRows.Count>0 )
                {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                txtFechaCreacion.Text = dataGridView1.CurrentRow.Cells["FechaCreacion"].Value.ToString();
                txtFechaVencimiento.Text = dataGridView1.CurrentRow.Cells["FechaVencimiento"].Value.ToString();
                txtPrecioCompra.Text = dataGridView1.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dataGridView1.CurrentRow.Cells["PrecioVenta"].Value.ToString();;

                idProducto = dataGridView1.CurrentRow.Cells["idProducto"].Value.ToString();
            }else
            {
                MessageBox.Show("por favor selecciona una columna");
            }



        }
        private string cadenaConexion = "Data Source=LAPTOP-34PQSFQ3\\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True";
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           
            // Obtener el término de búsqueda ingresado por el usuario
            string terminoBusqueda = txtBusqueda.Text;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();

                // Realizar la búsqueda en la base de datos
                string consulta = "SELECT * FROM Productos WHERE Nombre LIKE @termino OR Descripcion LIKE @termino";
                SqlCommand cmd = new SqlCommand(consulta, sqlConnection);
                cmd.Parameters.AddWithValue("@termino", "%" + terminoBusqueda + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Asignar los resultados de la búsqueda al DataGridView
                dataGridView1.DataSource = dt;
            }
        }
    }
}