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
            List<Servicio> listaAux = new List<Servicio>();

            LabelEstado.Text = "Usuario No encontrado";

            dgvUsuarioInactivo.DataSource = null;
            dgvUsuarioInactivo.DataBind();

            dgvUsuarioEncontrado.DataSource = null;
            dgvUsuarioEncontrado.DataBind();

            foreach (var item in listaServicios)
            {


                if (item.Cliente.Dni == inputDNI.Text && item.Estado == true)
                {
                    LabelEstado.Text = "Servicio Activo Encontrado";
                    aux.IdServicio = item.IdServicio;

                    aux.Cliente = new Cliente();
                    aux.Cliente.Nombre = item.Cliente.Nombre;
                    aux.Domicilio = new Domicilio();
                    aux.Domicilio.Direccion = item.Domicilio.Direccion;
                    aux.Cliente.Dni = item.Cliente.Dni;
                    aux.Cliente.Telefono = item.Cliente.Telefono;
                    aux.FechaAlta = item.FechaAlta;
                    aux.Estado = true;
                    listaAux.Add(aux);
                    LabelActivo.Text = "Activo";

                    dgvUsuarioEncontrado.DataSource = listaAux;
                    dgvUsuarioEncontrado.DataBind();
                }

                if (item.Cliente.Dni == inputDNI.Text && item.Estado == false)
                {
                    LabelEstado.Text = "Servicio Inactivo Encontrado";
                    aux.IdServicio = item.IdServicio;

                    aux.Cliente = new Cliente();
                    aux.Cliente.Nombre = item.Cliente.Nombre;
                    aux.Domicilio = new Domicilio();
                    aux.Domicilio.Direccion = item.Domicilio.Direccion;
                    aux.Cliente.Dni = item.Cliente.Dni;
                    aux.Cliente.Telefono = item.Cliente.Telefono;
                    aux.FechaAlta = item.FechaAlta;
                    listaAux.Add(aux);
                    LabelActivo.Text = "Inactivo";

                    dgvUsuarioInactivo.DataSource = listaAux;
                    dgvUsuarioInactivo.DataBind();
                }

            }


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

        protected void dgvUsuarioEncontrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdServicio = int.Parse(dgvUsuarioEncontrado.SelectedDataKey.Value.ToString());

            Response.Redirect("AgendarMantenimiento.aspx?IdServicio=" + IdServicio);
        }

        protected void DgvListaClientesInactivos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvUsuarioInactivo.Rows[rowIndex];

            string IdServicio = row.Cells[0].Text;
            

            if (e.CommandName == "Activar_onClick")
            {
                ServicioNegocio servicioNegocio = new ServicioNegocio();
                servicioNegocio.activarServicio(int.Parse(IdServicio));             
                Response.Redirect("Servicios.aspx");
            }
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