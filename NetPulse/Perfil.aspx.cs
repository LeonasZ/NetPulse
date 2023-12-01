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
            string Usuario = Session["NombreUsuario"].ToString();

            lblNombreUsuario.Text = Session["NombreUsuario"].ToString();

            PerfilNegocio perfilNegocio = new PerfilNegocio();
            dgvPerfiles.DataSource = perfilNegocio.ListarPerfiles(Usuario);
            dgvPerfiles.DataBind();
        }


        //En proceso...
    }
}

