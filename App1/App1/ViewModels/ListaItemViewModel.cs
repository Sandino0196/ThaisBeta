using App1.Models;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace App1.ViewModels
{
    public class ListaItemViewModel:Lote
    {
        #region Comandos
        public ICommand PresentarLista
        {
            get
            {
                return new RelayCommand(Presentar);
            }
        }

        public virtual async void Presentar()
        {

        }
        #endregion
    }
}
