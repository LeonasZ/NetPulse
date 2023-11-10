using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class AbonoMensual
    {
        public int IdAbonoMensual { get; set; }
        public int IdFormaPago { get; set; }
        public DateTime FechaVencimiento1 { get; set; }
        public DateTime FechaVencimiento2 { get; set; }
        public bool Pagado { get; set; }
    }
}
