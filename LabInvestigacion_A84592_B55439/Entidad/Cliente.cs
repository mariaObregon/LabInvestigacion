//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
       
        public Cliente()
        {
            this.HistoricoFacturacion = new HashSet<HistoricoFacturacion>();
        }
    
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    
        public virtual ICollection<HistoricoFacturacion> HistoricoFacturacion { get; set; }
    }
}
