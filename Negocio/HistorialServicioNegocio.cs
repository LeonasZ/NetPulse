using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class HistorialServicioNegocio
    {
        public List<HistorialServicio> listar(int idServicio)
        {
            List<HistorialServicio> lista = new List<HistorialServicio>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("select HS.IdCliente,HS.IdServicio,HS.Fecha,HS.IdTipoCambio,TCH.Descripcion from HistorialServicio HS inner join Tipo_Cambio_Historial TCH on HS.IdTipoCambio = TCH.ID where IdServicio = @idServicio");
                datos.setearParametro("@idServicio", idServicio);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    HistorialServicio aux = new HistorialServicio();
                    aux.IdServicio = idServicio;
                    aux.IdCliente = (int)datos.Lector["IdCliente"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.TipoCambio = new TipoCambioHistorial();
                    aux.TipoCambio.Id = (int)datos.Lector["IdTipoCambio"];
                    aux.TipoCambio.Descripcion = (string)datos.Lector["Descripcion"];

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
