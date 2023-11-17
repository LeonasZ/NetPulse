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
    public partial class ActivarServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PlanNegocio planNegocio = new PlanNegocio();
            List<TPlan> plans = new List<TPlan>();
            plans = planNegocio.listar();
            /*Session["Planes"] = plans;*/
            if (!IsPostBack)
            {
                foreach (var item in plans)
                {
                    DDLPlanes.Items.Add(item.IdPlan.ToString());
                }
            }

            inputPrecio.Text = plans[DDLPlanes.SelectedIndex].Precio.ToString();
            inputCantMegas.Text = plans[DDLPlanes.SelectedIndex].CantidadMegas.ToString();
            inputIdPlan.Text = plans[DDLPlanes.SelectedIndex].IdPlan.ToString();
        }
    }
}