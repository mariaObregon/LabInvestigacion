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
        public List<Cliente> GetClientes() {
            using (ModeloDB db = new ModeloDB())
            {
                return db.Cliente.ToList();
            }
        }
    }
}
