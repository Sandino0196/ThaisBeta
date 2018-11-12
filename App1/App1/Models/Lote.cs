namespace App1.Models
{
    public class Lote:Productos
    {
        public string DescripcionLote { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public bool isVisible { get; set; }
    }
}
