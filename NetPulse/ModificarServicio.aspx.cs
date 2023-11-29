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
    public partial class ModificarServicio : System.Web.UI.Page
    {
        List<FormaPago> formaPagos = new List<FormaPago>();
        protected void Page_Load(object sender, EventArgs e)
        {
            PlanNegocio planNegocio = new PlanNegocio();
            List<TPlan> plans = new List<TPlan>();
            plans = planNegocio.listar();
            FormaPagoNegocio servicioFP = new FormaPagoNegocio();
            formaPagos = servicioFP.listar();

            ServicioNegocio servicioNegocio = new ServicioNegocio();
            List<Servicio> listaServicios = servicioNegocio.listarServicios();
            Servicio servicioAux;

            int IdServicio = int.Parse(Request.QueryString["IdServicio"]);

            foreach (var item in listaServicios)
            {
                if (item.IdServicio == IdServicio)
                {
                    servicioAux = item;
                    inputDireccion.Text = servicioAux.Domicilio.Direccion;
                    inputCiudad.Text = servicioAux.Domicilio.Ciudad;
                    inputBarrio.Text = servicioAux.Domicilio.Barrio;
                    
                }
            }
            if (!IsPostBack)
            {
                foreach (var item in plans)
                {
                    DDLPlanes.Items.Add(item.IdPlan.ToString());
                }
                foreach (var item in formaPagos)
                {
                    DDLMedioDePago.Items.Add(item.Nombre.ToString());
                }
            }

            inputPrecio.Text = plans[DDLPlanes.SelectedIndex].Precio.ToString();
            inputCantMegas.Text = plans[DDLPlanes.SelectedIndex].CantidadMegas.ToString();
            inputIdPlan.Text = plans[DDLPlanes.SelectedIndex].IdPlan.ToString();
        }
    }
}