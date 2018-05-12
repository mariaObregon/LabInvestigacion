using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace InterfazGrafica.InterfazProducto
{
    public partial class FormConsultarProducto : Form
    {
        public FormConsultarProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mantenimiento = new MantenimientoProductos();
            textBox1.Text = mantenimiento.mostrarProducto(textBox2.Text);
        }
    }
}
