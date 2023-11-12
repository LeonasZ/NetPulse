using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            datos.setConsulta("Select IdCliente, Nombre, Telefono, Mail, Dni, FechaAlta, Activo from Cliente");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Cliente aux = new Cliente();
                aux.IdCliente = (int)datos.Lector["IdCliente"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Telefono = (string)datos.Lector["telefono"];
                aux.Mail = (string)datos.Lector["mail"];
                aux.Dni = (string)datos.Lector["Dni"];
                aux.FechaAlta = (DateTime)datos.Lector["FechaAlta"];
                aux.Activo = (bool)datos.Lector["Activo"];


                lista.Add(aux);
            }

            return lista;
        }
    }

}
