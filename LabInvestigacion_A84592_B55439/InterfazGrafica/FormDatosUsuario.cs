using Negocio;
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
    public partial class FormDatosUsuario : Form
    {
        RecibirDatosUsuario recibirDatosU;
        public FormDatosUsuario()
        {
            recibirDatosU = new RecibirDatosUsuario();
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String strNombre = tbNombre.Text;
            String strCedula = tbCedula.Text;
            String strApellido = tbApellido.Text;
            String strCorreo = tbCorreo.Text;
            String strTelefono = tbTelefono.Text;

            recibirDatosU.insertarCliente(strCedula, strNombre, strApellido, strCorreo, strTelefono);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
