using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class BaseClientes
    {
        /*Saca a los clientes de la base de datos*/
        public List<Cliente> GetClientes(String cedula)
        {
            using (ModeloDB db = new ModeloDB())
            {
                var cliente = from c in db.Cliente
                              where c.Cedula.Equals(cedula)
                              select c;

                return cliente.ToList();
            }
        }

        /*Ingresa un cliente a la base de datos*/

        public void insertarCliente(String cedula, String nombre,
                                    String apellido, String correo,
                                    String telefono)
        {
            using (ModeloDB db = new ModeloDB())
            {
                Cliente nuevoCliente = new Cliente
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Correo = correo,
                    Telefono = telefono
                };
                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
        }

        public String modificarCliente(String cedula, String nombre, String apellido, String correo, String telefono)
        {
            using (ModeloDB db = new ModeloDB())
            {

                var cliente = GetClientes(cedula);

                if (cliente.Any<Cliente>())
                {
                    foreach (var c in cliente)
                    {
                        c.Nombre = nombre;
                        c.Apellido = apellido;
                        c.Correo = correo;
                        c.Telefono = telefono;

                    }
                    db.SaveChanges();

                    return "Cliente modificado con exito";
                }
                else
                {
                    return "Cliente no existente";
                }
            }
        }

        public void eliminarCliente(String cedula)
        {
            using (ModeloDB db = new ModeloDB())
            {
        
                /* Selecciona al cliente */
                var cliente = from c in db.Cliente
                              where c.Cedula == cedula
                              select c;

                Console.WriteLine(cliente.Any<Cliente>());

                /* Si existe algun cliente con esa cedula*/
                if (cliente.Any<Cliente>())
                {
                    //selecciona un unico cliente
                    var clienteAux = cliente.Single<Cliente>();


                    foreach (Factura factura in clienteAux.Factura)
                    {
                        var detalle = from d in db.LineaDetalle
                                      where d.IdFactura == factura.IdFactura
                                      select d;

                        foreach (LineaDetalle linea in detalle)
                        {
                            db.LineaDetalle.Remove(linea);
                            Console.WriteLine("elimina linea");
                        }

                        db.Factura.Remove(factura);
                        Console.WriteLine("elimina factura");

                    }

                    db.Cliente.Remove(clienteAux);
                    Console.WriteLine("elimina cliente");
                    db.SaveChanges();



                }
            }
        }
    }
}


