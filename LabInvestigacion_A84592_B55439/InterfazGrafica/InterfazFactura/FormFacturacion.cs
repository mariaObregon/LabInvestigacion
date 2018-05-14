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

namespace InterfazGrafica.InterfazFactura
{
    
    public partial class FormFacturacion : Form
    {
        MantenimientoFactura mantenimiento = new MantenimientoFactura();

        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = mantenimiento.Facturacion(textBox1.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
