using App1.Services;
using App1.Views;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ArticulosViewModel:BaseViewModel
    {
        #region Atributos
        private bool isRefreshing;
        private string filtro;
        #endregion

        #region Propiedades
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
        }
        #endregion

        #region Comandos
        public ICommand DulceCommand
        {
            get
            {
                return new RelayCommand(LoadDulces);
            }
        }

        private async void LoadDulces()
        {
            MainViewModel.GetInstance().Listado = new Lista2ViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ListaPage());
        }

        public ICommand HigieneCommand
        {
            get
            {
                return new RelayCommand(LoadHigiene);
            }
        }

        private async void LoadHigiene()
        {
            MainViewModel.GetInstance().Listado = new Lista3ViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ListaPage());
        }

        public ICommand HogarCommand
        {
            get
            {
                return new RelayCommand(LoadHogar);
            }
        }

        private async void LoadHogar()
        {
            MainViewModel.GetInstance().Listado = new Lista4ViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ListaPage());
        }

        public ICommand AbarroteriaCommand
        {
            get
            {
                return new RelayCommand(LoadAba);
            }
        }

        private async void LoadAba()
        {
            MainViewModel.GetInstance().Listado = new Lista5ViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ListaPage());
        }
        #endregion
    }
}
