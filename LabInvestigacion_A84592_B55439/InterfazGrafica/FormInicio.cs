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
            frmMenuCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenuProducto frmMenuProd = new FormMenuProducto();
            frmMenuProd.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            new FormNuevaFactura().ShowDialog();
        }
    }
}
