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
            PerfilNegocio clienteNegocio = new PerfilNegocio();
            dgvPerfiles.DataSource = clienteNegocio.ListarPerfiles();
            dgvPerfiles.DataBind();
        }

        //Esto muestra TODO, no tiene que ser así
        //Después editarlo, esta es la versión muuuy básica
    }
}

