using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion
{
    public partial class Insertar : Form
    {
        private Conectar con;
        Encrypt md5 = new Encrypt();
        public Insertar()
        {
            InitializeComponent();
        }

        public Insertar(Conectar con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPNombre.Text == "" || txtSNombre.Text == " "  || txtPApellido.Text == " " || txtSApellido.Text == " " || txtDireccion.Text == " " || txtTelefono.Text == "")
            {
                MessageBox.Show("Campos vacios");
                return;
            }

            con.insertarCliente(txtPNombre.Text ,txtSNombre.Text , txtPApellido.Text, txtSApellido.Text,txtDireccion.Text , txtTelefono.Text);
            this.Hide();

        }
        
    }
}
