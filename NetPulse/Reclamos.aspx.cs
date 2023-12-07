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
    public partial class Reclamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TecnicoNegocio tecnicoNegocio = new TecnicoNegocio();
            List<Tecnico> listaTecnicos = tecnicoNegocio.listarTecnicos();
            TipoMantenimientoNegocio tipoNegocio = new TipoMantenimientoNegocio();
            List<TipoMantenimiento> listaTipos = tipoNegocio.listar();
            int cant = 0;
            string aux;
            if (!IsPostBack)
            {
                foreach (var item in listaTipos)
                {
                    if(item.Nombre != "Instalacion")
                    {
                        DDLPrioridad.Items.Add(item.Nombre);
                    }
                }
  
                foreach (var item in listaTecnicos)
                {
                    aux = "";
                    cant = tecnicoNegocio.cantMantenimientosPendientes(item.IdTecnico);
                    aux = item.Nombre + " ( " + cant + " )";
                    DDLTecnicos.Items.Add(aux);
                }
            }
            if(cbxMantenimiento.Checked == true)
            {
                lblEstado.Text = "2";
                cbxResolucionTelefonica.Checked = false;
            }
            if (cbxMantenimiento.Checked == false)
            {
                lblEstado.Text = "1";
                
            }
            if(cbxResolucionTelefonica.Checked == true)
            {
                cbxMantenimiento.Checked = false;
            }
        }

        protected void btnReclamo_Click(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);

            Mantenimiento mantenimiento = new Mantenimiento();

            mantenimiento.IdServicio = IdServicio;

            mantenimiento.Fecha = System.DateTime.Today;
            mantenimiento.FechaRealizado = System.DateTime.Today;
            mantenimiento.Descripcion = inputReclamos.Text;
            mantenimiento.Comentarios = "";

            mantenimiento.EstadoRealizacion = false;
            TecnicoNegocio tecnicoNegocio = new TecnicoNegocio();

            //Buscar Tecnico
            mantenimiento.Tecnico = tecnicoNegocio.buscarPorId(DDLTecnicos.SelectedIndex+1);
            // Buscar Tipo Mantenimiento
            TipoMantenimientoNegocio TMNegocio = new TipoMantenimientoNegocio();

            mantenimiento.TipoMantenimiento = TMNegocio.buscarPorNombre( DDLPrioridad.SelectedValue);


            ServicioNegocio servicioNegocio = new ServicioNegocio();

            servicioNegocio.EditarEstado(IdServicio, 5);

            // Agendo Mantenimiento
            MantenimientoNegocio mantenimientoNegocio = new MantenimientoNegocio();
            mantenimientoNegocio.agregarMantenimiento(mantenimiento);
            lblSuccess.Visible = true;

            //guardo registro de mantenimiento en el historial 
            HistorialServicio historialServicio = new HistorialServicio();
            HistorialServicioNegocio historialServicioNegocio = new HistorialServicioNegocio();

            historialServicio.Fecha = DateTime.Now;
            historialServicio.IdServicio = IdServicio;
            historialServicio.TipoCambio = new TipoCambioHistorial();
            historialServicio.TipoCambio.Id = 7; //nro 7 reclamo/mantenimiento

            historialServicioNegocio.guardar(historialServicio);

            //Response.Redirect("Reclamos.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);

            Response.Redirect("GestionServicio.aspx?Estado=" + 1 + "&IdServicio=" + IdServicio);
        }
    }
}