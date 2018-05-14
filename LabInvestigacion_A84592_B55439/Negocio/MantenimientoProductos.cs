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

        public void InsertarProducto(String strCodigo, String strDescripcion, String strPrecioVenta, String strCantInv)
        {

            if (!ListaVacia(strCodigo))
            {
                throw new ExcepcionExisteID();
            }
           
            else if (strCodigo.Trim() == String.Empty || strDescripcion.Trim() == String.Empty ||
                     strPrecioVenta.Trim() == String.Empty || strCantInv.Trim() == String.Empty)
            {
                throw new ExcepcionEsVacio();
            }
            else
            {
                consultar.InsertarProducto(strCodigo, strDescripcion, strPrecioVenta, strCantInv);
            }
        }

        public void EliminarProducto(String strCodigo) {
            consultar.EliminarProducto(strCodigo);
        }

        public void VerificarExisteProducto(String strCodigo)
        {
            if (strCodigo.Trim() == String.Empty)
            {
                throw new ExcepcionEsVacio();
            }
            else if (ListaVacia(strCodigo))
            {
                throw new ExcepcionNoExisteID("El codigo de producto no existe");
            }
        }

        public Boolean ListaVacia(String strCodigo)
        {
            return !consultar.GetProductos(strCodigo).Any<Producto>();
        }


        public List<Producto> GetProductos(string strCodigo)
        {
            return consultar.GetProductos(strCodigo);
        }
    }
}
