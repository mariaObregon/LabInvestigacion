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
        MantenimientoClientes mantenimiento;
        public FormDatosUsuario()
        {
            mantenimiento = new MantenimientoClientes();
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String strNombre = tbNombre.Text;
            String strCedula = tbCedula.Text;
            String strApellido = tbApellido.Text;
            String strCorreo = tbCorreo.Text;
            String strTelefono = tbTelefono.Text;

            mantenimiento.insertarCliente(strCedula, strNombre, strApellido, strCorreo, strTelefono);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MantenimientoClientes clientes = new MantenimientoClientes();
            clientes.actualizarCliente(tbCedula.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbTelefono.Text);
        }

        public Button GetButtonModificar() {
            return btnModificar;
        }
        public Button GetButtonInsertar() {
            return btnInsertar;
        }
    }
}
