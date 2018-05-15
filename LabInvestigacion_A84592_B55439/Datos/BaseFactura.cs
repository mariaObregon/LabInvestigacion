using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public List<Factura> GetByFacturaId(String strFacturaID)
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

        public List<LineaDetalle> LineasDetalle(String cedula, DateTime fechaInicio, DateTime fechaFin) {


            using (ModeloDB db = new ModeloDB())
            {

                var lineas = from f in db.Factura
                               join ld in db.LineaDetalle 
                               on f.IdFactura equals ld.IdFactura
                               where  f.Cedula.Equals(cedula) && (f.FechaFactura >= fechaInicio && f.FechaFactura <= fechaFin)
                               select ld;
                
                return lineas.ToList();
            }                
        }

        public List<Factura> HistorialFacturas(String cedula, DateTime fechaInicio, DateTime fechaFin)
        {

            using (ModeloDB db = new ModeloDB())
            {

                var facturas = from f in db.Factura
                               where f.Cedula.Equals(cedula) && (f.FechaFactura >= fechaInicio && f.FechaFactura <= fechaFin)
                               select f;

                return facturas.ToList();
            }
        }



    }
}
//from order in Customer.Orders...


/* var historico = from f in db.Factura
                 join ld in db.LineaDetalle on f.IdFactura equals ld.IdFactura
                 group ld by ld.IdFactura into f.IdFactura, f.FechaFactura
                 where f.Cedula.Equals(cedula) && (f.FechaFactura >= fechaFin.Date && f.FechaFactura <= fechaInicio)
                 orderby f.FechaFactura

                 select new
                 {
                     f.IdFactura,
                     f.FechaFactura//,
                     //(ld.Cantidad * ld.Precio)

                 };*/
