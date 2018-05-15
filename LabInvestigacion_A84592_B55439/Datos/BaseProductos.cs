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

        public List<Producto> GetProductos(String codigo)
        {
            long newCode = long.Parse(codigo);
            using (ModeloDB db = new ModeloDB())
            {
                var producto = from p in db.Producto
                               where p.Codigo == newCode
                               select p;

                return producto.ToList();
            }
        }
        public String ModificarProducto(String codigo, String descripcion, String precioVenta, String cantInv)
        {
            long newCode = long.Parse(codigo);
            using (ModeloDB db = new ModeloDB())
            {

                var producto = from p in db.Producto
                               where p.Codigo == newCode
                               select p;

                if (producto.Any<Producto>())
                {
                    foreach (var p in producto)
                    {
                        p.Descripcion = descripcion;
                        p.Precio = decimal.Parse(precioVenta);
                        p.CantidadInventario = int.Parse(cantInv);

                    }
                    db.SaveChanges();

                    return "Producto modificado con exito";
                }
                else
                {
                    return "Producto no existente";
                }
            }
        }

        public void ModificarCantidad(String strCodigo, String nuevaCantidad)
        {
            long newCode = long.Parse(strCodigo);
            using (ModeloDB db = new ModeloDB())
            {

                var producto = from p in db.Producto
                               where p.Codigo == newCode
                               select p;

                if (producto.Any<Producto>())
                {
                    var aux = producto.Single<Producto>();


                    aux.CantidadInventario = aux.CantidadInventario - int.Parse(nuevaCantidad);


                    db.SaveChanges();
                }
            }
        }

        public void InsertarProducto(String strCodigo, String strDescripcion, String strPrecioVenta, String strCantInv)
        {
            using (ModeloDB db = new ModeloDB())
            {
                Producto nuevoProducto = new Producto
                {
                    Codigo = Int64.Parse(strCodigo),
                    Descripcion = strDescripcion,
                    Precio = Decimal.Parse(strPrecioVenta),
                    CantidadInventario = Int32.Parse(strCantInv)

                };
                db.Producto.Add(nuevoProducto);
                db.SaveChanges();
            }
        }

        public void EliminarProducto(String strCodigo)
        {
            Int64 productParse = Int64.Parse(strCodigo);
            using (ModeloDB db = new ModeloDB())
            {

                /* Selecciona al producto */
                var producto = from p in db.Producto
                               where p.Codigo == productParse
                               select p;


                /* Si existe algun producto con ese codigo*/
                if (producto.Any<Producto>())
                {
                    //selecciona un unico producto
                    var productoAux = producto.Single<Producto>();

                    int tamaño = productoAux.LineaDetalle.Count();
                    
                    for (int i = tamaño - 1; i >= 0; i--)
                    {
                        db.LineaDetalle.Remove(productoAux.LineaDetalle.ElementAt<LineaDetalle>(i)); 
                    }   
                    db.Producto.Remove(productoAux);
                    db.SaveChanges();
                }
            }
        }
    }
}
