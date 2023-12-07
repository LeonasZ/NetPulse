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
    public partial class MainTecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MantenimientoNegocio mantenimientoNegocio = new MantenimientoNegocio();
            List<Mantenimiento> listaRealizados = new List<Mantenimiento>();
            List<Mantenimiento> listaPendienteAlta = new List<Mantenimiento>();
            List<Mantenimiento> listaPendienteBaja = new List<Mantenimiento>();
            List<Mantenimiento> mantenimientos = mantenimientoNegocio.listarMantenimientos();
            foreach (var item in mantenimientos)
            {
                if (item.EstadoRealizacion == true)
                {
                    listaRealizados.Add(item);
                }
                if (item.EstadoRealizacion == false)
                {
                    if(item.TipoMantenimiento.IdTipoMantenimiento == 1)
                    {
                        listaPendienteAlta.Add(item);
                    }
                    if ((item.TipoMantenimiento.IdTipoMantenimiento == 2) || (item.TipoMantenimiento.IdTipoMantenimiento == 4))
                    {
                        listaPendienteBaja.Add(item);
                    }
                    if ((item.TipoMantenimiento.IdTipoMantenimiento == 3) || (item.TipoMantenimiento.IdTipoMantenimiento == 5))
                    {
                        listaPendienteBaja.Add(item);
                    }

                }
            }
            dgvPrioridadAlta.DataSource = listaPendienteAlta;
            dgvPrioridadAlta.DataBind();

            dgvPrioridadBaja.DataSource = listaPendienteBaja;
            dgvPrioridadBaja.DataBind();

            dgvListaMantenimientosRealizados.DataSource = listaRealizados;
            dgvListaMantenimientosRealizados.DataBind();
        }

        
        protected void dgvListaMantenimientosPendientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvPrioridadBaja.Rows[rowIndex];

            // Accede a los datos de la fila utilizando los índices de las columnas
            string IdServicio = row.Cells[1].Text;
            string IdMantenimiento = row.Cells[0].Text;

            if (e.CommandName == "Info_onClick")
            {
                Response.Redirect("InfoCliente.aspx?IdServicio=" + IdServicio);
            }
            if (e.CommandName == "Finalizar_onClick")
            {
                Response.Redirect("FinalizarMantenimiento.aspx?IdMantenimiento=" + IdMantenimiento + "&IdServicio=" + IdServicio);
                
            }
        }

    }
}