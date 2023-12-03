using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PrioridadMantenimientoNegocio
    {
        public List<PrioridadMantenimiento> listar()
        {
            List<PrioridadMantenimiento> lista = new List<PrioridadMantenimiento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select Id, Descripcion from PrioridadMantenimiento");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    PrioridadMantenimiento aux = new PrioridadMantenimiento();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion= (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
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
