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
    public partial class AltaServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            dgvListaClientesInactivos.DataSource = clienteNegocio.listarClientesInactivos();
            dgvListaClientesInactivos.DataBind();
            Session.Add("clientesInactivos", clienteNegocio.listarClientesInactivos());
        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaClientes = clienteNegocio.listarClientes();
            LabelEstado.Text = "El Elemento NO Existe o Esta Activo";
            Cliente clienteAux = new Cliente();
            foreach (var item in listaClientes)
            {                             
                if(item.Dni == inputDNI.Text && item.Activo == false)
                {
                    LabelEstado.Text = "Elemento Existente Inactivo Encontrado";
                    clienteAux = item;
                }
            }
            lblIDCliente.Text = clienteAux.IdCliente.ToString();
            lblNombre.Text = clienteAux.Nombre.ToString();
            lblDni.Text = clienteAux.Dni.ToString();
            lblTelefono.Text = clienteAux.Telefono.ToString();
            lblFechaAlta.Text = clienteAux.FechaAlta.ToString();
            lnkBtnModificar.Visible = true;
        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx");
        }

        protected void btnReincorporar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx");
            /*Carga a los campos desde session, permite modificar y vuelve a activar.*/
        }

        protected void btnAgregarDomicilio_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarDomicilio.aspx");
        }

        protected void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarPlanCliente.aspx");
        }
        protected void dgvListaClientesInactivos_SelectedIndexChanged(object sender,EventArgs e)
        {
            int IdCliente = int.Parse(dgvListaClientesInactivos.SelectedDataKey.Value.ToString());
            Response.Redirect("ActivarServicio.aspx?IdCliente=" + IdCliente);
        }

        protected void lnkBtnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}