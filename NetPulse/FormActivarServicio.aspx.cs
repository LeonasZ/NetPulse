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
            List < Servicio > listaServicios = servicioNegocio.buscarServicio(IdServicio);

            List<Cliente> ListaClientes = new List<Cliente>();
            List<Domicilio> domicilio = new List<Domicilio>();
            List<TPlan> plan = new List<TPlan>();
            ListaClientes.Add( listaServicios[0].Cliente);
            domicilio.Add(listaServicios[0].Domicilio);
            plan.Add(listaServicios[0].Plan);

            dgvDatosCliente.DataSource = ListaClientes;
            dgvDatosCliente.DataBind();

            DgvDomicilio.DataSource = domicilio;
            DgvDomicilio.DataBind();

            DgvPlan.DataSource = plan;
            DgvPlan.DataBind();
            

        }

        protected void btnActivarServicio_Click(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.buscarServicio(IdServicio);

            servicioNegocio.EditarEstado(IdServicio, 2);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Se Genero un pedido de Instalacion para el Servicio Solicitado" + "');", true);
            Response.Redirect("GestionEstados.aspx");
        }

        protected void btnModificarServicio_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("GestionEstados.aspx");
        }
    }
}