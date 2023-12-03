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
    public partial class GestionEstados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.listarServicios();

            List<Servicio> listaPendientes = new List<Servicio>();

            foreach (var item in listaServicios)
            {
                if(item.Estado.Id == 2)
                {
                    listaPendientes.Add(item);
                }
                if (item.Estado.Id == 5)
                {
                    listaPendientes.Add(item);
                    
                }
            }
            dgvPendienteInstalacion.DataSource = listaPendientes;
            dgvPendienteInstalacion.DataBind();

                
        }
    }
}