using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using App1.Models;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ProductoItemViewModel:Productos
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
            MainViewModel.GetInstance().Articulo = new ProductoViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ProductoPage());
        }
        #endregion
    }
}
