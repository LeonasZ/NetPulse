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

            datos.setConsulta("select nroCliente,Nombre,Direccion,Barrio,telefono,mail,Activo,nroPlan from Clientes");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Cliente aux = new Cliente();
                aux.NroCliente = (int)datos.Lector["nroCliente"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Direccion = (string)datos.Lector["Direccion"];
                aux.Barrio = (string)datos.Lector["Barrio"];
                aux.Telefono = (string)datos.Lector["telefono"];
                aux.Mail = (string)datos.Lector["mail"];
                aux.Activo = (bool)datos.Lector["Activo"];
                aux.NroPlan = (int)datos.Lector["nroPlan"];

                lista.Add(aux);
            }

            return lista;
        }
    }

}
