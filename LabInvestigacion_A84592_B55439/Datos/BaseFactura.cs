using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class BaseFactura
    {
        public void InsertarLineaDetalle(LineaDetalle lD_linea)
        {
            using (ModeloDB db = new ModeloDB())
            {
                db.LineaDetalle.Add(lD_linea);
                db.SaveChanges();
            }
        }

    

        public void InsertarFactura(String strNumeroFactura, String strCedula)
        {
            using (ModeloDB db = new ModeloDB())
            {
                Factura factura = new Factura
                {
                    IdFactura = Int64.Parse(strNumeroFactura),
                    Cedula = strCedula,
                    FechaFactura = db.Database.SqlQuery<DateTime>("SELECT GETDATE() Fecha").SingleOrDefault()

            };
                db.Factura.Add(factura);
                db.SaveChanges();
            }
        }

        public List<Factura> GetFacturaByFacturaId(String strFacturaID)
        {
            Int64 aux = Int64.Parse(strFacturaID);
            using (ModeloDB db = new ModeloDB())
            {
                var factura = from f in db.Factura
                              where f.IdFactura.Equals(aux)
                              select f;

                return factura.ToList();
            }
        }
    }
}
