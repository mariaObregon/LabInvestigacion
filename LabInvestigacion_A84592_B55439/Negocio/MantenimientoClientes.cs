using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            consultar.InsertarCliente(cedula, nombre, apellido, correo, telefono);
        }

        public void EliminarCliente(String cedula) {

            consultar.EliminarCliente(cedula);
        }

        public String MostrarCliente(String cedula) {
            
            String datos = null;
            List<Cliente> lista = consultar.GetClientes(cedula);
            foreach (var item in lista)
                datos += "Cedula: " + item.Cedula + String.Format(Environment.NewLine) + "Nombre: " + item.Nombre + String.Format(Environment.NewLine) + "Apellido: " + item.Apellido + String.Format(Environment.NewLine) +
                    "Correo: " + item.Correo + String.Format(Environment.NewLine) + "Telefono: " + item.Telefono + String.Format(Environment.NewLine) + String.Format(Environment.NewLine);

            return datos;
        }

        

        public void ActualizarCliente(String cedula, String nombre, String apellido, String correo, String telefono)
        {
            if (cedula.Trim() == "" || cedula == null) {
                MessageBox.Show("Cedula vacia", "Error");
            } 
            if (nombre.Trim() == "" || nombre == null) {
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
            return consultar.GetClientes(cedula).Any<Cliente>();
        }

        public List<Cliente> GetClientes(string strCedula) {
            return consultar.GetClientes(strCedula);
        }
    }
       
}
