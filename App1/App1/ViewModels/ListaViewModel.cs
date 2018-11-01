using App1.Models;
using App1.Services;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ListaViewModel: BaseViewModel
    {
                
        #region Atributos
        private ObservableCollection<ListaItemViewModel> lista;
        private bool isRefreshing;
        private MainViewModel modelo;
        private string filtro;
        private List<Lote> listaC;
        
        #endregion

        #region Propiedades
        public Lote ListaArticulo { get; set; }

        public ObservableCollection<ListaItemViewModel> Lista
        {
            get { return this.lista; }
            set { setValue(ref this.lista, value); }
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
        public ListaViewModel()
        {
            this.apiService = new ApiService();
            this.LoadArticulos();
        }
        public ListaViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }
        #endregion



        #region Metodos
        private IEnumerable<ListaItemViewModel> ToListaViewModel()
        {
            return this.listaC.Select(l => new ListaItemViewModel()
            {
                CodigoProducto = l.CodigoProducto,
                Descripcion = l.Descripcion,
                Imagen = l.Imagen,
                DescripcionLote = l.DescripcionLote,
                Precio = l.Precio
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
            if (modelo.Articulo.Articulo.CodigoProducto == 1)
            {
                this.listaC = apiService.ProductosDulce();
                this.Lista = new ObservableCollection<ListaItemViewModel>(
                    this.ToListaViewModel());
                this.IsRefreshing = false;
            } else if (modelo.Articulo.Articulo.CodigoProducto == 2)
            {
                this.listaC = apiService.ProductosHogar();
                this.Lista = new ObservableCollection<ListaItemViewModel>(
                    this.ToListaViewModel());
                this.IsRefreshing = false;
            }
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
                this.Lista = new ObservableCollection<ListaItemViewModel>(this.ToListaViewModel());
            }
            else
            {
                this.Lista = new ObservableCollection<ListaItemViewModel>(
                    this.ToListaViewModel().Where(p => p.Descripcion.ToLower().Contains(this.Filtro.ToLower())));
            }
        }
        #endregion
    }
}
