using App1.Models;
using App1.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace App1.ViewModels
{
    public class ListaViewModel: BaseViewModel
    {
                
        #region Atributos
        private ObservableCollection<ProductoItemViewModel> lista;
      //  private bool isRefreshing;

        private string filtro;
        private List<Lote> listaP;
        #endregion

        #region Propiedades
        public ObservableCollection<ProductoItemViewModel> Lista
        {
            get { return this.lista; }
            set { setValue(ref this.lista, value); }
        }

        public string Filtro
        {
            get { return this.filtro; }
            set
            {
                setValue(ref this.filtro, value);
            }
        }
        #endregion

        #region Servicios
        private ApiService apiService;
        #endregion

        #region Constructores
        public ListaViewModel()
        {
            this.apiService = new ApiService();
        }
        #endregion

        #region Metodos
        private IEnumerable<ProductoItemViewModel> ToProductoItemViewModel()
        {
            return this.listaP.Select(l => new ProductoItemViewModel
            {
                CodigoProducto = l.CodigoProducto,
                Descripcion = l.Descripcion,
                Imagen = l.Imagen,
                DescripcionLote = l.DescripcionLote,
                Precio = l.Precio
            });
        }
        #endregion

    }
}
