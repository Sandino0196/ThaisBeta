﻿using App1.Models;
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

            this.listaC = (List<Lote>)apiService.ProductosHogar();
            this.Lista = new ObservableCollection<Lote>(listaC);
            this.IsRefreshing = false;
        }
    }
}