using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class AgregarTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarTecnico_Click(object sender, EventArgs e)
        {
            Response.Redirect("tecnicos.aspx");
            Tecnico tecnico = new Tecnico();
            tecnico.Contacto = inputContacto.Text;
            tecnico.Nombre = inputNombre.Text;
            tecnico.FechaIncorporacion = Calendar1.SelectedDate;
        }
    }
}