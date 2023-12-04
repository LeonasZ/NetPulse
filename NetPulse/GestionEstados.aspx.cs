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
    public partial class GestionEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.listarServicios();

            List<Servicio> listaPendientes = new List<Servicio>();
            List<Servicio> listaPendientesActivacion = new List<Servicio>();
            foreach (var item in listaServicios)
            {
                if(item.Estado.Id == 1)
                {
                    listaPendientesActivacion.Add(item);
                }
                if(item.Estado.Id == 2)
                {
                    listaPendientes.Add(item);
                }
                if (item.Estado.Id == 5)
                {
                    listaPendientes.Add(item);                   
                }
            }
            dgvPendienteInstalacion.DataSource = listaPendientes;
            dgvPendienteInstalacion.DataBind();
            dgvPendienteActivacion.DataSource = listaPendientesActivacion;
            dgvPendienteActivacion.DataBind();

        }
        protected void DgvListaServiciosPendientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvPendienteActivacion.Rows[rowIndex];

            string IdServicio = row.Cells[0].Text;


            if (e.CommandName == "btnActivar_OnClick")
            {
                Response.Redirect("FormActivarServicio.aspx?IdServicio=" + IdServicio);
                //Falta Implementacion
            }


        }
    }
}