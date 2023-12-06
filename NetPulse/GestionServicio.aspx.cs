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
    public partial class GestionServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.buscarServicio(IdServicio);

            List<Cliente> ListaCliente = new List<Cliente>();
            List<Domicilio> domicilio = new List<Domicilio>();
            List<TPlan> plan = new List<TPlan>();
            List<FormaPago> formaPagos = new List<FormaPago>();

            ListaCliente.Add(listaServicios[0].Cliente);
            domicilio.Add(listaServicios[0].Domicilio);
            plan.Add(listaServicios[0].Plan);
            formaPagos.Add(listaServicios[0].AbonoMensual.FormaPago);

            dgvDatosCliente.DataSource = ListaCliente;
            dgvDatosCliente.DataBind();

            DgvDomicilio.DataSource = domicilio;
            DgvDomicilio.DataBind();

            DgvPlan.DataSource = plan;
            DgvPlan.DataBind();

            DgvFormaPago.DataSource = formaPagos;
            DgvFormaPago.DataBind();


            //historial

            List<HistorialServicio> listaHistorialServicio = new List<HistorialServicio>();
            HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

            listaHistorialServicio = historialServicioNegocio.listar(IdServicio);

            dgvHistorialServicio.DataSource = listaHistorialServicio;
            dgvHistorialServicio.DataBind();

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Servicios.aspx");
        }


        protected void ModificarDireccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 1);
        }

        protected void ModificarPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 2);
        }

        protected void ModificarFormaDePago_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 3);
        }

        protected void DardeBaja_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 4);
        }
        protected void btnAgendarMantenimiento_Click(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            Response.Redirect("Reclamos.aspx?IdServicio=" + IdServicio);
        }

    }
}