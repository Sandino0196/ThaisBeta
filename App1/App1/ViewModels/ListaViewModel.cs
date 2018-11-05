using App1.Models;
using App1.Services;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace App1.ViewModels
{
    public abstract class ListaViewModel: BaseViewModel
    {
                
        #region Atributos
        private ObservableCollection<Lote> lista;
        private bool isRefreshing;
        private ArticulosViewModel modelo = new ArticulosViewModel();
        private string filtro;
        public List<Lote> listaC;
        
        #endregion

        #region Propiedades
        public Lote ListaArticulo { get; set; }

        public ObservableCollection<Lote> Lista
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

        public virtual async void LoadListas()
        {
            
        }
        #endregion

        #region Comandos
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
                this.Lista = new ObservableCollection<Lote>(this.ToListaViewModel());
            }
            else
            {
                this.Lista = new ObservableCollection<Lote>(
                    this.ToListaViewModel().Where(p => p.Descripcion.ToLower().Contains(this.Filtro.ToLower())));
            }
        }
        #endregion
    }
}
