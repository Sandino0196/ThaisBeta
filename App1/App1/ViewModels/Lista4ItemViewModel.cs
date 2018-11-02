using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class Lista4ItemViewModel : ListaItemViewModel
    {
        #region Comandos
        public override async void Presentar()
        {
            MainViewModel.GetInstance().Listado = new Lista4ViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ListaPage());
        }
        #endregion
    }
}
