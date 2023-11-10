using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public int IdServicio { get; set; }
        public DateTime Fecha { get; set; }
        public int IdTecnico { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoMantenimiento { get; set; }
        public string Comentarios { get; set; }
        public bool EstadoRealizacion { get; set; }
    }
}
