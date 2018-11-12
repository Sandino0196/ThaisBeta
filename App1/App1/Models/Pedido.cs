using System.Collections;

namespace App1.Models
{
    public class Pedido
    {
        public ArrayList ProductosPedido { get; set; }
        public string Fecha { get; set; }
        public double Total { get; set; }
    }
}