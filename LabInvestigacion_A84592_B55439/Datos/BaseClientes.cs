using System;
using System.Collections.Generic;
using System.Linq;
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

        public void InsertarCliente(String cedula, String nombre,
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

        public String ModificarCliente(String cedula, String nombre, String apellido, String correo, String telefono)
        {
            using (ModeloDB db = new ModeloDB())
            {

                var cliente = from c in db.Cliente
                              where c.Cedula.Equals(cedula)
                              select c;

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

        public void EliminarCliente(String cedula)
        {
            using (ModeloDB db = new ModeloDB())
            {

                /* Selecciona al cliente */
                var cliente = from c in db.Cliente
                              where c.Cedula == cedula
                              select c;

                /* Si existe algun cliente con esa cedula*/
                if (cliente.Any<Cliente>())
                {
                    //selecciona un unico cliente
                    var clienteAux = cliente.Single<Cliente>();


                    int tamañoListaC = clienteAux.Factura.Count();
                    for (int i = tamañoListaC - 1; i >= 0 ; i--)
                    {
                        
                        Factura facturaActual = clienteAux.Factura.ElementAt<Factura>(i);

                        int tamañoListaF = facturaActual.LineaDetalle.Count();
                        for (int j = tamañoListaF - 1; j >= 0 ; j--)
                        {
                            LineaDetalle detalle = facturaActual.LineaDetalle.ElementAt<LineaDetalle>(j);
                            db.LineaDetalle.Remove(detalle);
                        }

                        db.Factura.Remove(facturaActual);
                    }
     
                    db.Cliente.Remove(clienteAux);
                    db.SaveChanges();
                }
            }
        }
    }
}


