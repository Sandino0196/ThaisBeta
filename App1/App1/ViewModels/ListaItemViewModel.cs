using App1.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.ViewModels
{
    public class ListaItemViewModel:Lote , INotifyPropertyChanged
    {
        #region Comandos
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
        #endregion
    }
}
