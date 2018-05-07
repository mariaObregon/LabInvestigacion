using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class RecibirDatos
    {
        public static String mostrarCliente(String cedula) {
            Consultar cons = new Consultar();
            String datos = null;
            List<Cliente> lista = cons.GetClientes(cedula);
            foreach (var item in lista)
                datos += "Cedula: " + item.Cedula + String.Format(Environment.NewLine) + "Nombre: " + item.Nombre + String.Format(Environment.NewLine) + "Apellido: " + item.Apellido + String.Format(Environment.NewLine) +
                    "Correo: " + item.Correo + String.Format(Environment.NewLine) + "Telefono: " + item.Telefono + String.Format(Environment.NewLine) + String.Format(Environment.NewLine);

            return datos;
        }
    }
       
}
