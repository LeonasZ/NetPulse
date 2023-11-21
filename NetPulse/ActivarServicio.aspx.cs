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
    public partial class ActivarServicio : System.Web.UI.Page
    {
        List<FormaPago> formaPagos = new List<FormaPago>();

        protected void Page_Load(object sender, EventArgs e)
        {

            PlanNegocio planNegocio = new PlanNegocio();
            List<TPlan> plans = new List<TPlan>();
            plans = planNegocio.listar();
            /*Session["Planes"] = plans;*/
            FormaPagoNegocio servicioFP = new FormaPagoNegocio();
            formaPagos = servicioFP.listar();

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

        protected void Activar_Click(object sender, EventArgs e)
        {
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            Servicio servicio = new Servicio();

            //guardo el domicilio en la bd
            Domicilio domicilio = new Domicilio();
            DomicilioNegocio domicilioNegocio = new DomicilioNegocio();

            domicilio.Barrio = inputBarrio.Text;
            domicilio.Ciudad = inputCiudad.Text;
            domicilio.Comentario = inputComentarios.Text;
            domicilio.Direccion = inputDireccion.Text;

            domicilio.IdDomicilio = domicilioNegocio.agregarDomicilio(domicilio);

            //cargo el servicio con el plan elegido
            servicio.Plan = new TPlan();
            servicio.Plan.Precio = decimal.Parse(inputPrecio.Text);
            servicio.Plan.CantidadMegas = int.Parse(inputCantMegas.Text.ToString());
            servicio.Plan.IdPlan = int.Parse(inputIdPlan.Text.ToString());
          
            servicio.Estado = true;
            servicio.FechaAlta = DateTime.Now;
            servicio.Comentarios = inputComentariosServicio.Text;



            //busco el cliente por session y lo cargo al servicio, revisar es posible que nos convenga que el objeto servicio solo contenga id en vez de objetos
            List<Cliente> listaClientesInactivos = (List<Cliente>)Session["clientesInactivos"];

            int IdCliente = int.Parse(Request.QueryString["IdCliente"]);
            servicio.Cliente = new Cliente();
            foreach (var item in listaClientesInactivos)
            {
                if(item.IdCliente == IdCliente)
                {
                    servicio.Cliente.Activo = item.Activo;
                    servicio.Cliente.Nombre= item.Nombre;
                    servicio.Cliente.Telefono = item.Telefono;
                    servicio.Cliente.FechaAlta = item.FechaAlta;
                    servicio.Cliente.Dni= item.Dni;
                    servicio.Cliente.Mail = item.Mail;
                    servicio.Cliente.IdCliente = item.IdCliente;
                    
                }
            }

            //cargo el domicilio al servicio, lo mismo con el cliente, para mi habria que cargar soolo el id
            servicio.Domicilio = new Domicilio();
            servicio.Domicilio.Ciudad = domicilio.Ciudad;
            servicio.Domicilio.Direccion= domicilio.Direccion;
            servicio.Domicilio.Barrio= domicilio.Barrio;
            servicio.Domicilio.Comentario = domicilio.Comentario;
            servicio.Domicilio.IdDomicilio= domicilio.IdDomicilio;

            //abono mensual
            AbonoMensual amaux= new AbonoMensual();
            AbonoMensualNegocio abonoMensualNegocio = new AbonoMensualNegocio();
            amaux.FechaVencimiento1 = DateTime.Now;
            amaux.FechaVencimiento2 = DateTime.Now;
            amaux.Pagado = false;
            amaux.FormaPago = new FormaPago();

            amaux.FormaPago.IdFormaPago = formaPagos[DDLMedioDePago.SelectedIndex].IdFormaPago;
            amaux.FormaPago.Nombre = formaPagos[DDLMedioDePago.SelectedIndex].Nombre;

            amaux.IdAbonoMensual = abonoMensualNegocio.agregarAbonoMensual(amaux);

            servicio.AbonoMensual = new AbonoMensual();
            servicio.AbonoMensual.FechaVencimiento1 =amaux.FechaVencimiento1;
            servicio.AbonoMensual.FechaVencimiento2 = amaux.FechaVencimiento2;
            servicio.AbonoMensual.IdAbonoMensual = amaux.IdAbonoMensual;
            servicio.AbonoMensual.Pagado = amaux.Pagado;

            servicio.AbonoMensual.FormaPago = new FormaPago();
            servicio.AbonoMensual.FormaPago.IdFormaPago = amaux.FormaPago.IdFormaPago;
            servicio.AbonoMensual.FormaPago.Nombre = amaux.FormaPago.Nombre;


            servicio.IdServicio = servicioNegocio.agregarServicio(servicio);

            //activo el cliente en la bd
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            clienteNegocio.activarCliente(servicio.Cliente.IdCliente);

            Response.Redirect("Servicios.aspx");

        }
    }
}