using ExcepcionesUsuario;
using Negocio;
using System;
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

            try
            {
                mantenimiento.InsertarCliente(strCedula, strNombre, strApellido, strCorreo, strTelefono);
                MessageBox.Show("Cliente ingresado con éxito!", "Mensaje");
                tbApellido.Clear();
                tbCedula.Clear();
                tbCorreo.Clear();
                tbNombre.Clear();
                tbTelefono.Clear();
            }
            catch (ExcepcionExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ExcepcionCorreoInvalido ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ExcepcionEsVacio ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MantenimientoClientes clientes = new MantenimientoClientes();
            clientes.ActualizarCliente(tbCedula.Text, tbNombre.Text, tbApellido.Text, tbCorreo.Text, tbTelefono.Text);
        }

        public Button GetButtonModificar()
        {
            return btnModificar;
        }
        public Button GetButtonInsertar()
        {
            return btnInsertar;
        }

    }
}
