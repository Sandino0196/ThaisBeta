//Aqui se encuentran todas las ViewModel para utilizarlas en las Page
namespace App1.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }
        public ArticulosViewModel Articulos{ get; set; }
        public ProductoViewModel Articulo { get; set; }
        #endregion

        #region Constructores
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
