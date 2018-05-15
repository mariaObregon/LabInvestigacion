using Datos;
using Entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{

    public class MantenimientoFactura
    {
        private BaseFactura consultar = new BaseFactura();
        private MantenimientoProductos mantenimientoProductos = new MantenimientoProductos();

        private List<LineaDetalle> listaDetalle = new List<LineaDetalle>();

        private void InsertarLinea()
        {

            foreach (LineaDetalle linea in listaDetalle)
            {
                consultar.InsertarLineaDetalle(linea);
                mantenimientoProductos.ModificarInventario((linea.Codigo).ToString(), (linea.Cantidad).ToString());
            }
        }

        public void InsertarFactura(String strNumeroFactura, String strCedula)
        {
            if (strCedula.Trim() == string.Empty || strNumeroFactura.Trim() == string.Empty)
            {
                throw new ExcepcionEsVacio();
            }
            else
            {
                consultar.InsertarFactura(strNumeroFactura, strCedula);
                InsertarLinea();
            }
        }

        public Boolean ListaFacturaVacia(String strNumeroFactura)
        {
            return !consultar.GetByFacturaId(strNumeroFactura).Any<Factura>();
        }


        public void addList(String strNumeroFactura, String strNumeroLinea, String strCodigo,
                                  String strPrecio, String strCantidad)
        {
            LineaDetalle linea = new LineaDetalle
            {

                IdFactura = Int64.Parse(strNumeroFactura),
                IdLineaDetalle = Int64.Parse(strNumeroLinea),
                Codigo = Int64.Parse(strCodigo),
                Precio = Decimal.Parse(strPrecio),
                Cantidad = Int32.Parse(strCantidad)
            };

            listaDetalle.Add(linea);

        }

        public void ExisteNumeroDetalle(String strDetalle)
        {


            for (int i = 0; i < listaDetalle.Count(); i++)
            {
                Int64 id = listaDetalle.ElementAt<LineaDetalle>(i).IdLineaDetalle;
                if (id == Int64.Parse(strDetalle))
                {
                    throw new ExcepcionExisteID("El numero de linea de detalle ya existe, ingrese otro");
                }

            }

        }

        public Decimal SubTotal()
        {
            Decimal subTotal = 0;
            for (int i = 0; i < listaDetalle.Count(); i++)
            {
                Decimal precio = listaDetalle.ElementAt<LineaDetalle>(i).Precio;
                int cantidad = listaDetalle.ElementAt<LineaDetalle>(i).Cantidad;
                subTotal += precio * cantidad;
            }

            return subTotal;
        }


        public List<Factura> Facturacion(String cedula, DateTime fechaInicio, DateTime fechaFin)
        {

            MantenimientoClientes mantenimientoClientes = new MantenimientoClientes();

            mantenimientoClientes.VerificarExisteCliente(cedula);

            return consultar.HistorialFacturas(cedula, fechaInicio, fechaFin);
        }

        public string TotalFacturado(String cedula, DateTime fechaInicio, DateTime fechaFin) {
            decimal total = 0;
            foreach (var item in consultar.LineasDetalle(cedula, fechaInicio, fechaFin))
            {
                total += (item.Precio * item.Cantidad);
            }
            return total.ToString();
        }

        public List<LineaDetalle> LineaDetallesHistorial(String cedula, DateTime fechaInicio, DateTime fechaFin) {
            return consultar.LineasDetalle(cedula, fechaInicio, fechaFin);
        }

    }
}
