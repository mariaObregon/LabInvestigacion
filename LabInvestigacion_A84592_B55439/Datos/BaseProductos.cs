using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class BaseProductos
    {
        /*Saca a los productos de la base de datos*/
        public List<Producto> GetProductos(String codigo)
        {
            using (ModeloDB db = new ModeloDB())
            {
                var producto = from p in db.Producto
                               where p.Codigo.Equals(codigo)
                              select p;

                return producto.ToList();
            }
        }
    }
}
