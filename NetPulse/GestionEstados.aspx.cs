using Dominio;
using Microsoft.Win32;
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
            HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.listarServicios();

            List<Servicio> listaPendientes = new List<Servicio>();
            List<Servicio> listaPendientesActivacion = new List<Servicio>();
            List<Servicio> listaInstalaciones = new List<Servicio>();

            List<HistorialServicio> listaAuxiliar;

            foreach (var item in listaServicios)
            {
                if (item.Estado.Id == 1)
                {
                    listaPendientesActivacion.Add(item);
                }
                if (item.Estado.Id == 2)
                {
                    listaPendientes.Add(item);
                }
                if (item.Estado.Id == 5)
                {
                    listaPendientes.Add(item);
                }

                listaAuxiliar = historialServicioNegocio.listar(item.IdServicio);
                foreach (var i in listaAuxiliar)
                {
                    if ((item.Estado.Id == 2) && (i.TipoCambio.Id == 2))
                    {
                        listaInstalaciones.Add(item);
                    }
                    if ((item.Estado.Id == 5) && (i.TipoCambio.Id == 9))
                    {
                        listaInstalaciones.Add(item);
                    }

                }


            }
            dgvPendienteInstalacion.DataSource = listaPendientes;
            dgvPendienteInstalacion.DataBind();
            dgvPendienteActivacion.DataSource = listaPendientesActivacion;
            dgvPendienteActivacion.DataBind();
            dgvServiciosAprobar.DataSource = listaInstalaciones;
            dgvServiciosAprobar.DataBind();


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

        protected void dgvServiciosAprobar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dgvServiciosAprobar_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvServiciosAprobar.Rows[rowIndex];

            string IdS = row.Cells[0].Text;
            string Estado = row.Cells[6].Text;
            int IdServicio = int.Parse(IdS);


            if (e.CommandName == "Aprobar_onClick")
            {
                //registro en el historial dependiendo el tipomantenimiento realizado
                //guardo el registro en el historial
                HistorialServicio historialServicio = new HistorialServicio();
                HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

                historialServicio.Fecha = DateTime.Now;
                historialServicio.IdServicio = IdServicio;
                historialServicio.TipoCambio = new TipoCambioHistorial();

                ServicioNegocio negocio = new ServicioNegocio();
                if (Estado == "Pendiente a Instalacion")
                {
                    negocio.EditarEstado(IdServicio, 3);
                    historialServicio.TipoCambio.Id = 2; //tipo cambio historial instalacion
                }
                if (Estado == "Inactivo")
                {
                    negocio.EditarEstado(IdServicio, 6);
                    historialServicio.TipoCambio.Id = 9;//tipo cambio historial desinstalacion

                }
                
                historialServicioNegocio.guardar(historialServicio);
                //Response.Write("<script>alert('Mantenimeinto Aprobado Con Exito!');</script>");

                //Falta Implementacion
            }


            Response.Redirect("GestionEstados.aspx");
        }
    }
}