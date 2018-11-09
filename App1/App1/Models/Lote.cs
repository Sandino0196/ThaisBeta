using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Models
{
    public class Lote:Productos
    {
        public string DescripcionLote { get; set; }
        public double Precio { get; set; }
        public bool isVisible { get; set; }
    }
}
