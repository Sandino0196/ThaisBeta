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
    public abstract class ListaViewModel : BaseViewModel
    {
        #region Atributos
        private ObservableCollection<ListaItemViewModel> lista;
        private bool isRefreshing;
        private Lote selectedLote;
        private string filtro;
        public List<Lote> listaC;
        #endregion

        #region Propiedades
        public Lote ListaArticulo { get; set; }

        public Lote PreviousSelectedLote { get; set; }

        public Lote SelectedLote
        {
            get { return selectedLote; }
            set
            {
                if(selectedLote != value)
                {
                    selectedLote = value;
                    ExpandibleCollapseSelectedItem();
                }
            }
        }

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
        public ApiService apiService;
        #endregion

        #region Constructores
        public ListaViewModel()
        {
            this.apiService = new ApiService();
            this.LoadListas();
        }
        public ListaViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }
        #endregion

        #region Metodos
        private void ExpandibleCollapseSelectedItem()
        {
            if(PreviousSelectedLote != null)
            {
                Lista.Where(t => t.CodigoProducto == PreviousSelectedLote.CodigoProducto).FirstOrDefault().IsVisible = false;
            }
            Lista.Where(t => t.CodigoProducto == SelectedLote.CodigoProducto).FirstOrDefault().IsVisible = true;
            SelectedLote.Cantidad = 0;
            PreviousSelectedLote = SelectedLote;
        }

        public virtual IEnumerable<ListaItemViewModel> ToListaViewModel()
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

        public virtual void LoadListas()
        {
            
        }
        #endregion

        #region Comandos
        public ICommand AgregarCommand
        {
            get
            {
                return new RelayCommand(Add);
            }
        }

        private async void Add()
        {
            await Application.Current.MainPage.DisplayAlert("Pucta", "Si sirvo :v", "Aceptar");
            if (this.SelectedLote.Cantidad == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Denegado", "Este elemento no ha sido agregado", "Aceptar");
                return;
            }
            apiService.AgregarLote(SelectedLote);
            await Application.Current.MainPage.DisplayAlert("Agregado", "Este elemento ha sido agregado", "Aceptar");
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadListas);
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
