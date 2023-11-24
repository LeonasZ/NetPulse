using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class FinalizarMantenimiento : System.Web.UI.Page
    {
        MantenimientoNegocio mantenimientoNegocio = new MantenimientoNegocio();
        int IdMantenimiento;
        protected void Page_Load(object sender, EventArgs e)
        {

            IdMantenimiento = int.Parse(Request.QueryString["IdMantenimiento"]);
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            mantenimientoNegocio.activarMantenimiento(IdMantenimiento,TextComentarios.Text);
            Response.Redirect("MainTecnico.aspx");
        }
    }
}