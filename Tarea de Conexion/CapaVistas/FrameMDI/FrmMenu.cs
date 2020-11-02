using CapaVistas.FrameMDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistas
{
    public partial class FrmMenu : Form
    {

        //Varibles para redimiensionar
        private int locationX;
        private int locationY;
        //Variables para Regresar
        static FrmMenu _obj;
        //Constructor
        public FrmMenu()
        {
            InitializeComponent();
            PantallaOk();
            btnRegresar.Visible = false;
            _obj = this;
        }
        
        public static FrmMenu Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmMenu();
                }
                return _obj;
            }
        }

        public Panel Contenedor
        {
            get { return pnlContenedor; }
            set { pnlContenedor = value; }
        }

        public PictureBox Regresar
        {
            get { return btnRegresar; }
            set { btnRegresar = value; }
        }

        //Metodos Creadors
        private void PantallaOk()
        {
            locationX = this.Location.X;
            locationY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        //Seguir al Boton
        private void SeguirBoton(Bunifu.Framework.UI.BunifuTileButton sender)
        {
            Flecha.Top = sender.Bottom;
        }
     
        //Agregar una Nueva Pestana
        private void AddWindow<CustomForm>() where CustomForm : Form, new()
        {
            Form window = pnlContenedor.Controls.OfType<CustomForm>().FirstOrDefault();

            if (window == null)
            {
                window = new CustomForm();
                window.TopLevel = false;
                window.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(window);
                pnlContenedor.Tag = window;
                window.Show();
                window.BringToFront();
            }
            else
            {
                window.BringToFront();
            }
        }
       
        //----------Metodos Genrados

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            PantallaOk();
            AddWindow<FrmHome>();
            Flecha.Visible = true;
        }

        //-----------------BOTONES PRINCIPALES DEL FRAME
        private void btnHome_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnHome);
            AddWindow<FrmHome>();
            Flecha.Visible = true;
        }
    
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AddWindow<FrmClientes>();
            SeguirBoton(btnClientes);
            Flecha.Visible = true;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnProductos);
            AddWindow<FrmProductos>();
            Flecha.Visible = true;
        }

        private void btnActasTecnicas_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnActasTecnicas);
            AddWindow<FrmActas>();
            Flecha.Visible = true;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnFacturas);
            AddWindow<FrmFacturas>();
            Flecha.Visible = true;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnReportes);
            AddWindow<FrmReportes>();
            Flecha.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SeguirBoton(btnUsuarios);
            AddWindow<FrmUsuarios>();
            Flecha.Visible = true;
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            AddWindow<FrmConfiguraciones>();
            Flecha.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AddWindow<FrmVenta>();
            SeguirBoton(btnVentas);
            Flecha.Visible = true;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AddWindow<FrmEmpleado>();
            SeguirBoton(btnEmpleado);
            Flecha.Visible = true;
        }

        //Metodo de Salir
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pnlContenedor.Controls["FrmHome"].BringToFront();
            btnRegresar.Visible = false;
        }
        
    }//-------------------
}
