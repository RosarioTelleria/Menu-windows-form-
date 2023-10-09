using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btonmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btonmaximizar.Visible = false;
            Btonrestaurar.Visible = true;

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btonrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btonrestaurar.Visible = false;
            Btonmaximizar.Visible = true;
        }

        private void Btonminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Btonminimizar.Visible = true;

        }

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new LoguinInventario());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventas());
        }

        private void Form1_Load(Object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new ReporteVentas());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormHija(new ReportedeGanancias());
        }

        private void SubmenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtonReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Guia());
        }

        public void AbrirFormHija(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

           
    }
}
