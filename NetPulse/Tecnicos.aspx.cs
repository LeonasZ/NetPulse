﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TecnicoNegocio TecnicoNegocio = new TecnicoNegocio();
            dgvListaTecnicos.DataSource = TecnicoNegocio.listarTecnicos();
            dgvListaTecnicos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Tecnico nuevoTecnico = new Tecnico();
                TecnicoNegocio negocio = new TecnicoNegocio();

                nuevoTecnico.Nombre = txtNombre.Text;
                nuevoTecnico.Contacto = txtContacto.Text;
                nuevoTecnico.FechaIncorporacion = DateTime.Now;
                nuevoTecnico.Estado = true;

                negocio.AgregarTecnico(nuevoTecnico);

                Response.Redirect("Default.aspx");


            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}