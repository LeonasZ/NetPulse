﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int NroCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion{ get; set; }
        public string Barrio{ get; set; }
        public string Telefono{ get; set; }
        public string Dni { get; set; }
        public string Mail { get; set; }
        public string FormaPago{ get; set; }
        public DateTime FechaAlta { get; set; }
        public int NroPlan { get; set; }
        public bool Activo { get; set; }
    }
}
