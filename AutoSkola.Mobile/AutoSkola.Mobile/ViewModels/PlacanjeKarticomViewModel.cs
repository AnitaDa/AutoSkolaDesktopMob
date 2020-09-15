//using Acr.UserDialogs;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace AutoSkola.Mobile.ViewModels
{
    public class PlacanjeKarticomViewModel : BaseViewModel
    {
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _uplate = new APIService("Uplate");
        public PlacanjeKarticomViewModel()
        {
            Title = "Plaćanje karticom";
        }
        int _Ukupno;
        public int Ukupno
        {
            get { return _Ukupno; }
            set { SetProperty(ref _Ukupno, value); }
        }
        public async Task KreirajUplatu()
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
                DatumUplate = DateTime.Now,
                KandidatId = kandidat.Id,
                Iznos = Ukupno,
                Svrha = "Uplata preko aplikacije"
            };
            var uplata = await _uplate.Insert<MUplate>(upsertUplate);
            if (uplata != null)
            {
                try
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Kupovina", "Kupovina uspjesno obavljena!", "OK");

                }
#pragma warning disable CS0168 // The variable 'e' is declared but never used
                catch(Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
                {
                    return;
                }
            }
        }
    }
}
