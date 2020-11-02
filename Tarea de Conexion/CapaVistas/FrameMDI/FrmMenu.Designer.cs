namespace CapaVistas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.Header = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfiguraciones = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnVentas = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpleado = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.Flecha = new System.Windows.Forms.PictureBox();
            this.btnReportes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFacturas = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnActasTecnicas = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguraciones)).BeginInit();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(180)))));
            this.Header.Controls.Add(this.btnRegresar);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btnConfiguraciones);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1635, 46);
            this.Header.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::CapaVistas.Properties.Resources.Flecha;
            this.btnRegresar.Location = new System.Drawing.Point(12, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(31, 28);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1594, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguraciones.Image = global::CapaVistas.Properties.Resources.Configuraciones;
            this.btnConfiguraciones.Location = new System.Drawing.Point(1545, 6);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(26, 33);
            this.btnConfiguraciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfiguraciones.TabIndex = 2;
            this.btnConfiguraciones.TabStop = false;
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SideBar.Controls.Add(this.btnVentas);
            this.SideBar.Controls.Add(this.btnEmpleado);
            this.SideBar.Controls.Add(this.btnUsuarios);
            this.SideBar.Controls.Add(this.Flecha);
            this.SideBar.Controls.Add(this.btnReportes);
            this.SideBar.Controls.Add(this.btnFacturas);
            this.SideBar.Controls.Add(this.btnActasTecnicas);
            this.SideBar.Controls.Add(this.btnProductos);
            this.SideBar.Controls.Add(this.btnClientes);
            this.SideBar.Controls.Add(this.btnHome);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 46);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(81, 826);
            this.SideBar.TabIndex = 1;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnVentas.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnVentas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::CapaVistas.Properties.Resources.Reportes;
            this.btnVentas.ImagePosition = 14;
            this.btnVentas.ImageZoom = 40;
            this.btnVentas.LabelPosition = 29;
            this.btnVentas.LabelText = "Ventas";
            this.btnVentas.Location = new System.Drawing.Point(0, 431);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(81, 80);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmpleado.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmpleado.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = global::CapaVistas.Properties.Resources.Cliente;
            this.btnEmpleado.ImagePosition = 14;
            this.btnEmpleado.ImageZoom = 40;
            this.btnEmpleado.LabelPosition = 29;
            this.btnEmpleado.LabelText = "Empleados";
            this.btnEmpleado.Location = new System.Drawing.Point(0, 172);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(81, 80);
            this.btnEmpleado.TabIndex = 9;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUsuarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUsuarios.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::CapaVistas.Properties.Resources.Usuario1;
            this.btnUsuarios.ImagePosition = 14;
            this.btnUsuarios.ImageZoom = 40;
            this.btnUsuarios.LabelPosition = 29;
            this.btnUsuarios.LabelText = "Usuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(0, 741);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(81, 77);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Flecha
            // 
            this.Flecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Flecha.Location = new System.Drawing.Point(0, 80);
            this.Flecha.Name = "Flecha";
            this.Flecha.Size = new System.Drawing.Size(83, 3);
            this.Flecha.TabIndex = 0;
            this.Flecha.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReportes.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReportes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::CapaVistas.Properties.Resources.Reportes;
            this.btnReportes.ImagePosition = 14;
            this.btnReportes.ImageZoom = 40;
            this.btnReportes.LabelPosition = 29;
            this.btnReportes.LabelText = "Reportes";
            this.btnReportes.Location = new System.Drawing.Point(0, 607);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(81, 80);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFacturas.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnFacturas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Image = global::CapaVistas.Properties.Resources.Factura;
            this.btnFacturas.ImagePosition = 14;
            this.btnFacturas.ImageZoom = 40;
            this.btnFacturas.LabelPosition = 29;
            this.btnFacturas.LabelText = "Facturas";
            this.btnFacturas.Location = new System.Drawing.Point(0, 519);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(81, 80);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnActasTecnicas
            // 
            this.btnActasTecnicas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnActasTecnicas.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnActasTecnicas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnActasTecnicas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActasTecnicas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActasTecnicas.ForeColor = System.Drawing.Color.White;
            this.btnActasTecnicas.Image = global::CapaVistas.Properties.Resources.Actas_Tecnicas;
            this.btnActasTecnicas.ImagePosition = 14;
            this.btnActasTecnicas.ImageZoom = 40;
            this.btnActasTecnicas.LabelPosition = 29;
            this.btnActasTecnicas.LabelText = "Actas";
            this.btnActasTecnicas.Location = new System.Drawing.Point(0, 343);
            this.btnActasTecnicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActasTecnicas.Name = "btnActasTecnicas";
            this.btnActasTecnicas.Size = new System.Drawing.Size(81, 80);
            this.btnActasTecnicas.TabIndex = 3;
            this.btnActasTecnicas.Click += new System.EventHandler(this.btnActasTecnicas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProductos.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProductos.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::CapaVistas.Properties.Resources.Productos;
            this.btnProductos.ImagePosition = 14;
            this.btnProductos.ImageZoom = 40;
            this.btnProductos.LabelPosition = 29;
            this.btnProductos.LabelText = "Productos";
            this.btnProductos.Location = new System.Drawing.Point(0, 259);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(81, 76);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClientes.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClientes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::CapaVistas.Properties.Resources.Cliente;
            this.btnClientes.ImagePosition = 14;
            this.btnClientes.ImageZoom = 40;
            this.btnClientes.LabelPosition = 29;
            this.btnClientes.LabelText = "Clientes";
            this.btnClientes.Location = new System.Drawing.Point(0, 85);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(81, 80);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::CapaVistas.Properties.Resources.Home;
            this.btnHome.ImagePosition = 14;
            this.btnHome.ImageZoom = 40;
            this.btnHome.LabelPosition = 29;
            this.btnHome.LabelText = "Home";
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(81, 46);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1554, 826);
            this.pnlContenedor.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1635, 872);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguraciones)).EndInit();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideBar;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        private Bunifu.Framework.UI.BunifuTileButton btnClientes;
        private Bunifu.Framework.UI.BunifuTileButton btnActasTecnicas;
        private Bunifu.Framework.UI.BunifuTileButton btnProductos;
        private Bunifu.Framework.UI.BunifuTileButton btnFacturas;
        private Bunifu.Framework.UI.BunifuTileButton btnReportes;
        private System.Windows.Forms.PictureBox Flecha;
        private Bunifu.Framework.UI.BunifuTileButton btnUsuarios;
        private System.Windows.Forms.PictureBox btnConfiguraciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox btnRegresar;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpleado;
        private Bunifu.Framework.UI.BunifuTileButton btnVentas;
    }
}

