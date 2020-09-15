using AutoSkola.Mobile.Views;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
   public class RegistrujSeViewModel: BaseViewModel
    {
        private readonly APIService _korisnik = new APIService("Korisnici");
        private APIService _korisnikUloga = new APIService("KorisnikUloga");
        private APIService _uloga = new APIService("Uloga");
        private APIService _kandidat = new APIService("Kandidati");



        public ICommand RegistrujSeCommand { get; set; }
        string _Ime;
        string _Prezime;
        string _KorisnickoIme;
        string _Lozinka;
        string _PotvrdnaLozinka;
        DateTime _DatumRodjenja;
        string _Email;
        byte[] _Slika;
        //validacija
        string _GreskaIme;
        string _GreskaPrezime;
        string _GreskaKorisnickoIme;
        string _GreskaLozinka;
        string _GreskaPotvrdnaLozinka;
        string _GreskaEmail;
        public RegistrujSeViewModel()
        {
            RegistrujSeCommand = new Command(async () => await RegistrujSe());
           
        }
        public string Ime
        {
            get { return _Ime; }
            set { SetProperty(ref _Ime, value); }
        }
        public string Prezime
        {
            get { return _Prezime; }
            set { SetProperty(ref _Prezime, value); }
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
        public string PotvrdnaLozinka
        {
            get { return _PotvrdnaLozinka; }
            set { SetProperty(ref _PotvrdnaLozinka, value); }
        }
        public DateTime DatumRodjenja
        {
            get { return _DatumRodjenja; }
            set { SetProperty(ref _DatumRodjenja, value); }
        }
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }
        public byte[] Slika
        {
            get { return _Slika; }
            set { SetProperty(ref _Slika, value); }
        }
        public string GreskaIme
        {
            get { return _GreskaIme; }
            set { SetProperty(ref _GreskaIme, value); }
        }
        public string GreskaPrezime
        {
            get { return _GreskaPrezime; }
            set { SetProperty(ref _GreskaPrezime, value); }
        }
        public string GreskaKorisnickoIme
        {
            get { return _GreskaKorisnickoIme; }
            set { SetProperty(ref _GreskaKorisnickoIme, value); }
        }
        public string GreskaLozinka
        {
            get { return _GreskaLozinka; }
            set { SetProperty(ref _GreskaLozinka, value); }
        }
        public string GreskaPotvrdnaLozinka
        {
            get { return _GreskaPotvrdnaLozinka; }
            set { SetProperty(ref _GreskaPotvrdnaLozinka, value); }
        }

        public string GreskaEmail
        {
            get { return _GreskaEmail; }
            set { SetProperty(ref _GreskaEmail, value); }
        }
        async Task RegistrujSe()
        {
            if (ValidirajPolja())
            {
                var upsertKorisnik = new KorisnikUpsertRequest();
                upsertKorisnik.Email = Email;
                upsertKorisnik.KorisnickoIme = KorisnickoIme;
                upsertKorisnik.Lozinka = Lozinka;
                upsertKorisnik.PotrvrdnaLozinka = PotvrdnaLozinka;
                var noviKorisnik = await _korisnik.Insert<MKorisnik>(upsertKorisnik);
                //korisnik_uloga dodavanje
                var upsertKorisnikUloga = new KorisnikUlogaUpsertRequest();
                upsertKorisnikUloga.KorisnikId = noviKorisnik.Id;
                var uloge = await _uloga.Get<List<MUloga>>(null);
                upsertKorisnikUloga.UlogaId = uloge.FirstOrDefault(x => x.Naziv == "Kandidat").Id;
                await _korisnikUloga.Insert<MKorisnikUloga>(upsertKorisnikUloga);
                //dodati kandidata
                var noviKandidat = new KandidatUpsertRequest
                {
                    Ime = Ime,
                    Prezime = Prezime,
                    DatumRodjenja = DatumRodjenja,
                    Status = false,
                    KorisnikId = noviKorisnik.Id,
                    Slika=Slika
                };
                var kandidat = await _kandidat.Insert<MKandidat>(noviKandidat);
                if (kandidat != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Registracija", "Registracija uspjesna!", "OK");
                    Application.Current.MainPage = new LoginPage();
                }
            }
        }
        public bool ValidirajPolja()
        {
            bool ImeOK = false;
            GreskaIme = "Obavezno polje";
            if (Ime!= null)
            {
                GreskaIme = null;
                ImeOK = true;
            }
            bool PrezimeOK = false;
            GreskaPrezime = "Obavezno polje";
            if (Prezime!= null)
            {
                GreskaPrezime = null;
                 PrezimeOK = true;
            }

            bool KImeOK = false;
            GreskaKorisnickoIme = "Obavezno polje";
            if (KorisnickoIme != null)
            {
                GreskaKorisnickoIme = null;
                KImeOK = true;
            }
            bool LozinkaOK = false;
            GreskaLozinka = "Obavezno polje";
            if (Lozinka != null)
            {
                GreskaLozinka = null;
                LozinkaOK = true;
            }
            bool PotvrdnaLozinkaOK = false;
            GreskaPotvrdnaLozinka = "Obavezno polje";
            if (PotvrdnaLozinka != null)
            {
                GreskaPotvrdnaLozinka = null;
                PotvrdnaLozinkaOK = true;
            }
            string RegEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            bool EmailOK = false;
            GreskaEmail = "Format emaila nije ispravan!";
            if (Email!=null)
            {
                if (Regex.IsMatch(Email, RegEmail))
                {
                    GreskaEmail = null;
                    EmailOK = true;
                }
            }
            if(ImeOK && PrezimeOK && LozinkaOK && PotvrdnaLozinkaOK && KImeOK && EmailOK)
            return true;
            return false;
        }
    }
}
