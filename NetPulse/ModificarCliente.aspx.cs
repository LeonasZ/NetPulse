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
    public partial class ModificarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int IdCliente = int.Parse(Request.QueryString["IdCliente"]);
            ClienteNegocio negocio = new ClienteNegocio();
            List<Cliente> lista = negocio.buscarCliente(IdCliente);
            if (!IsPostBack)
            {
                inputName.Text = lista[0].Nombre.ToString();
                inputDNI.Text = lista[0].Dni.ToString();
                inputEmail.Text = lista[0].Mail.ToString();
                inputTelefono.Text = lista[0].Telefono.ToString();
                Calendar1.SelectedDate = lista[0].FechaAlta;
            }
            
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            /*Capturar datos de el form*/
            int IdCliente = int.Parse(Request.QueryString["IdCliente"]);
            ClienteNegocio negocio = new ClienteNegocio();
            Cliente cliente = new Cliente();

            cliente.Nombre = inputName.Text;
            cliente.Telefono = inputTelefono.Text;
            cliente.Dni = inputDNI.Text;
            cliente.Activo = true;
            cliente.Mail = inputEmail.Text;
            cliente.FechaAlta = Calendar1.SelectedDate;

            negocio.modificarCliente(IdCliente,cliente);

            Response.Redirect("Default.aspx");
        }
    }
}
