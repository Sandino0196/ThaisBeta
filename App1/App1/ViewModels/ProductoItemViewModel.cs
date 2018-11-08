using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using App1.Models;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ProductoItemViewModel:Lote
    {
        #region Comandos
        public ICommand SelectProductoCommand
        {
            get
            {
                return new RelayCommand(SelectProducto);
            }
        }

        private async void SelectProducto()
        {
            MainViewModel.GetInstance().Producto = new ProductoViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ProductoPage());
        }
        #endregion
    }
}
