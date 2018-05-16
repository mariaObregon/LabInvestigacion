using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            FormConsultarCliente frm2 = new FormConsultarCliente();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDatosUsuario datosUsuario = new FormDatosUsuario();
            datosUsuario.GetButtonModificar().Visible = true;
            datosUsuario.ShowDialog();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            FormDatosUsuario datosUsuario = new FormDatosUsuario();
            datosUsuario.GetButtonInsertar().Visible = true;
            datosUsuario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminarCliente eliminarCliente = new FormEliminarCliente();
            eliminarCliente.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.White,
                                                                       Color.Silver,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void MenuCliente_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
