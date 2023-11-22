using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoMantenimientoNegocio
    {
        public List<TipoMantenimiento> listar()
        {
            List<TipoMantenimiento> listaTipoMantenimiento= new List<TipoMantenimiento>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select IdTipoMantenimiento, Nombre from TipoMantenimiento");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    TipoMantenimiento aux = new TipoMantenimiento();
                    aux.IdTipoMantenimiento= (int)datos.Lector["IdTipoMantenimiento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

                    listaTipoMantenimiento.Add(aux);
                }

                return listaTipoMantenimiento;
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
