using App1.Models;
using App1.Views;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ListaItemViewModel:Lote
    {
        #region Comandos
        public ICommand PresentarArticulo
        {
            get
            {
                return new RelayCommand(Presentar);
            }
        }

        private async void Presentar()
        {
            MainViewModel.GetInstance().Listado = new ListaViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ProductoPage());
        }
        #endregion
    }
}
