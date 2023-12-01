using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class PerfilTec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            string Usuario = Session["NombreUsuario"].ToString();

            //lblUsuarioTec.Text = Session["NombreUsuario"].ToString();

            PerfilNegocio perfilNegocio = new PerfilNegocio();
            dgvPerfilTec.DataSource = perfilNegocio.ObtenerPerfil(Usuario);

            dgvPerfilTec.AutoGenerateColumns = false;
            dgvPerfilTec.Columns.Clear();
            dgvPerfilTec.Columns.Add(new BoundField { DataField = "IdUsuario", HeaderText = "ID Usuario" });
            dgvPerfilTec.Columns.Add(new BoundField { DataField = "Nombre", HeaderText = "Nombre" });
            dgvPerfilTec.Columns.Add(new BoundField { DataField = "Usuario", HeaderText = "Usuario" });
            dgvPerfilTec.Columns.Add(new BoundField { DataField = "TipoUsuario", HeaderText = "Tipo de Usuario" });
            dgvPerfilTec.DataBind();
        }
    }
}