using InterfazGrafica.InterfazProducto;
using InterfazGrafica.InterfazFactura;
using System;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FormInicio : Form
    {
       
        public FormInicio()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuCliente frmMenuCliente = new MenuCliente();
            frmMenuCliente.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenuProducto frmMenuProd = new FormMenuProducto();
            frmMenuProd.ShowDialog();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            new FormNuevaFactura().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormFacturacion frm = new FormFacturacion();
            frm.ShowDialog();
        }
    }
}
