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
            //List<Cliente> listaClientes = new List<Cliente>();
            //ClienteNegocio clienteNegocio = new ClienteNegocio();
            //listaClientes = clienteNegocio.listarClientes();

            List<Servicio> listaServicios = new List<Servicio>();
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            listaServicios = servicioNegocio.listarServicios();

            //hacer un servicio negocio que filtre por dni cliente para esta parte...

            LabelEstado.Text = "El Elemento NO Existe o no se encuentra Activo ";

            Servicio aux = new Servicio();
            List<Servicio> listaAux= new List<Servicio>();



            foreach (var item in listaServicios)
            {

                if (item.Cliente.Dni == inputDNI.Text && item.Estado == true)
                {
                    LabelEstado.Text = "Servicio Activo Encontrado";
                    aux.IdServicio= item.IdServicio;

                    aux.Cliente = new Cliente();
                    aux.Cliente.Nombre = item.Cliente.Nombre;
                    aux.Domicilio = new Domicilio();
                    aux.Domicilio.Direccion = item.Domicilio.Direccion;
                    aux.Cliente.Dni = item.Cliente.Dni;
                    aux.Cliente.Telefono= item.Cliente.Telefono;
                    aux.FechaAlta = item.FechaAlta;
                    listaAux.Add(aux);

                   

                }
            }
            dgvUsuarioEncontrado.DataSource = listaAux;
            dgvUsuarioEncontrado.DataBind();

        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarCliente.aspx");
        }

        protected void dgvListaClientesInactivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdCliente = int.Parse(dgvListaClientesInactivos.SelectedDataKey.Value.ToString());
            Response.Redirect("ActivarServicio.aspx?IdCliente=" + IdCliente);
        }

        protected void lnkBtnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void lnkBtnMantenimiento_Click(object sender, EventArgs e)
        {


        }

        protected void dgvUsuarioEncontrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(dgvUsuarioEncontrado.SelectedDataKey.Value.ToString());

            Response.Redirect("AgendarMantenimiento.aspx?IdServicio=" + IdServicio);
        }
    }
}