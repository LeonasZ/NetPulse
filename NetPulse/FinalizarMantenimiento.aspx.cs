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
        int IdTipoMantenimiento;
        protected void Page_Load(object sender, EventArgs e)
        {

            IdMantenimiento = int.Parse(Request.QueryString["IdMantenimiento"]);
            IdTipoMantenimiento = int.Parse(Request.QueryString["IdTipoMantenimiento"]);
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            //cambio el estado

            mantenimientoNegocio.activarMantenimiento(IdMantenimiento, TextComentarios.Text);



            if (IdTipoMantenimiento == 1)
            {
                //guardo el registro en el historial

                ServicioNegocio servicioNegocio = new ServicioNegocio();
                List<Servicio> lista = servicioNegocio.buscarServicio(IdServicio);

                HistorialServicio historialServicio = new HistorialServicio();
                HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

                historialServicio.Fecha = DateTime.Now;
                historialServicio.IdServicio = IdServicio;
                historialServicio.TipoCambio = new TipoCambioHistorial();

                historialServicio.TipoCambio.Id = 8; //nro 8 mantenimiento realizado
                                 
                
                historialServicioNegocio.guardar(historialServicio);

            }


            Response.Redirect("MainTecnico.aspx");
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainTecnico.aspx");
        }
    }
}