using Negocio;
using System;
using System.Windows.Forms;

namespace InterfazGrafica.InterfazFactura
{
    public partial class FormNuevaFactura : Form
    {

        private MantenimientoClientes mantenimiento;
        private MantenimientoFactura mantenimientoFactura;
        private String strCedula = "";
        public FormNuevaFactura()
        {
            mantenimiento = new MantenimientoClientes();
            mantenimientoFactura = new MantenimientoFactura();
            InitializeComponent();
        }

        private void BtnCrearFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSeleccionar.Enabled == true)
                {

                    throw new ExcepcionEsVacio("Debe seleccionar un cliente");

                }

                else if (btnVerificar.Enabled == true)
                {
                    MessageBox.Show("Debe verificar el numero de factura", "Error");
                }
                else
                {
                    mantenimiento.VerificarExisteCliente(strCedula);

                    DialogResult opcion = MessageBox.Show($"¿Desea agregar la factura {tbFactura.Text} al cliente con ID: {strCedula} ?", "Confirmar", MessageBoxButtons.YesNo);

                    if (opcion == DialogResult.Yes)
                    {
                        mantenimientoFactura.InsertarFactura(tbFactura.Text, tbCedula.Text);
                        MessageBox.Show("Factura creada con exito", "Aviso");
                        this.Close();
                    }
                }
            }
            catch (ExcepcionEsVacio ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            catch (ExcepcionNoExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }

        }

        private void BtnAgregarDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbFactura.Text.Trim() == String.Empty || tbNumeroLinea.Text.Trim() == String.Empty ||
                      tbCodigoP.Text.Trim() == String.Empty || tbPrecio.Text.Trim() == String.Empty ||
                      tbCantidad.Text.Trim() == String.Empty)
                {
                    throw new ExcepcionEsVacio();
                }
                else if (btnVerificar.Enabled == true)
                {
                    MessageBox.Show("Debe verificar el numero de factura", "Error");
                }

                else
                {
                    new MantenimientoProductos().VerificarExisteProducto(tbCodigoP.Text);
                    mantenimientoFactura.ExisteNumeroDetalle(tbNumeroLinea.Text);
                    dataGridViewD.Rows.Add(tbFactura.Text, tbNumeroLinea.Text, tbCodigoP.Text, tbPrecio.Text, tbCantidad.Text);
                    mantenimientoFactura.addList(tbFactura.Text, tbNumeroLinea.Text, tbCodigoP.Text, tbPrecio.Text, tbCantidad.Text);
                    tbSubTotal.Text = mantenimientoFactura.subTotal().ToString();
                }

            }
            catch (ExcepcionEsVacio ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            catch (ExcepcionNoExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            catch (ExcepcionExisteID ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void VerificarCliente()
        {


            mantenimiento.VerificarExisteCliente(strCedula);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            strCedula = tbCedula.Text;
            FillDataGridCliente(strCedula);
            try
            {
                VerificarCliente();
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


        private void FillDataGridCliente(String strCedula)
        {
            dataGridViewC.DataSource = mantenimiento.GetClientes(strCedula);
            dataGridViewC.Columns.RemoveAt(5);
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFactura.Text == String.Empty)
                {
                    throw new ExcepcionEsVacio();
                }
                else if (mantenimientoFactura.ListaFacturaVacia(tbFactura.Text))
                {
                    MessageBox.Show("Verificado, ya no podra editar este campo", "Aviso");
                    tbFactura.Enabled = false;
                    btnVerificar.Enabled = false;
                }
                else
                {
                    throw new ExcepcionExisteID("El numero de factura ya existe, ingrese uno diferente");
                }
            }
            catch (ExcepcionExisteID ex)
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

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            strCedula = tbCedula.Text;
            FillDataGridCliente("");
            try
            {
                VerificarCliente();
                DialogResult opcion = MessageBox.Show($"¿Desea seleccionar al cliente con ID: {strCedula} ?", "Confirmar", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {

                    FillDataGridCliente(strCedula);
                    btnSeleccionar.Enabled = false;
                    btnBuscar.Enabled = false;
                    tbCedula.Enabled = false;
                }
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
    }
}

