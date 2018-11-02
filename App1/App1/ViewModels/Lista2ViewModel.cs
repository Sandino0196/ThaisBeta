using App1.Models;
using App1.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

        public override async void LoadListas()
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

            this.listaC = (List<Lote>)apiService.ProductosDulce();
            this.Lista = new ObservableCollection<Lote>(listaC);
            this.IsRefreshing = false;
        }
    }
}