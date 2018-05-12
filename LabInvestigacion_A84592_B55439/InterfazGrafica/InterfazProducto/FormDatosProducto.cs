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

namespace InterfazGrafica.InterfazProducto
{
    public partial class FormDatosProducto : Form
    {
        public FormDatosProducto()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MantenimientoProductos productos = new MantenimientoProductos();
            productos.ActualizarProducto(tbCodigo.Text, tbDescripcion.Text, tbPrecio.Text, textBox4.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
