using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace NetPulse
{
    public partial class AgregarTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Tecnico nuevoTecnico = new Tecnico();
                TecnicoNegocio negocio = new TecnicoNegocio();

                nuevoTecnico.Nombre = txtNombre.Text;
                nuevoTecnico.Contacto = txtContacto.Text;
                nuevoTecnico.FechaIncorporacion = DateTime.Now;
                nuevoTecnico.Estado = true;

                negocio.AgregarTecnico(nuevoTecnico);


                /*TecnicoNegocio negocio = new TecnicoNegocio();
                int filasAfectadas;
                filasAfectadas = negocio.AgregarTecnico(nuevoTecnico);

                if (filasAfectadas > 0)
                {
                    lblMensaje.Text = "Técnico agregado correctamente.";
                }
                else
                {
                    lblMensaje.Text = "Error al agregar técnico.";
                }*/
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}