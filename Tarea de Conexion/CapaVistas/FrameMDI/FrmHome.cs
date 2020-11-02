using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistas.FrameContenedores;

namespace CapaVistas.FrameMDI
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
        }

        private void AddWindow<CustomForm>() where CustomForm : Form, new()
        {
            Form window = FrmMenu.Instance.Contenedor.Controls.OfType<CustomForm>().FirstOrDefault();

            if (window == null)
            {
                window = new CustomForm();
                window.TopLevel = false;
                window.Dock = DockStyle.Fill;
                FrmMenu.Instance.Contenedor.Controls.Add(window);
                FrmMenu.Instance.Contenedor.Tag = window;
                window.Show();
                window.BringToFront();
            }
            else
            {
                window.BringToFront();
            }
        }

        //METODOS GENERADOS
        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            if (!FrmMenu.Instance.Contenedor.Controls.ContainsKey("FrmVisitasProgramadas"))
            {
                AddWindow<FrmVisitasProgramadas>();
            }

            FrmMenu.Instance.Contenedor.Controls["FrmVisitasProgramadas"].BringToFront();
            FrmMenu.Instance.Regresar.Visible = true;
        }

      
    }
}
