using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class LoguinInventario : Form
    {

        Form1 obj = new Form1();
        public LoguinInventario()
        {
            InitializeComponent();
        }

        private void LoguinInventario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
               if (textBox4.Text == "")
                {

                    return;
                }

                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';
                panel24.Visible = false;

            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                panel19.Visible = false;

            }
            catch { }
        }


        private void MostrarInterfazSecundaria(Form formularioSecundario)
        {
            formularioSecundario.TopLevel = false;
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;
            formularioSecundario.Dock = DockStyle.Fill;
            panel3.Controls.Add(formularioSecundario);
            formularioSecundario.Show();
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "usuario123" && textBox4.Text == "contra123")
            {
                MostrarInterfazSecundaria(new GestionInv());
                panel23.Visible = false;
                panel18.Visible = false;
                button2.Visible = false;
                label1.Visible = false;
                panel21.Visible = false;
            }


            if (textBox3.Text != "usuario123")
            {
                panel19.Visible = true;
                textBox3.Focus();
                
            }
            if (textBox4.Text != "contra123")
            {
                panel24.Visible = true;
                textBox4.Focus();
                
            }

            
    
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "USUARIO")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.DarkBlue;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
               textBox3.Text = "USUARIO";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "CONTRASEÑA")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "CONTRASEÑA";
                textBox4.ForeColor = Color.Black;
            }
        }
    }
    }
   


