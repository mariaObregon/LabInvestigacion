using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;
namespace Negocio
{
    public class MantenimientoProductos
    {
        BaseProductos consultar = new BaseProductos();

        public String mostrarProducto(String codigo)
        {
            String datos = null;
            List<Producto> lista = consultar.GetProductos(codigo);
            foreach (var item in lista)
                datos += "Codigo: " + item.Codigo + String.Format(Environment.NewLine) + "Descripcion: " + item.Descripcion + String.Format(Environment.NewLine) + "Precio: " + item.Precio + String.Format(Environment.NewLine) +
                    "Cantidad en inventario: " + item.CantidadInventario + String.Format(Environment.NewLine);
            return datos;
        }



        public void ActualizarProducto(String codigo, String descripcion, String precio, String cantidadInv)
        {
            if (codigo.Trim() == "" || codigo == null)
            {
                MessageBox.Show("Cedula vacia", "Error");
            }
            if (descripcion.Trim() == "" || descripcion == null)
            {
                MessageBox.Show("Nombre vacio", "Error");
            }
            if (precio.Trim() == "" || precio == null)
            {
                MessageBox.Show("Apellido vacio", "Error");
            }
            if (cantidadInv.Trim() == "" || cantidadInv == null)
            {
                MessageBox.Show("Correo vacio", "Error");
            }
           
            MessageBox.Show(consultar.ModificarProducto(codigo, descripcion, precio, cantidadInv), "Aviso"); ;

        }
    }
}
