using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services.Description;

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

        protected void GridViedgvListaClientes_rowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Obtener el valor del campo bool
                bool valor = Convert.ToBoolean(DataBinder.Eval(e.Row.DataItem, "Activo"));

                // Modificar el valor del campo si es true
                if (valor)
                {
                    e.Row.Cells[5].Text = "Instalado";
                }
                else
                {
                    e.Row.Cells[5].Text = "Usuario Nuevo o Pendiente a Baja";
                }
            }
        }
        protected void dgvListaClientes_rowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Obtener el valor del campo bool
                bool valor = Convert.ToBoolean(DataBinder.Eval(e.Row.DataItem, "Activo"));

                // Modificar el valor del campo si es true
                if (valor)
                {
                    e.Row.Cells[5].Text = "Instalado";
                }
                else
                {
                    e.Row.Cells[5].Text = "Usuario Nuevo o Pendiente a Baja";
                }
            }
        }
        
        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            listaClientes = clienteNegocio.listarClientes();

            //hacer un servicio negocio que filtre por dni cliente para esta parte...

            List<Cliente> listaAux = new List<Cliente>();

            LabelEstado.Text = "Usuario No encontrado";

            dgvUsuarioEncontrado.DataSource = null;
            dgvUsuarioEncontrado.DataBind();

            foreach (var item in listaClientes)
            {

                if (item.Dni == inputDNI.Text)
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
                Response.Redirect("AgregarCliente.aspx");
                
            }

            if (e.CommandName == "AgregarServicio_onClick")
            {
                Response.Redirect("Servicios.aspx");
            }

            if (e.CommandName == "Historial_onClick")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Implementacion no Encontrada" + "');", true);


            }
            /*
            if (e.CommandName == "Historial_onClick")
            {
                Response.Redirect("HistorialMantenimientos.aspx?IdServicio=" + IdServicio);
                //Falta Implementacion
            }*/

        }

    }
}