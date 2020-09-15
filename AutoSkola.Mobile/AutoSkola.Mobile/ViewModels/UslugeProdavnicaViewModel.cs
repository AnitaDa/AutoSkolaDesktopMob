using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class UslugeProdavnicaViewModel:BaseViewModel
    {
        //narudzba
        private APIService _uslugeProdavnica = new APIService("UslugeProdavnica");
        private APIService _kandidati = new APIService("Kandidati");
       
        //stavke narudzbe
        private APIService _odabraneUsluge = new APIService("OdabraneUsluge");
        public UslugeProdavnicaViewModel()
        {
            KreirajNaruzbuCommand = new Command(async () => await KreirajNarudzbu());
        }
        public ObservableCollection<UslugeViewModel> listaOdabranihUsluga { get; set; } = new ObservableCollection<UslugeViewModel>();
        int _Ukupno;
        int _BrojUsluga;
        public ICommand KreirajNaruzbuCommand { get; set; }
        public int Ukupno
        {
            get { return _Ukupno; }
            set { SetProperty(ref _Ukupno, value); }
        }
        public int BrojUsluga
        {
            get { return _BrojUsluga; }
            set { SetProperty(ref _BrojUsluga, value); }
        }
        public void PrikaziOdabraneUsluge()
        {
            listaOdabranihUsluga.Clear();
            foreach(var i in KorpaService.Korpa.Values)
            {
                listaOdabranihUsluga.Add(i);
                Ukupno = i.UkupanIznos;
            }
        }
         async Task KreirajNarudzbu()
        {
            var searchKandidat = new KandidatSearchRequest()
            {
                KorisnikId = APIService.trenutniKorisnik.Id
            };
            //pretraga kandidata sa tim korisnickim nalogom
            var kandidati = await _kandidati.Get<List<MKandidat>>(searchKandidat);
            var kandidat = kandidati.FirstOrDefault();
            var upsertUplate = new UplataUpsertRequest()
            {
                DatumUplate=DateTime.Now,
                KandidatId=kandidat.Id,
                Iznos=Ukupno,
                Svrha="Uplata preko aplikacije"
             };
            foreach (var i in KorpaService.Korpa.Values)
            {
                upsertUplate.Svrha = i.Usluga.NazivKategorija;
            }

            var upsertUslugeProdavnica = new UslugeProdavnicaUpsertRequest()
            {
                KandidatId = kandidat.Id,
                Datum = DateTime.Now
            };
            var uslugaProdavnica = await _uslugeProdavnica.Insert<MUslugeProdavnica>(upsertUslugeProdavnica);
            foreach (var i in KorpaService.Korpa.Values)
            {
                var upsertOdabranaUsluga = new OdabraneUslugeUspertRequest()
                {
                    UslugeProdavnicaId = uslugaProdavnica.Id,
                    UslugaId = i.Usluga.Id
                };
                await _odabraneUsluge.Insert<MOdabraneUsluge>(upsertOdabranaUsluga);
            }
            await Application.Current.MainPage.DisplayAlert("Kupovina", "Kupovina uspjesno obavljena!", "OK");
        }
    }
}
