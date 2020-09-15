using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class SlanjeZahtjevaViewModel:BaseViewModel
    {
        //int _uslugaId;
        //int _uposlenikId;
        int _BrojLjekarskogUvjerenja;
        private readonly APIService _zahtjevi=new APIService("Zahtjevi");
        private readonly APIService _ljekarksko = new APIService("LjekarskoUvjerenje");
        private readonly APIService _uposlenici = new APIService("Uposlenici");
        private readonly APIService _usluge = new APIService("Usluge");
        string _greskaUsluga;
        string _greskaUposlenik;

        public SlanjeZahtjevaViewModel()
        {
            PosaljiZahtjev = new Command(async () => await SlanjeZahtjeva());
        }
        public ObservableCollection<MUposlenik> listaUposlnika { get; set; } = new ObservableCollection<MUposlenik>();
        public ObservableCollection<MUsluge> listaUsluga { get; set; } = new ObservableCollection<MUsluge>();
        public string GreskaUsluga
        {
            get { return _greskaUsluga; }
            set { SetProperty(ref _greskaUsluga, value); }
        }
        public string GreskaUposlenik
        {
            get { return _greskaUposlenik; }
            set { SetProperty(ref _greskaUposlenik, value); }
        }
        MUposlenik _selectedUposlenik=null;
            public MUposlenik selectedUposlenik
            { 
            get { return _selectedUposlenik; }
              set { SetProperty(ref _selectedUposlenik, value); }
            }
        MUsluge _selectedUsluga = null;
        public MUsluge selectedUsluga
        {
            get { return _selectedUsluga; }
            set { SetProperty(ref _selectedUsluga, value); }
        }
        int _KandidatId;
        public int KandidatId
        {
            get { return _KandidatId; }
            set { SetProperty(ref _KandidatId, value); }
        }
        
        public int BrojLjekarskog
        {
            get { return _BrojLjekarskogUvjerenja; }
            set { SetProperty(ref _BrojLjekarskogUvjerenja, value); }
        }
        public ICommand PosaljiZahtjev { get; set; }
        public async Task PrikaziUsluge()
        {
            var usluge = await _usluge.Get<List<MUsluge>>(null);
            listaUsluga.Clear();
            foreach(var usl in usluge)
            {
                listaUsluga.Add(usl);
            }
        }
        public async Task PrikaziUposlenike()
        {
            var search = new UposleniciSearchRequest() {
            TipUposlenika="instruktor"
            };
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(search);
            listaUposlnika.Clear();
            foreach(var u in uposlenici) {
                listaUposlnika.Add(u);
            }
        }
        public async Task SlanjeZahtjeva()
        {
            if (ValidirajPolja())
            {
                try
                {
                    var ljekarsko = await _ljekarksko.GetById<MLjekarskoUvjerenje>(BrojLjekarskog);
                    if (ljekarsko == null || ljekarsko.SposobanZaObuku == false)
                    {
                        throw new Exception("Ljekarsko uvjerenje ne postoji u bazi ili ne ispunjava uslove za odabranu uslugu");

                    }
                    if (ljekarsko.KandidatId != KandidatId)
                    {
                        throw new Exception("Ljekarsko uvjerenje ne pripada logovanom kandidatu, molimo unesite validan broj ljekarskog!");
                    }

                    var upsert = new ZahtjeviUpsertRequest()
                    {
                        LjekarskoUvjerenjeId = BrojLjekarskog,
                        UposlenikId = selectedUposlenik.Id,
                        UslugaId = selectedUsluga.Id,
                        DatumPodnosenjaZahtjeva = DateTime.Now,
                        Odbacen = false,
                        Odobren = false
                    };
                    var zahtjev = await _zahtjevi.Insert<MZahtjevi>(upsert);
                    if (zahtjev == null)
                    {
                        throw new Exception("Zahtjev nije poslan!");
                    }
                    else
                    {
                        throw new Exception("Zahtjev uspjesno poslan!");
                    }
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavještenje", ex.Message, "OK");
                }
            }

        }
        public bool ValidirajPolja()
        {
            bool greskaUsluga = false;
            bool greskaUposlenik = false;
            GreskaUposlenik = null;
            GreskaUsluga = null;
            if (selectedUposlenik == null)
            {
                greskaUposlenik = true;
                GreskaUposlenik = "Obavezno polje!";
            }
            if (selectedUsluga == null)
            {
                greskaUsluga = true;
                GreskaUsluga = "Obavezno polje!";
            }
            if(greskaUsluga==false && greskaUposlenik == false)
            {
                return true;
            }
            return false;
        }
    }
}
