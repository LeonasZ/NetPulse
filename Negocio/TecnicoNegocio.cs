using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TecnicoNegocio
    {
        public List<Tecnico> listarTecnicos()
        {
            List<Tecnico> lista = new List<Tecnico>();
            AccesoDatos datos = new AccesoDatos();

            datos.setConsulta("select IdTecnico, Nombre, Contacto, FechaIncorporacion, Estado from Tecnico");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Tecnico aux = new Tecnico();
                aux.IdTecnico = (int)datos.Lector["IdTecnico"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Contacto = (string)datos.Lector["Contacto"];
                aux.FechaIncorporacion = (DateTime)datos.Lector["FechaIncorporacion"];
                aux.Estado = (bool)datos.Lector["Estado"];


                lista.Add(aux);
            }

            return lista;
        }

        public int AgregarTecnico(Tecnico nuevoTecnico)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("INSERT INTO Tecnico (Nombre, Contacto, FechaIncorporacion, Estado) VALUES (@Nombre, @Contacto, @FechaIncorporacion, @Estado)");

                datos.setearParametro("@Nombre", nuevoTecnico.Nombre);
                datos.setearParametro("@Contacto", nuevoTecnico.Contacto);
                datos.setearParametro("@FechaIncorporacion", nuevoTecnico.FechaIncorporacion);
                datos.setearParametro("@Estado", nuevoTecnico.Estado);
                return datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
