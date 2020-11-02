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
    public partial class Clientes : Form
    {
        private Conectar con;
        int renglon;
        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(Conectar con)
        {
            this.con = con;
            InitializeComponent();
            ListarClientes();

            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtId.Enabled = false;
            txtPNombre.Enabled = false;
            txtSNombre.Enabled = false;
            txtPApellido.Enabled = false;
            txtSApellido.Enabled = false;

            btnEditar.Enabled = false;
            btnDelete.Enabled = false;
           
        }

        private void ListarClientes()
        {
            con.listarClientes(dgvCliente);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre,apellido,id;

            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtId.Enabled = false;
            txtPNombre.Enabled = false;
            txtSNombre.Enabled = false;
            txtPApellido.Enabled = false;
            txtSApellido.Enabled = false;


            btnEditar.Enabled = true;
            btnDelete.Enabled = true;

            id = dgvCliente.Rows[renglon].Cells["ID"].Value.ToString();
            txtId.Text = id; //Aqui le asignas al TextBox lo que sacaste del dgv

            txtPNombre.Text = dgvCliente.Rows[renglon].Cells["Primer Nombre"].Value.ToString();
            txtSNombre.Text = dgvCliente.Rows[renglon].Cells["Segundo Nombre"].Value.ToString();
            txtPApellido.Text = dgvCliente.Rows[renglon].Cells["Primer Apellido"].Value.ToString();
            txtSApellido.Text= dgvCliente.Rows[renglon].Cells["Segundo Apellido"].Value.ToString();
            txtTelefono.Text = dgvCliente.Rows[renglon].Cells["Telefono"].Value.ToString();
        
            apellido = dgvCliente.Rows[renglon].Cells["Direccion"].Value.ToString();
            txtDireccion.Text = apellido; //Aqui le asignas al TextBox lo que sacaste del dgv
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.editarCliente(dgvCliente,int.Parse(txtId.Text),  txtPNombre.Text, txtSNombre.Text, txtPApellido.Text, txtSApellido.Text, txtDireccion.Text, txtTelefono.Text);
            ListarClientes();
            txtId.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtId.Enabled = false;
            txtPNombre.Enabled = false;
            txtSNombre.Enabled = false;
            txtPApellido.Enabled = false;
            txtSApellido.Enabled = false;

            btnEditar.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.eliminarCliente(int.Parse(txtId.Text));
            ListarClientes();
            txtId.Text = "";
            txtPApellido.Text = "";
            txtSNombre.Text = "";
            txtPApellido.Text = "";
            txtSApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";


            txtId.Enabled = false;
            txtPNombre.Enabled = false;
            txtSNombre.Enabled = false;
            txtPApellido.Enabled = false;
            txtSApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;

            btnEditar.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(txtId.Text.Equals(""))
            {
                MessageBox.Show("No puede quedar vacio el campo busqueda");
                return;
            }

            string searchValue = txtId.Text;
            
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvCliente.Rows)
                {
                    Console.WriteLine(row.Cells[0].Value.ToString());

                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
