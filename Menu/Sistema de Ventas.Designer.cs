
namespace Menu
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraMenu = new System.Windows.Forms.Panel();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.Btonmaximizar = new System.Windows.Forms.PictureBox();
            this.Btonminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btonrestaurar = new System.Windows.Forms.PictureBox();
            this.Btoncerrar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtomInventario = new System.Windows.Forms.Button();
            this.ButtomVentas = new System.Windows.Forms.Button();
            this.BtonReportes = new System.Windows.Forms.Button();
            this.ButtomGuias = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.Reporteventas = new System.Windows.Forms.Button();
            this.ReportedeGanancias = new System.Windows.Forms.Button();
            this.BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btoncerrar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SubmenuReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraMenu.Controls.Add(this.BotonCerrar);
            this.BarraMenu.Controls.Add(this.Btonmaximizar);
            this.BarraMenu.Controls.Add(this.Btonminimizar);
            this.BarraMenu.Controls.Add(this.pictureBox2);
            this.BarraMenu.Controls.Add(this.Btonrestaurar);
            this.BarraMenu.Controls.Add(this.Btoncerrar);
            this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarraMenu.Location = new System.Drawing.Point(293, 0);
            this.BarraMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(1440, 800);
            this.BarraMenu.TabIndex = 0;
            this.BarraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraMenu_Paint_1);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.BackgroundImage = global::Menu.Properties.Resources.cerrar;
            this.BotonCerrar.Image = global::Menu.Properties.Resources.cerrar;
            this.BotonCerrar.Location = new System.Drawing.Point(1374, 12);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 4;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Btonmaximizar
            // 
            this.Btonmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btonmaximizar.BackColor = System.Drawing.Color.Black;
            this.Btonmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btonmaximizar.Image = global::Menu.Properties.Resources.maximizar;
            this.Btonmaximizar.Location = new System.Drawing.Point(1440, 15);
            this.Btonmaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btonmaximizar.Name = "Btonmaximizar";
            this.Btonmaximizar.Size = new System.Drawing.Size(33, 31);
            this.Btonmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btonmaximizar.TabIndex = 1;
            this.Btonmaximizar.TabStop = false;
            // 
            // Btonminimizar
            // 
            this.Btonminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btonminimizar.BackColor = System.Drawing.Color.Black;
            this.Btonminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btonminimizar.Image = global::Menu.Properties.Resources.minimizar;
            this.Btonminimizar.Location = new System.Drawing.Point(1342, 12);
            this.Btonminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btonminimizar.Name = "Btonminimizar";
            this.Btonminimizar.Size = new System.Drawing.Size(25, 25);
            this.Btonminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btonminimizar.TabIndex = 2;
            this.Btonminimizar.TabStop = false;
            this.Btonminimizar.Click += new System.EventHandler(this.Btonminimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Menu.Properties.Resources.cerrar;
            this.pictureBox2.Image = global::Menu.Properties.Resources.maximizar;
            this.pictureBox2.Location = new System.Drawing.Point(1310, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Btonrestaurar
            // 
            this.Btonrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btonrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btonrestaurar.Image = global::Menu.Properties.Resources.restaurar1;
            this.Btonrestaurar.Location = new System.Drawing.Point(1440, 15);
            this.Btonrestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Btonrestaurar.Name = "Btonrestaurar";
            this.Btonrestaurar.Size = new System.Drawing.Size(33, 31);
            this.Btonrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btonrestaurar.TabIndex = 3;
            this.Btonrestaurar.TabStop = false;
            // 
            // Btoncerrar
            // 
            this.Btoncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btoncerrar.BackColor = System.Drawing.Color.Black;
            this.Btoncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btoncerrar.Image = global::Menu.Properties.Resources.cerrar;
            this.Btoncerrar.Location = new System.Drawing.Point(1494, 15);
            this.Btoncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btoncerrar.Name = "Btoncerrar";
            this.Btoncerrar.Size = new System.Drawing.Size(33, 31);
            this.Btoncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btoncerrar.TabIndex = 0;
            this.Btoncerrar.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.ButtomInventario);
            this.flowLayoutPanel1.Controls.Add(this.ButtomVentas);
            this.flowLayoutPanel1.Controls.Add(this.BtonReportes);
            this.flowLayoutPanel1.Controls.Add(this.SubmenuReportes);
            this.flowLayoutPanel1.Controls.Add(this.ButtomGuias);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 800);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtomInventario
            // 
            this.ButtomInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ButtomInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtomInventario.FlatAppearance.BorderSize = 0;
            this.ButtomInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ButtomInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtomInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtomInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtomInventario.Image = global::Menu.Properties.Resources.producto;
            this.ButtomInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtomInventario.Location = new System.Drawing.Point(4, 195);
            this.ButtomInventario.Margin = new System.Windows.Forms.Padding(4);
            this.ButtomInventario.Name = "ButtomInventario";
            this.ButtomInventario.Size = new System.Drawing.Size(289, 54);
            this.ButtomInventario.TabIndex = 0;
            this.ButtomInventario.Text = "Inventario";
            this.ButtomInventario.UseVisualStyleBackColor = false;
            this.ButtomInventario.Click += new System.EventHandler(this.ButtomInventario_Click);
            // 
            // ButtomVentas
            // 
            this.ButtomVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ButtomVentas.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ButtomVentas.FlatAppearance.BorderSize = 0;
            this.ButtomVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ButtomVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtomVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtomVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtomVentas.Image = global::Menu.Properties.Resources.venta;
            this.ButtomVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtomVentas.Location = new System.Drawing.Point(4, 257);
            this.ButtomVentas.Margin = new System.Windows.Forms.Padding(4);
            this.ButtomVentas.Name = "ButtomVentas";
            this.ButtomVentas.Size = new System.Drawing.Size(289, 54);
            this.ButtomVentas.TabIndex = 1;
            this.ButtomVentas.Text = "Ventas";
            this.ButtomVentas.UseCompatibleTextRendering = true;
            this.ButtomVentas.UseVisualStyleBackColor = false;
            this.ButtomVentas.UseWaitCursor = true;
            this.ButtomVentas.Click += new System.EventHandler(this.ButtomVentas_Click);
            // 
            // BtonReportes
            // 
            this.BtonReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtonReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonReportes.FlatAppearance.BorderSize = 0;
            this.BtonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtonReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtonReportes.Image = global::Menu.Properties.Resources.reportes;
            this.BtonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonReportes.Location = new System.Drawing.Point(4, 319);
            this.BtonReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BtonReportes.Name = "BtonReportes";
            this.BtonReportes.Size = new System.Drawing.Size(289, 54);
            this.BtonReportes.TabIndex = 3;
            this.BtonReportes.Text = "Reportes";
            this.BtonReportes.UseVisualStyleBackColor = false;
            this.BtonReportes.Click += new System.EventHandler(this.BtonReportes_Click);
            // 
            // ButtomGuias
            // 
            this.ButtomGuias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ButtomGuias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtomGuias.FlatAppearance.BorderSize = 0;
            this.ButtomGuias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ButtomGuias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtomGuias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtomGuias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtomGuias.Image = global::Menu.Properties.Resources.empleados;
            this.ButtomGuias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtomGuias.Location = new System.Drawing.Point(4, 486);
            this.ButtomGuias.Margin = new System.Windows.Forms.Padding(4);
            this.ButtomGuias.Name = "ButtomGuias";
            this.ButtomGuias.Size = new System.Drawing.Size(289, 54);
            this.ButtomGuias.TabIndex = 5;
            this.ButtomGuias.Text = "Guía";
            this.ButtomGuias.UseVisualStyleBackColor = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Location = new System.Drawing.Point(293, 53);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1440, 747);
            this.PanelContenedor.TabIndex = 1;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.ReportedeGanancias);
            this.SubmenuReportes.Controls.Add(this.Reporteventas);
            this.SubmenuReportes.Location = new System.Drawing.Point(3, 380);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(284, 99);
            this.SubmenuReportes.TabIndex = 0;
            this.SubmenuReportes.Visible = false;
            // 
            // Reporteventas
            // 
            this.Reporteventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Reporteventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reporteventas.FlatAppearance.BorderSize = 0;
            this.Reporteventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Reporteventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporteventas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporteventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reporteventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporteventas.Location = new System.Drawing.Point(10, 14);
            this.Reporteventas.Margin = new System.Windows.Forms.Padding(4);
            this.Reporteventas.Name = "Reporteventas";
            this.Reporteventas.Size = new System.Drawing.Size(233, 34);
            this.Reporteventas.TabIndex = 6;
            this.Reporteventas.Text = "->  Reporte de Ventas";
            this.Reporteventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Reporteventas.UseVisualStyleBackColor = false;
            this.Reporteventas.Click += new System.EventHandler(this.Reporteventas_Click);
            // 
            // ReportedeGanancias
            // 
            this.ReportedeGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ReportedeGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportedeGanancias.FlatAppearance.BorderSize = 0;
            this.ReportedeGanancias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ReportedeGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportedeGanancias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportedeGanancias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportedeGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportedeGanancias.Location = new System.Drawing.Point(18, 41);
            this.ReportedeGanancias.Margin = new System.Windows.Forms.Padding(4);
            this.ReportedeGanancias.Name = "ReportedeGanancias";
            this.ReportedeGanancias.Size = new System.Drawing.Size(259, 39);
            this.ReportedeGanancias.TabIndex = 7;
            this.ReportedeGanancias.Text = "->  Reporte de Ganancias";
            this.ReportedeGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportedeGanancias.UseVisualStyleBackColor = false;
            this.ReportedeGanancias.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraMenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btonrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btoncerrar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SubmenuReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Btoncerrar;
        private System.Windows.Forms.PictureBox Btonmaximizar;
        private System.Windows.Forms.PictureBox Btonminimizar;
        private System.Windows.Forms.PictureBox Btonrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtomInventario;
        private System.Windows.Forms.Button ButtomVentas;
        private System.Windows.Forms.Button BtonReportes;
        private System.Windows.Forms.Button ButtomGuias;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Button Reporteventas;
        private System.Windows.Forms.Button ReportedeGanancias;
    }
}

