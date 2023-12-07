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
            int IdServicio= int.Parse(Request.QueryString["IdServicio"]);

            mantenimientoNegocio.activarMantenimiento(IdMantenimiento,TextComentarios.Text);
            //guardo el registro en el historial

            HistorialServicio historialServicio = new HistorialServicio();
            HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

            historialServicio.Fecha = DateTime.Now;
            historialServicio.IdServicio = IdServicio;
            historialServicio.TipoCambio = new TipoCambioHistorial();
            //reviso que tipo de mantenimiento es

            if(IdMantenimiento == 1 || IdMantenimiento == 2 || IdMantenimiento == 4)
            {
                historialServicio.TipoCambio.Id = 8; //nro 8 mantenimiento realizado

            }
            else if(IdMantenimiento == 3)
            {
                historialServicio.TipoCambio.Id = 2; //nro 2 instalacion
            }
            else
            {
                historialServicio.TipoCambio.Id = 9; //nro 9 desinstalacion
            }


            historialServicioNegocio.guardar(historialServicio);

            Response.Redirect("MainTecnico.aspx");
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainTecnico.aspx");
        }
    }
}