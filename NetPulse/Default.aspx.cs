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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            dgvListaClientes.DataSource = clienteNegocio.listarClientes();
            dgvListaClientes.DataBind();
                      
        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            //List<Cliente> listaClientes = new List<Cliente>();
            //ClienteNegocio clienteNegocio = new ClienteNegocio();
            //listaClientes = clienteNegocio.listarClientes();

            List<Servicio> listaServicios = new List<Servicio>();
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            listaServicios = servicioNegocio.listarServicios();

            //hacer un servicio negocio que filtre por dni cliente para esta parte...

            List<Servicio> listaAux = new List<Servicio>();

            LabelEstado.Text = "Usuario No encontrado";

            dgvUsuarioEncontrado.DataSource = null;
            dgvUsuarioEncontrado.DataBind();

            foreach (var item in listaServicios)
            {

                if (item.Cliente.Dni == inputDNI.Text && item.Estado == true)
                {
                    LabelEstado.Text = "Usuario Encontrado";
  
                    listaAux.Add(item);
                    LabelActivo.Text = "Activo";

                    dgvUsuarioEncontrado.DataSource = listaAux;
                    dgvUsuarioEncontrado.DataBind();
                }   

            }

        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx");
        }       

        protected void dgvUsuarioEncontrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(dgvUsuarioEncontrado.SelectedDataKey.Value.ToString());

            Response.Redirect("AgendarMantenimiento.aspx?IdServicio=" + IdServicio);
        }


        protected void DgvListaClientesActivos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvUsuarioEncontrado.Rows[rowIndex];

            string IdServicio = row.Cells[0].Text;


            if (e.CommandName == "Modificar_onClick")
            {
                Response.Redirect("ModificarServicio.aspx?IdServicio=" + IdServicio);
                //Falta Implementacion
            }

            if (e.CommandName == "BajaLogica_onClick")
            {
                ServicioNegocio servicioNegocio = new ServicioNegocio();
                servicioNegocio.BajaLogica(int.Parse(IdServicio));
                Response.Redirect("Servicios.aspx");
                //Funcionando
            }

            if (e.CommandName == "agendarMantenimiento_onClick")
            {
                Response.Redirect("AgendarMantenimiento.aspx?IdServicio=" + IdServicio);
                //Funcionando
            }

            if (e.CommandName == "Historial_onClick")
            {
                Response.Redirect("HistorialMantenimientos.aspx?IdServicio=" + IdServicio);
                //Falta Implementacion
            }

        }

    }
}