﻿using System;
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
    }
}
