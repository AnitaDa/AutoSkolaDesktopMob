using AutoSkola.Mobile.Views;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    class LoginViewModel:BaseViewModel
    {
        private APIService _korisnik = new APIService("Korisnici");
        string _KorisnickoIme = string.Empty;
        string _Lozinka = string.Empty;
        string _KorisnickoImeGreska = string.Empty;
        string _LozinkaGreska = string.Empty;
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        public string KorisnickoIme
        {
            get { return _KorisnickoIme; }
            set { SetProperty(ref _KorisnickoIme, value); }
        }
        public string Lozinka
        {
            get { return _Lozinka; }
            set { SetProperty(ref _Lozinka, value); }
        }
        public string KorisnickoImeGreska
        {
            get { return _KorisnickoImeGreska; }
            set { SetProperty(ref _KorisnickoImeGreska, value); }
        }
        public string LozinkaGreska
        {
            get { return _LozinkaGreska; }
            set { SetProperty(ref _LozinkaGreska, value); }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            try
            {
                IsBusy = true;
                APIService.Username = KorisnickoIme;
                APIService.Password = Lozinka;
                var request = new AuthenticateRequest()
                {
                    Username = APIService.Username,
                    Password = APIService.Password
                };
                var user = await _korisnik.Authenticate(request);
                if (user == null)
                    throw new Exception("Pogrešno korisničko ime ili lozinka");
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Niste autentificirani", ex.Message, "OK");
            }
        }
       
    }
}
