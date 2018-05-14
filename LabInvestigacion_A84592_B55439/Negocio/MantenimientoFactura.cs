﻿using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{

    public class MantenimientoFactura
    {
        private BaseFactura consultar = new BaseFactura();
       

        private List<LineaDetalle> listaDetalle = new List<LineaDetalle>();

        private void InsertarLinea()
        {

            foreach (LineaDetalle linea in listaDetalle)
            {
                consultar.InsertarLineaDetalle(linea);
            }  
        }

        public void InsertarFactura(String strNumeroFactura, String strCedula)
        {
            if (strCedula.Trim() == string.Empty || strNumeroFactura.Trim() == string.Empty)
            {
                throw new ExcepcionEsVacio();
            }
            else { 
            consultar.InsertarFactura(strNumeroFactura, strCedula);
            InsertarLinea();
        }
        }

        public Boolean ListaFacturaVacia(String strNumeroFactura)
        {
            return !consultar.GetFacturaByFacturaId(strNumeroFactura).Any<Factura>();
        }


        public void addList(String strNumeroFactura, String strNumeroLinea, String strCodigo,
                                  String strPrecio, String strCantidad) {
            LineaDetalle linea = new LineaDetalle {

                IdFactura = Int64.Parse(strNumeroFactura),
                IdLineaDetalle = Int64.Parse(strNumeroLinea),
                Codigo = Int64.Parse(strCodigo),
                Precio = Decimal.Parse(strPrecio),
                Cantidad = Int32.Parse(strCantidad)
            };

            listaDetalle.Add(linea);

        }

        public void ExisteNumeroDetalle(String strDetalle) {

           
            for (int i = 0; i < listaDetalle.Count(); i++)
            {
                Int64 id = listaDetalle.ElementAt<LineaDetalle>(i).IdLineaDetalle;
                if (id == Int64.Parse(strDetalle)) {
                    throw new ExcepcionExisteID("El numero de linea de detalle ya existe, ingrese otro");
                }
              
            }
    
        }

        public Decimal subTotal() {
            Decimal subTotal= 0;
            for (int i= 0; i < listaDetalle.Count(); i++)
            {
             Decimal precio =  listaDetalle.ElementAt<LineaDetalle>(i).Precio;
             int cantidad = listaDetalle.ElementAt<LineaDetalle>(i).Cantidad;
                subTotal += precio * cantidad;
            }

            return subTotal;
        }

    }
}
