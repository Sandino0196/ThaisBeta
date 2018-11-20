using App1.Models;
using App1.Services;
using System.Collections.ObjectModel;

namespace App1.ViewModels
{
    public class Lista5ViewModel : ListaViewModel
    {
        public Lista5ViewModel()
        {
            this.apiService = new ApiService();
            this.LoadListas();
        }

        public Lista5ViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }

        public override void LoadListas()
        {
            this.IsRefreshing = true;
            this.listaC = apiService.Abarroteria();
            this.Lista = new ObservableCollection<ListaItemViewModel>(ToListaViewModel());
            this.IsRefreshing = false;
        }
    }
}