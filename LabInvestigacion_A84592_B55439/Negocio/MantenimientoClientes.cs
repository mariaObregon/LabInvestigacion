using System;
using System.Collections.Generic;
using System.Linq;
using Entidad;
using Datos;
using System.Windows.Forms;

namespace Negocio
{
    public class MantenimientoClientes
    {
        BaseClientes consultar = new BaseClientes();

        public void InsertarCliente(String cedula, String nombre,
                                           String apellido, String correo,
                                           String telefono)
        {

            RegexUtilities regexUtilities = new RegexUtilities();

            if (!ListaVacia(cedula))
            {
                throw new ExcepcionExisteID();
            }
            else if (false)
            {
                throw new ExcepcionCorreoInvalido();
            }
            else if (cedula.Trim() == String.Empty || nombre.Trim() == String.Empty ||
                     apellido.Trim() == String.Empty || correo.Trim() == String.Empty ||
                     telefono.Trim() == String.Empty)
            {
                throw new ExcepcionEsVacio();
            }
            else
            {

                consultar.InsertarCliente(cedula, nombre, apellido, correo, telefono);
            }
        }

        public void EliminarCliente(String cedula)
        {

            consultar.EliminarCliente(cedula);
        }

        public void VerificarExisteCliente(String strCedula) {
            if (strCedula.Trim() == String.Empty) {
                throw new ExcepcionEsVacio("Debe ingresar un numero de cedula");
            }
            else if (ListaVacia(strCedula)) {
                throw new ExcepcionNoExisteID();
            }
        }

        public String MostrarCliente(String cedula)
        {

            String datos = null;
            List<Cliente> lista = consultar.GetClientes(cedula);
            foreach (var item in lista)
                datos += "Cedula: " + item.Cedula + String.Format(Environment.NewLine) + "Nombre: " + item.Nombre + String.Format(Environment.NewLine) + "Apellido: " + item.Apellido + String.Format(Environment.NewLine) +
                    "Correo: " + item.Correo + String.Format(Environment.NewLine) + "Telefono: " + item.Telefono + String.Format(Environment.NewLine) + String.Format(Environment.NewLine);

            return datos;
        }



        public void ActualizarCliente(String cedula, String nombre, String apellido, String correo, String telefono)
        {
            if (cedula.Trim() == "" || cedula == null)
            {
                MessageBox.Show("Cedula vacia", "Error");
            }
            if (nombre.Trim() == "" || nombre == null)
            {
                MessageBox.Show("Nombre vacio", "Error");
            }
            if (apellido.Trim() == "" || apellido == null)
            {
                MessageBox.Show("Apellido vacio", "Error");
            }
            if (correo.Trim() == "" || correo == null)
            {
                MessageBox.Show("Correo vacio", "Error");
            }
            if (telefono.Trim() == "" || telefono == null)
            {
                MessageBox.Show("Telefono vacio", "Error");
            }
            MessageBox.Show(consultar.ModificarCliente(cedula, nombre, apellido, correo, telefono), "Aviso"); ;

        }

        public Boolean ListaVacia(String cedula)
        {
            return !consultar.GetClientes(cedula).Any<Cliente>();
        }


        public List<Cliente> GetClientes(string strCedula)
        {
            return consultar.GetClientes(strCedula);
        }
    }

}
