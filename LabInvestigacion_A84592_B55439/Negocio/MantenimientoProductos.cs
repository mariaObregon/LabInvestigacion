using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    "Cantidad en inventario: " + item.CantidadInventario  + String.Format(Environment.NewLine);
            return datos;
        }
    }
}
