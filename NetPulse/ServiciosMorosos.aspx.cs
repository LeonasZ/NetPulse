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
    public partial class ServiciosMorosos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios;
            
            List<Servicio> listaInhabilitados = new List<Servicio>();
            listaServicios = servicioNegocio.listarServicios();
            foreach (var item in listaServicios)
            {
                if (item.Estado.Id == 4)
                {
                    listaInhabilitados.Add(item);
                }
            }
            dgvListaDeudores.DataSource = listaInhabilitados;
            dgvListaDeudores.DataBind();

        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {

        }
    }
}