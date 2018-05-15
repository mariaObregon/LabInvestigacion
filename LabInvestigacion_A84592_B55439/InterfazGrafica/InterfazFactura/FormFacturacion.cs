using Negocio;
using System;
using System.Windows.Forms;

namespace InterfazGrafica.InterfazFactura
{

    public partial class FormFacturacion : Form
    {
        MantenimientoFactura mantenimiento = new MantenimientoFactura();

        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewF.DataSource = mantenimiento.Facturacion(tbCedula.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridViewF.Columns.RemoveAt(3);
                dataGridViewF.Columns.RemoveAt(3);
                tbTotal.Text = mantenimiento.TotalFacturado(tbCedula.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridViewLD.DataSource = mantenimiento.LineaDetallesHistorial(tbCedula.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                dataGridViewLD.Columns.RemoveAt(5);
                dataGridViewLD.Columns.RemoveAt(5);
            }
            catch (ExcepcionNoExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ExcepcionEsVacio ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
