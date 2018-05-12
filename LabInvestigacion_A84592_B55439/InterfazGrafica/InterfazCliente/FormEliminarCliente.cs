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
                MessageBox.Show("El cliente ha sido eliminado", "Mensaje");
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

            if (mantenimiento.ListaVacia(strCedula))
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El cliente ingresado no existe", "Mensaje");
            }
        }

        private void FillDataGrid(String strCedula)
        {
            dataGridView.DataSource = mantenimiento.GetClientes(strCedula);
            dataGridView.Columns.RemoveAt(5);
        }

        private void getCedula()
        {
            strCedula = tbCedula.Text;
        }
    }
}
