using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Servicio
    {
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public int IdDomicilio { get; set; }
        public int IdPlan { get; set; }
        public int IdAbonoMensual { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Estado { get; set; }
        public string Comentarios { get; set; }
    }
}
