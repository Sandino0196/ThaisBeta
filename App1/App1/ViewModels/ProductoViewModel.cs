using App1.Models;

namespace App1.ViewModels
{
    public class ProductoViewModel
    {
        #region Propiedades
        public Productos Articulo { get; set; }
        #endregion

        #region Constructores
        public ProductoViewModel(Productos articulo)
        {
            this.Articulo = articulo;
        }
        #endregion
    }
}
