using App1.Models;

namespace App1.ViewModels
{
    public class ProductoViewModel : BaseViewModel
    {
        #region Propiedades
        public Lote Articulo { get; set; }
        #endregion

        #region Constructores
        public ProductoViewModel(Lote articulo)
        {
            this.Articulo = articulo;
        }
        #endregion
    }
}