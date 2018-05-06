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
        public static List<Cliente> GetClientes()
        {
             Consultar cons = new Consultar();
            return cons.GetClientes();
        }
    }
       
}
