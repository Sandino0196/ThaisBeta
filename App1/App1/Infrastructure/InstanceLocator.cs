//Instancia las ViewModel dentro del Main (ventana principal)
using App1.ViewModels;

namespace App1.Infrastructure
{
    public class InstanceLocator
    {
        #region Propiedades
        public MainViewModel Main { get; set; }
        #endregion

        #region Constuctores
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
