using System;
using System.Collections.Generic;
using System.Linq;
using Entidad;
using Datos;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class MantenimientoClientes
    {
        BaseClientes consultar = new BaseClientes();

        public void InsertarCliente(String cedula, String nombre,
                                           String apellido, String correo,
                                           String telefono)
        {

            

            if (!ListaVacia(cedula))
            {
                throw new ExcepcionExisteID();
            }
            else if (!ValidarCorreo(correo))
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
            else if (nombre.Trim() == "" || nombre == null)
            {
                MessageBox.Show("Nombre vacio", "Error");
            }
            else if (apellido.Trim() == "" || apellido == null)
            {
                MessageBox.Show("Apellido vacio", "Error");
            }
            else if (correo.Trim() == "" || correo == null || ValidarCorreo(correo) == false)
            {
                MessageBox.Show("Formato correo invalido", "Error");
            }
            else if (telefono.Trim() == "" || telefono == null)
            {
                MessageBox.Show("Telefono vacio", "Error");
            }
            else
            {
                MessageBox.Show(consultar.ModificarCliente(cedula, nombre, apellido, correo, telefono), "Aviso"); ;
            }
        }

        public Boolean ListaVacia(String cedula)
        {
            return !consultar.GetClientes(cedula).Any<Cliente>();
        }


        public List<Cliente> GetClientes(string strCedula)
        {
            return consultar.GetClientes(strCedula);
        }


        public Boolean ValidarCorreo(String correo)
        {
            Regex oRegExp = new Regex(@"^[A-Za-z0-9_.\-]+@[A-Za-z0-9_\-]+\.([A-Za-z0-9_\-]+\.)*[A-Za-z][A-Za-z]+$", RegexOptions.IgnoreCase);
            return oRegExp.Match(correo).Success;
        }
    }

}
