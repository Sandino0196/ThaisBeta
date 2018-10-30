using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Lote:Productos
    {
        public string DescripcionLote { get; set; }
        public double Precio { get; set; }
    }
}
