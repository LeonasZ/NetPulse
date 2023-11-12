using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class AgregarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Capturar datos de el form*/
            Cliente cliente = new Cliente();
            cliente.Nombre = inputName.Text;
            cliente.Telefono = inputTelefono.Text;
            cliente.Dni = inputDNI.Text;
            cliente.Activo = true;
            cliente.Mail = inputEmail.Text;
            cliente.FechaAlta = Calendar1.SelectedDate;

            /*Agregar a Clientes*/

            Response.Redirect("AltaServicio.aspx");
        }
    }
}