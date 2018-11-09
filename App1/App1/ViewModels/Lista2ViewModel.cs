using App1.Models;
using App1.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Lista2ViewModel : ListaViewModel
    {
        public Lista2ViewModel()
        {
            this.apiService = new ApiService();
            this.LoadListas();
        }

        public Lista2ViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }

        public override void LoadListas()
        {
            this.IsRefreshing = true;
            this.listaC = apiService.ProductosDulce();
            this.Lista = new ObservableCollection<ListaItemViewModel>(ToListaViewModel());
            this.IsRefreshing = false;
        }
    }
}