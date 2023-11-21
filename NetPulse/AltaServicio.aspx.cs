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
            
            lblIDCliente.Text = "";
            lblNombre.Text = "";
            lblDni.Text = "";
            lblTelefono.Text = "";
            lblFechaAlta.Text = "";
            lnkBtnModificar.Visible = false;

            foreach (var item in listaClientes)
            {                             
                if(item.Dni == inputDNI.Text && item.Activo == false)
                {
                    LabelEstado.Text = "Elemento Existente Inactivo Encontrado";                  
                    lblIDCliente.Text = item.IdCliente.ToString();
                    lblNombre.Text = item.Nombre.ToString();
                    lblDni.Text = item.Dni.ToString();
                    lblTelefono.Text = item.Telefono.ToString();
                    lblFechaAlta.Text = item.FechaAlta.ToString();
                    lnkBtnModificar.Visible = true;
                }
             
            }
           
        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx");
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