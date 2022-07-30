﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPOrdenes.Models
{
    public class GeneradosViewModel
    {
        public int id { get; set; }
        public int BaseEntry { get; set; }
        public int DocEntry { get; set; }
        public string Message { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int OrdenCompra { get; set; }
    }
}
