using Negocio;
using System;
using System.Windows.Forms;

namespace InterfazGrafica.InterfazProducto
{
    public partial class FormEliminarProducto : Form
    {

        private MantenimientoProductos mantenimiento;
        private String strCodigo;

        public FormEliminarProducto()
        {
            mantenimiento = new MantenimientoProductos();
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show($"¿Desea eliminar el producto con ID: {strCodigo} ?", "Confirmar", MessageBoxButtons.YesNo);

            if (opcion == DialogResult.Yes)
            {
                mantenimiento.EliminarProducto(strCodigo);
                MessageBox.Show("El producto y las lineas de detalle asociadas han sido eliminados", "Mensaje");
                tbCodigo.Clear();
                btnEliminar.Enabled = false;
                FillDataGrid(strCodigo);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            strCodigo = tbCodigo.Text;
            FillDataGrid(strCodigo);

            try
            {
                mantenimiento.VerificarExisteProducto(strCodigo);
                btnEliminar.Enabled = true;

            }
            catch (ExcepcionNoExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");
                btnEliminar.Enabled = false;
            }
            catch (ExcepcionEsVacio ex)
            {
                MessageBox.Show(ex.Message, "Error");
                btnEliminar.Enabled = false;
            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGrid(String strCodigo)
        {
            dataGridView.DataSource = mantenimiento.GetProductos(strCodigo);
            dataGridView.Columns.RemoveAt(4);
        }
    }
}

