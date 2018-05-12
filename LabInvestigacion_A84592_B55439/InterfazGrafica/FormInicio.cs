using InterfazGrafica.InterfazProducto;
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
    }
}
