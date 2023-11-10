using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ServicioNegocio
    {
        public List<Servicio> listarServicios()
        {
            List<Servicio> lista = new List<Servicio>();
            AccesoDatos datos = new AccesoDatos();


            datos.setConsulta("\tselect IdServicio,C.IdCliente as C.IdCliente  ,C.Nombre as C.Nombre ,C.Telefono as C.Telefono, C.Mail as C.Mail , C.Dni as C.Dni, C.FechaAlta as C.FechaAlta, C.Activo as  C.Activo, \r\n\r\n\tAm.IdAbonoMensual, Am.IdFormaPago, Am.FechaVencimiento1, Am.FechaVencimiento2, Am.Pagado,\r\n\r\n\tFp.IdFormaPago, Fp.Nombre, \r\n\r\n\tP.IdPlan,P.CantidadMegas, P.Precio,\r\n\r\n\tD.IdDomicilio,D.Direccion, D.Barrio, D.Ciudad, D.Comentario,\r\n\r\n\tS.FechaAlta,S.Estado,S.Comentarios from Servicio S\r\n\r\n\tinner join Cliente as C on C.IdCliente = S.IdCliente\r\n\tinner join AbonoMensual as Am on Am.IdAbonoMensual = S.IdAbonoMensual\r\n\tinner join FormaPago as Fp on Fp.IdFormaPago = Am.IdFormaPago\r\n\tinner join TPlan as P on P.IdPlan = S.IdPlan\r\n\tinner join Domicilio as D on D.IdDomicilio = S.IdDomicilio");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Servicio aux = new Servicio();
                // Datos Servicio
                aux.IdServicio = (int)datos.Lector["IdServicio"];
                aux.Comentarios = (string)datos.Lector["Comentarios"];
                aux.FechaAlta = (DateTime)datos.Lector["FechaAlta"];
                aux.Estado = (bool)datos.Lector["Estado"];

                //Datos Cliente
                Cliente ClienteAux = new Cliente();
                ClienteAux.IdCliente = (int)datos.lector["Dato"];
                ClienteAux.Nombre = (string)datos.Lector["C.Nombre"];
                ClienteAux.Telefono = (string)datos.lector["C.Telefono"];
                ClienteAux.Mail = (string)datos.lector["C.Mail"];
                ClienteAux.Dni = (string)datos.lector["C.Dni"];
                ClienteAux.FechaAlta = (DateTime)datos.lector["C.FechaAlta"];
                ClienteAux.Activo = (bool)datos.lector["C.Activo"];

                aux.Cliente = ClienteAux;

                // Datos Abono mensual
                aux.AbonoMensual.IdAbonoMensual = (int)datos.lector["IdAbonoMensual"];
                aux.AbonoMensual.FormaPago.IdFormaPago = (int)datos.lector["IdFormaPago"];
                aux.AbonoMensual.FormaPago.Nombre = (string)datos.lector["Nombre"];
                aux.AbonoMensual.FechaVencimiento1 = (DateTime)datos.lector["FechaVencimiento1"];
                aux.AbonoMensual.FechaVencimiento2 = (DateTime)datos.lector["FechaVencimiento2"];
                aux.AbonoMensual.Pagado = (bool)datos.lector["Pagado"];

                // Datos Plan
                aux.Plan.IdPlan = (int)datos.lector["IdPlan"];
                aux.Plan.CantidadMegas = (int)datos.lector["CantidadMegas"];
                aux.Plan.Precio = (decimal)datos.lector["Precio"];

                // Datos Domicilio
                aux.Domicilio.IdDomicilio = (int)datos.lector["IdDomicilio"];
                aux.Domicilio.Direccion = (string)datos.lector["Direccion"];
                aux.Domicilio.Barrio = (string)datos.lector["Barrio"];
                aux.Domicilio.Ciudad = (string)datos.lector["Ciudad"];
                aux.Domicilio.Comentario = (string)datos.lector["Comentario"];

                lista.Add(aux);
            }

            return lista;
        }
    }
}
