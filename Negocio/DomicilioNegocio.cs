using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class DomicilioNegocio
    {
        public int agregarDomicilio(Domicilio nuevo)
        {
            int iddomicilio = -1;
            string direccion = nuevo.Direccion;
            string barrio = nuevo.Barrio;
            string ciudad = nuevo.Ciudad;
            string comentario = nuevo.Comentario;


            string query = "insert into Domicilio(Direccion,Barrio,Ciudad,Comentario) values (@direccion,@barrio,@ciudad,@comentario)" + "SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID";
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(query);
                datos.setearParametro("@direccion", direccion);
                datos.setearParametro("@barrio", barrio);
                datos.setearParametro("@ciudad", ciudad);
                datos.setearParametro("@comentario", comentario);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    iddomicilio = (int)datos.Lector["ID"];
                }


                return iddomicilio;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }
    }
}

