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
using System.Diagnostics.Eventing.Reader;

namespace Menu
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private void BarraMenu_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    SubmenuReportes.Visible = false;
        //    AbrirFormHija(new ReporteVentas());
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    SubmenuReportes.Visible = false;
        //    AbrirFormHija(new ReportedeGanancias());
        //}

        public void AbrirFormHija(Form fh)
        {
           
            if (this.PanelContenedor.Controls.Count>0)
                this.PanelContenedor.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
            
        }

       

        private void BarraMenu_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        private void ButtomInventario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<GestionInv>().FirstOrDefault();
            GestionInv hijo1 = form ?? new GestionInv();
            AbrirFormHija(hijo1);
        }

        private void ButtomVentas_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Ventas>().FirstOrDefault();
            Ventas hijo2 = form ?? new Ventas();
            AbrirFormHija(hijo2);
        }

        private void SubmenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtonReportes_Click(object sender, EventArgs e)
        {
           SubmenuReportes.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            BotonCerrar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = true;

        }

        private void BarraMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Btonminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void Reporteventas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible=false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
