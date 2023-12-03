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
    public partial class FormActivarServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            dgvServicio.DataSource = servicioNegocio.buscarServicio(IdServicio);
            dgvServicio.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}