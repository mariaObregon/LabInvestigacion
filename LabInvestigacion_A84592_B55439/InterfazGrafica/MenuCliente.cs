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
            ConsultarCliente frm2 = new ConsultarCliente();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarCliente frm3 = new ModificarCliente();
            frm3.Show();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            FormDatosUsuario datosUsuario = new FormDatosUsuario();
            datosUsuario.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
