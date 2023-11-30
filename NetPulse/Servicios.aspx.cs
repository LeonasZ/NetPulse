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
    public partial class Servicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioNegocio ServicioNegocio = new ServicioNegocio();
            dgvListaServicios.DataSource = ServicioNegocio.listarServicios();
            dgvListaServicios.DataBind();

            Session.Add("listaServicios", ServicioNegocio.listarServicios());

            ServicioNegocio servicioNegocio = new ServicioNegocio();
            dgvListaClientesInactivos.DataSource = servicioNegocio.listarClientesSinServicios();
            dgvListaClientesInactivos.DataBind();


        }
        protected void dgvListaClientesInactivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int IdCliente = int.Parse(dgvListaClientesInactivos.SelectedDataKey.Value.ToString());
            //Response.Redirect("ActivarServicio.aspx?IdCliente=" + IdCliente);
        }
        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {

            List<Servicio> listaServicios = new List<Servicio>();
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            listaServicios = servicioNegocio.listarServicios();

            //hacer un servicio negocio que filtre por dni cliente para esta parte...
            List<Servicio> listaAux = new List<Servicio>();

            LabelEstado.Text = "El usuario no existe o no tiene servicios asociados";

            dgvServicioInactivo.DataSource = null;
            dgvServicioInactivo.DataBind();

            dgvServicioEncontrado.DataSource = null;
            dgvServicioEncontrado.DataBind();

            foreach (var item in listaServicios)
            {


                if (item.Cliente.Dni == inputDNI.Text && item.Estado == true)
                {
                    LabelEstado.Text = "Servicio Activo Encontrado";
                    listaAux.Add(item);

                    LabelActivo.Text = "Activo";

                    dgvServicioEncontrado.DataSource = listaAux;
                    dgvServicioEncontrado.DataBind();
                }

                if (item.Cliente.Dni == inputDNI.Text && item.Estado == false)
                {
                    LabelEstado.Text = "Servicio Inactivo Encontrado";

                    listaAux.Add(item);
                    LabelActivo.Text = "Inactivo";

                    dgvServicioInactivo.DataSource = listaAux;
                    dgvServicioInactivo.DataBind();
                }

            }


        }


        protected void DgvListaServiciosInactivos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvServicioInactivo.Rows[rowIndex];

            string IdServicio = row.Cells[0].Text;


            if (e.CommandName == "Activar_onClick")
            {
                ServicioNegocio servicioNegocio = new ServicioNegocio();
                servicioNegocio.activarServicio(int.Parse(IdServicio));
                Response.Redirect("Servicios.aspx");
            }
        }

        protected void DgvListaServiciosActivos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvServicioEncontrado.Rows[rowIndex];

            string IdServicio = row.Cells[0].Text;


            if (e.CommandName == "Modificar_onClick")
            {
                Response.Redirect("ModificarServicio.aspx?IdServicio=" + IdServicio);
                //Falta Implementacion
            }


        }

    }
}
