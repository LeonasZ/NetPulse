﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class AgregarPlan1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            TPlan plan = new TPlan();
            plan.CantidadMegas = int.Parse(inputCantMegas.Text);
            plan.Precio = int.Parse(inputPrecio.Text);
            Response.Redirect("Planes.aspx");
        }
    }
}