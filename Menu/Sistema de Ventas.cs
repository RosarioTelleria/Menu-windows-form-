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

        private void button3_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<GestionInv>().FirstOrDefault();
            GestionInv hijo1 = form ?? new GestionInv();
            AbrirFormHija(hijo1);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            var form = Application.OpenForms.OfType<Ventas>().FirstOrDefault();
            Ventas hijo2 = form ?? new Ventas();
            AbrirFormHija(hijo2);

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

        private void button5_Click(object sender, EventArgs e)
        {
          
           
        }

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
            this.PanelContenedor.Refresh();

        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            this.PanelContenedor.Refresh();
        }
    }
}
