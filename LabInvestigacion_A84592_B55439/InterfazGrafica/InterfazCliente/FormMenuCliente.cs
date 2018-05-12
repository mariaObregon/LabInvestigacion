using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FormConsultarCliente frm2 = new FormConsultarCliente();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDatosUsuario datosUsuario = new FormDatosUsuario();
            datosUsuario.GetButtonModificar().Visible = true;
            datosUsuario.ShowDialog();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            FormDatosUsuario datosUsuario = new FormDatosUsuario();
            datosUsuario.GetButtonInsertar().Visible = true;
            datosUsuario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminarCliente eliminarCliente = new FormEliminarCliente();
            eliminarCliente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
