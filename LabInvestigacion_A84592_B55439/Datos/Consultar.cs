using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class Consultar
    {
        /*Saca a los clientes de la base de datos*/
        //public List<Cliente> GetClientes() {
        public List<Cliente> GetClientes(String cedula) { 
        using (ModeloDB db = new ModeloDB())
            {
                var cliente = from c in db.Cliente
                              where c.Cedula.Equals(cedula)
                              select c;
                
                return cliente.ToList();
               // return db.Cliente.ToList();
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

    }
}
