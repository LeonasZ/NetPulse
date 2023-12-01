using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NetPulse
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            string Usuario = Session["NombreUsuario"].ToString();

            //lblUsuario.Text = Session["NombreUsuario"].ToString();

            PerfilNegocio perfilNegocio = new PerfilNegocio();
            dgvPerfiles.DataSource = perfilNegocio.ListarPerfiles(Usuario);

            dgvPerfiles.AutoGenerateColumns = false;
            dgvPerfiles.Columns.Clear();
            dgvPerfiles.Columns.Add(new BoundField { DataField = "IdUsuario", HeaderText = "ID Usuario" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "Nombre", HeaderText = "Nombre" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "Apellido", HeaderText = "Apellido" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "Usuario", HeaderText = "Usuario" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "Mail", HeaderText = "Mail" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "Telefono", HeaderText = "Telefono" });
            dgvPerfiles.Columns.Add(new BoundField { DataField = "TipoUsuario", HeaderText = "Tipo de Usuario" });
            dgvPerfiles.DataBind();
        }


        //En proceso...
    }
}

