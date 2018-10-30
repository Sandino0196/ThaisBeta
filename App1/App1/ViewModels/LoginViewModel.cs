using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using App1.Services;
using App1.Views;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Servicios
        private ApiService apiService;
        #endregion

        #region Atributos
        private string usuario;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        #region Propiedades
        public string Usuario
        {
            get { return this.usuario = "sandinorodrigo"; }
            set { setValue(ref this.usuario, value); }
        }

        public string Password {
            get { return this.password = "12345"; }
            set { setValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { setValue(ref this.isRunning, value); }
        }

        public bool IsRemembered { get; set; }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { setValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;
            this.apiService = new ApiService();
        }
        #endregion

        #region Comandos
        public ICommand LoginCommand {
            get {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {

            if(string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tienes que ingresar un usuario", "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Tienes que ingresar una contraseña", "Aceptar");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;

            if(this.Usuario != "sandinorodrigo" || this.Password != "12345")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario o contraseña incorrecta", "Aceptar");
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            this.Usuario = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Articulos = new ArticulosViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ArticulosPage());
        }
        #endregion
    }
}
