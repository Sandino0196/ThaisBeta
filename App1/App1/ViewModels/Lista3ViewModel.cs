using App1.Models;
using App1.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Lista3ViewModel : ListaViewModel
    {

        public Lista3ViewModel()
        {
            this.apiService = new ApiService();
            this.LoadListas();
        }

        public Lista3ViewModel(Lote articulo)
        {
            this.ListaArticulo = articulo;
        }

        public override void LoadListas()
        {
            this.IsRefreshing = true;
            this.listaC = apiService.ProductosBano();
            this.Lista = new ObservableCollection<ListaItemViewModel>(ToListaViewModel());
            this.IsRefreshing = false;
        }
    }
}