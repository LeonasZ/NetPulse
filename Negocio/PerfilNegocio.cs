using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PerfilNegocio
    {
        /*public List<Perfil> ListarPerfiles()
        {
            List<Perfil> lista = new List<Perfil>();
            AccesoDatosL datos = new AccesoDatosL();

            datos.setConsulta("SELECT IdUsuario, Nombre, Usuario, Contraseña, TipoUsuario FROM Usuarios");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Perfil aux = new Perfil();
                aux.IdUsuario = (int)datos.Lector["IdUsuario"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Usuario = (string)datos.Lector["Usuario"];
                aux.Contraseña = (string)datos.Lector["Contraseña"];
                aux.TipoUsuario = (string)datos.Lector["TipoUsuario"];

                lista.Add(aux);
            }

            datos.cerrarConexion();

            return lista;
        }*/

        public List<Perfil> ListarPerfiles(string nombreU)
        {
            List<Perfil> lista = new List<Perfil>();
            AccesoDatosL datos = new AccesoDatosL();

            datos.setConsulta("Select IdUsuario, Nombre, Usuario, Contraseña, TipoUsuario FROM Usuarios Where Nombre = @nombreU");
            datos.setearParametro("@nombreU", nombreU);
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Perfil aux = new Perfil();
                aux.IdUsuario = (int)datos.Lector["IdUsuario"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Usuario = (string)datos.Lector["Usuario"];
                aux.Contraseña = (string)datos.Lector["Contraseña"];
                aux.TipoUsuario = (string)datos.Lector["TipoUsuario"];

                lista.Add(aux);
            }

            datos.cerrarConexion();

            return lista;
        }
    }
}
