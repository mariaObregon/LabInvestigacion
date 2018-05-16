using Negocio;
using System;
using System.Windows.Forms;

namespace InterfazGrafica.InterfazProducto
{
    public partial class FormDatosProducto : Form
    {
        MantenimientoProductos productos;

        public FormDatosProducto()
        {
            productos = new MantenimientoProductos();
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            productos.ActualizarProducto(tbCodigo.Text, tbDescripcion.Text, tbPrecio.Text, tbCantidad.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String strCodigo = tbCodigo.Text;
            String strDescripcion = tbDescripcion.Text;
            String strPrecio = tbPrecio.Text;
            String strCantidad = tbCantidad.Text;
           

            try
            {
                productos.InsertarProducto(strCodigo, strDescripcion, strPrecio, strCantidad);
                MessageBox.Show("Producto ingresado con éxito!", "Mensaje");
                tbCodigo.Clear();
                tbDescripcion.Clear();
                tbPrecio.Clear();
                tbCantidad.Clear();
                
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

        public Button GetButtonModificar()
        {
            return btnModificar;
        }

        public Button GetButtonInsertar()
        {
            return btnIngresar;
        }

   
    }
}
