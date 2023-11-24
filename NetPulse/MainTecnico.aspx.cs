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

        
        protected void dgvListaMantenimientosPendientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Info_onClick")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = dgvListaMantenimientosPendientes.Rows[rowIndex];

                // Accede a los datos de la fila utilizando los índices de las columnas
                string IdServicio = row.Cells[1].Text;

                Response.Redirect("InfoCliente.aspx?IdServicio=" + IdServicio);
            }
            if (e.CommandName == "Finalizar_onClick")
            {
                Response.Redirect("FinalizarMantenimiento.aspx");
            }
        }

    }
}