using System;
using System.Windows.Forms;

namespace InterfazGrafica.InterfazProducto
{
    public partial class FormMenuProducto : Form
    {
        public FormMenuProducto()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            FormConsultarProducto frm = new FormConsultarProducto();
            frm.ShowDialog();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            FormDatosProducto datosProducto = new FormDatosProducto();
            datosProducto.GetButtonInsertar().Visible = true;
            datosProducto.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            new FormEliminarProducto().ShowDialog(); ;
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            FormDatosProducto frm = new FormDatosProducto();
            frm.GetButtonModificar().Visible = true;
            frm.ShowDialog();
        }
    }
}
