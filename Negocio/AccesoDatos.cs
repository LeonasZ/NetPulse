using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        public SqlConnection conection;
        public SqlDataReader lector;
        public SqlCommand cmd;
        public AccesoDatos()
        {
            conection = new SqlConnection("server=.\\SQLEXPRESS;database=BD_NetPulse;integrated security=true");
            cmd = new SqlCommand();

        }
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void setConsulta(string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
        }
        public void setearParametro(string nombre, object valor)
        {
            cmd.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarLectura()
        {
            cmd.Connection = conection;
            try
            {
                conection.Open();
                lector = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error: " + ex.ToString());
                throw ex;
            }

        }
        public int ejecutarAccion()
        {
            cmd.Connection = this.conection;
            int rowsAffected = 0;
            try
            {
                conection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null && !lector.IsClosed)
            {
                lector.Close();
            }
            if (conection != null && conection.State != System.Data.ConnectionState.Closed)
            {
                conection.Close();
            }
        }
    }
}
