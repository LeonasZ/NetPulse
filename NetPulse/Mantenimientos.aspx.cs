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
    public partial class Mantenimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MantenimientoNegocio mantenimientoNegocio = new MantenimientoNegocio();
            List<Mantenimiento> listaRealizados = new List<Mantenimiento>();
            List<Mantenimiento> listaPendiente = new List<Mantenimiento>();
            List<Mantenimiento> mantenimientos = mantenimientoNegocio.listarMantenimientos();
            foreach (var item in mantenimientos)
            {
                if (item.EstadoRealizacion == true)
                {
                    listaRealizados.Add(item);
                }
                if (item.EstadoRealizacion == false)
                {
                    listaPendiente.Add(item);
                }
            }
            dgvListaMantenimientosPendientes.DataSource = listaPendiente;
            dgvListaMantenimientosPendientes.DataBind();

            dgvListaMantenimientosRealizados.DataSource = listaRealizados;
            dgvListaMantenimientosRealizados.DataBind();
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnHistorialMantenimientos_Click(object sender, EventArgs e)
        {
            int IdServicio = 1;
            Response.Redirect("HistorialMantenimientos.aspx?IdServicio=" + IdServicio);
            // Revisar
        }

        protected void BtnAgendarMantenimiento_Click(object sender, EventArgs e)
        {
            int IdServicio = 1;
            Response.Redirect("AgendarMantenimiento.aspx?IdServicio=" + IdServicio);
            // Revisar
        }
    }
}