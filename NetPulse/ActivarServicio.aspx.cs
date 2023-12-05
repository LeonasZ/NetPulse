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
        List<FormaPago> formaPagos = new List<FormaPago>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AgregarDireccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 1);
        }

        protected void AgregarPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 2);
        }

        protected void AgregarFormaDePago_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificaciones.aspx?Id=" + 3);
        }

        protected void Finalizar_Click(object sender, EventArgs e)
        {

        }

      
    }
}
/*
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

    servicio.Estado.Id = 1;
    servicio.Estado.Descripcion = "Pendiente a Activacion";
    servicio.FechaAlta = DateTime.Now;
    servicio.Comentarios = inputComentariosServicio.Text;



    //busco el cliente por session y lo cargo al servicio, revisar es posible que nos convenga que el objeto servicio solo contenga id en vez de objetos
    List<Cliente> listaClientesInactivos = (List<Cliente>)Session["clientesInactivos"];

    int IdCliente = int.Parse(Request.QueryString["IdCliente"]);
    servicio.Cliente = new Cliente();
    foreach (var item in listaClientesInactivos)
    {
        if (item.IdCliente == IdCliente)
        {
            servicio.Cliente.Activo = item.Activo;
            servicio.Cliente.Nombre = item.Nombre;
            servicio.Cliente.Telefono = item.Telefono;
            servicio.Cliente.FechaAlta = item.FechaAlta;
            servicio.Cliente.Dni = item.Dni;
            servicio.Cliente.Mail = item.Mail;
            servicio.Cliente.IdCliente = item.IdCliente;

        }
    }

    //cargo el domicilio al servicio, lo mismo con el cliente, para mi habria que cargar soolo el id
    servicio.Domicilio = new Domicilio();
    servicio.Domicilio.Ciudad = domicilio.Ciudad;
    servicio.Domicilio.Direccion = domicilio.Direccion;
    servicio.Domicilio.Barrio = domicilio.Barrio;
    servicio.Domicilio.Comentario = domicilio.Comentario;
    servicio.Domicilio.IdDomicilio = domicilio.IdDomicilio;

    //abono mensual
    AbonoMensual amaux = new AbonoMensual();
    AbonoMensualNegocio abonoMensualNegocio = new AbonoMensualNegocio();
    amaux.FechaVencimiento1 = DateTime.Now;
    amaux.FechaVencimiento2 = DateTime.Now;
    amaux.Pagado = false;
    amaux.FormaPago = new FormaPago();

    amaux.FormaPago.IdFormaPago = formaPagos[DDLMedioDePago.SelectedIndex].IdFormaPago;
    amaux.FormaPago.Nombre = formaPagos[DDLMedioDePago.SelectedIndex].Nombre;

    amaux.IdAbonoMensual = abonoMensualNegocio.agregarAbonoMensual(amaux);

    servicio.AbonoMensual = new AbonoMensual();
    servicio.AbonoMensual.FechaVencimiento1 = amaux.FechaVencimiento1;
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


    //mando el cliente a mantenimiento pendiente (instalacion)


    Mantenimiento mantenimiento = new Mantenimiento();
    MantenimientoNegocio mantenimientoNegocio = new MantenimientoNegocio();

    //asigno el tipo mantenimiento por defecto de la bd que seria el tipo de mantenimiento instalacion
    TipoMantenimientoNegocio tipoMantenimientoNegocio = new TipoMantenimientoNegocio();
    List<TipoMantenimiento> listaTipoMantenimiento = tipoMantenimientoNegocio.listar();

    mantenimiento.TipoMantenimiento = new TipoMantenimiento(); ;
    foreach (var item in listaTipoMantenimiento)
    {
        if (item.IdTipoMantenimiento == 3)
        {
            mantenimiento.TipoMantenimiento.IdTipoMantenimiento = item.IdTipoMantenimiento;
            mantenimiento.TipoMantenimiento.Nombre = item.Nombre;
        }
    }


    mantenimiento.Fecha = DateTime.Now;
    mantenimiento.FechaRealizado = DateTime.Now;
    mantenimiento.Comentarios = "";

    //asigno el tecnico a cargo de las instalaciones -- hay que ver si va a haber un tecnico encargado de instalaciones o sino la forma de poder seleccionar el tecnico acargo
    TecnicoNegocio tecnicoNegocio = new TecnicoNegocio();
    List<Tecnico> listaTecnicos = tecnicoNegocio.listarTecnicos();

    mantenimiento.Tecnico = new Tecnico();
    foreach (var item in listaTecnicos)
    {
        if (item.IdTecnico == 1)
        {
            mantenimiento.Tecnico.IdTecnico = item.IdTecnico;
            mantenimiento.Tecnico.Nombre = item.Nombre;
            mantenimiento.Tecnico.Contacto = item.Contacto;
            mantenimiento.Tecnico.FechaIncorporacion = item.FechaIncorporacion;
            mantenimiento.Tecnico.Estado = item.Estado;
        }
    }



    mantenimiento.EstadoRealizacion = false;
    mantenimiento.Descripcion = "Instalacion";
    mantenimiento.IdServicio = servicio.IdServicio;

    mantenimiento.IdMantenimiento = mantenimientoNegocio.agregarMantenimiento(mantenimiento);


    Response.Redirect("AltaServicio.aspx");

}

protected void Cancelar_Click(object sender, EventArgs e)
{
    Response.Redirect("AltaServicio.aspx");

}
}*/
