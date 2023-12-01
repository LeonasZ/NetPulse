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

        public List<Perfil> ListarPerfiles(string Usuario)
        {
            List<Perfil> lista = new List<Perfil>();
            AccesoDatosL datos = new AccesoDatosL();

            datos.setConsulta("Select IdUsuario, Nombre, Apellido, Usuario, Mail, Telefono, TipoUsuario From Usuarios Where Usuario = @Usuario");
            datos.setearParametro("@Usuario", Usuario);
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Perfil perfil = new Perfil();
                perfil.IdUsuario = (int)datos.Lector["IdUsuario"];
                perfil.Nombre = (string)datos.Lector["Nombre"];
                perfil.Apellido = (string)datos.Lector["Apellido"];
                perfil.Usuario = (string)datos.Lector["Usuario"];
                perfil.Mail = (string)datos.Lector["Mail"];
                perfil.Telefono = (string)datos.Lector["Telefono"];
                perfil.TipoUsuario = (string)datos.Lector["TipoUsuario"];

                lista.Add(perfil);
            }

            datos.cerrarConexion();

            return lista;
        }
    }
}
