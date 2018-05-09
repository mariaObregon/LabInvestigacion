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
        public List<Cliente> GetClientes() { 
        using (ModeloDB db = new ModeloDB())
            {
                var cliente = from c in db.Cliente
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
                  Cedula = cedula, Nombre = nombre, Apellido = apellido,
                  Correo = correo, Telefono = telefono
                };
                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
        }

        public String modificarCliente(String cedula, String nombre, String apellido, String correo, String telefono)
        {
            using (ModeloDB db = new ModeloDB())
            {
             
                var cliente = from c in db.Cliente
                              where c.Cedula == cedula
                              select c;

                if (cliente != null)
                {
                    foreach (var c in cliente) {
                        c.Nombre = nombre;
                        c.Apellido =  apellido;
                        c.Correo = correo;
                        c.Telefono = telefono;
                        
                    }
                    db.SaveChanges();

                    return "Cliente modificado con exito";
                } else {
                    return "Cliente no existente";
                }         
            }
        }

    }
}
