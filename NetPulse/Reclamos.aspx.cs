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
            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);
            TecnicoNegocio tecnicoNegocio = new TecnicoNegocio();
            List<Tecnico> listaTecnicos = tecnicoNegocio.listarTecnicos();
            int cant = 0;
            string aux;
            if (!IsPostBack)
            {
                DDLPrioridad.Items.Add("Baja");
                DDLPrioridad.Items.Add("Media"); 
                DDLPrioridad.Items.Add("Alta");
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
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Descripcion = inputReclamos.Text;

            TecnicoNegocio tecnicoNegocio = new TecnicoNegocio();

            //Buscar Tecnico
            mantenimiento.Tecnico = tecnicoNegocio.buscarPorNombre(DDLTecnicos.SelectedValue);
            // Buscar Tipo Mantenimiento
            mantenimiento.TipoMantenimiento.IdTipoMantenimiento = DDLPrioridad.SelectedIndex;
        }
    }
}