using App1.Models;
using App1.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Lista4ViewModel : ListaViewModel
    {
        public Lista4ViewModel()
        {
            this.apiService = new ApiService();
            this.LoadListas();
        }
        public Lista4ViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }

        public override void LoadListas()
        {
            this.IsRefreshing = true;
            this.listaC = apiService.ProductosHogar();
            this.Lista = new ObservableCollection<ListaItemViewModel>(ToListaViewModel());
            this.IsRefreshing = false;
        }
    }
}