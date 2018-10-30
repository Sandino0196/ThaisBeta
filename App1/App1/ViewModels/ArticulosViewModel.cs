using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using App1.Models;
using App1.Services;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ArticulosViewModel:BaseViewModel
    {
        #region Atributos
        private ObservableCollection<ProductoItemViewModel> listadoProductos;
        private bool isRefreshing;
        private string filtro;
        private List<Productos> listaP;
        #endregion

        #region Propiedades
        public ObservableCollection<ProductoItemViewModel> ListadoProductos
        {
            get { return this.listadoProductos; }
            set { setValue(ref this.listadoProductos, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { setValue(ref this.isRefreshing, value); }
        }

        public string Filtro
        {
            get { return this.filtro; }
            set
            {
                setValue(ref this.filtro, value);
                this.Search();
            }
        }
        #endregion

        #region Servicios
        private ApiService apiService;
        #endregion

        #region Constructores
        public ArticulosViewModel()
        {
            this.apiService = new ApiService();
            this.LoadArticulos();
        }
        #endregion

        #region Metodos
        private IEnumerable<ProductoItemViewModel> ToProductoItemViewModel()
        {
            return this.listaP.Select(l => new ProductoItemViewModel
            {
                CodigoProducto = l.CodigoProducto,
                Descripcion = l.Descripcion,
                Imagen = l.Imagen
            });
        }

        private async void LoadArticulos()
        {
            this.IsRefreshing = true;
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "Aceptar");
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
            this.listaP = apiService.Catalogo();
            this.ListadoProductos = new ObservableCollection<ProductoItemViewModel>(
                this.ToProductoItemViewModel());
            this.IsRefreshing = false;
        }
        #endregion

        #region Comandos
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadArticulos);
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return new RelayCommand(Search);
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(this.Filtro))
            {
                this.ListadoProductos = new ObservableCollection<ProductoItemViewModel>(this.ToProductoItemViewModel());
            }
            else
            {
                this.ListadoProductos = new ObservableCollection<ProductoItemViewModel>(
                    this.ToProductoItemViewModel().Where(p => p.Descripcion.ToLower().Contains(this.Filtro.ToLower())));
            }
        }
        #endregion
    }
}
