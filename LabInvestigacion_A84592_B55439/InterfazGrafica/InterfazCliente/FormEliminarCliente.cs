using Negocio;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FormEliminarCliente : Form
    {
        private MantenimientoClientes mantenimiento;
        private String strCedula;

        public FormEliminarCliente()
        {
            mantenimiento = new MantenimientoClientes();
            InitializeComponent();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult opcion = MessageBox.Show($"¿Desea eliminar al cliente con ID: {strCedula} ?", "Confirmar", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                mantenimiento.EliminarCliente(strCedula);
                MessageBox.Show("El cliente y sus facturas han sido eliminados", "Mensaje");
                tbCedula.Clear();
                btnEliminar.Enabled = false;
                FillDataGrid(strCedula);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            strCedula = tbCedula.Text;
            FillDataGrid(strCedula);

            try {
                mantenimiento.VerificarExisteCliente(strCedula);
                btnEliminar.Enabled = true;

            } catch (ExcepcionNoExisteID ex) {
                MessageBox.Show(ex.Message, "Error");
                btnEliminar.Enabled = false;
            }
            catch (ExcepcionEsVacio ex) {
                MessageBox.Show(ex.Message, "Error");
                btnEliminar.Enabled = false;
            }
}

        private void FillDataGrid(String strCedula)
        {
            dataGridView.DataSource = mantenimiento.GetClientes(strCedula);
            dataGridView.Columns.RemoveAt(5);
        }    
    }
}
