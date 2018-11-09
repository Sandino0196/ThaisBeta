using App1.Models;
using App1.Views;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ListaItemViewModel:Lote , INotifyPropertyChanged
    {
        #region Comandos
        public ICommand SelectProductoCommand
        {
            get
            {
                return new RelayCommand(Presentar);
            }
        }

        public bool IsVisible
        {
            get { return this.isVisible; }
            set
            {
                if (isVisible != value)
                {
                    isVisible = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void Presentar()
        {
            MainViewModel.GetInstance().Producto = new ProductoViewModel(this);
            await Application.Current.MainPage.Navigation.PushAsync(new ProductoPage());
        }
        #endregion
    }
}
