using Entidad;
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
    public partial class FormEliminarCliente : Form
    {
        MantenimientoClientes mantenimiento;
        private String strID;

        public FormEliminarCliente()
        {
            mantenimiento = new MantenimientoClientes();
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show($"¿Desea eliminar al cliente con ID: {strID} ?", "Confirmar", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                mantenimiento.eliminarCliente(tbCedula.Text);
                MessageBox.Show("El cliente ha sido eliminado", "Mensaje");
                tbCedula.Clear();
                btnEliminar.Enabled = false;
                dataGridView.DataSource = mantenimiento.getList("");
                dataGridView.Columns.RemoveAt(5);
            }
   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           dataGridView.DataSource = mantenimiento.getList(tbCedula.Text);
            dataGridView.Columns.RemoveAt(5);
            if (mantenimiento.getList(tbCedula.Text).Any<Cliente>())
            {
                btnEliminar.Enabled = true;
                strID = mantenimiento.getList(tbCedula.Text).ElementAt<Cliente>(0).Cedula;
            }
            else {
                MessageBox.Show("El cliente ingresado no existe", "Mensaje");
            }
        }
    }
}
