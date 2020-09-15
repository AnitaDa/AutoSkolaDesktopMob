using AutoSkola.Mobile.ViewModels;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoSkola.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformacijeOKoriscenjuUsluge : ContentPage
    {
        private PodaciOObuciViewModel model=null;
        private APIService _kandidati = new APIService("Kandidati");

        public InformacijeOKoriscenjuUsluge()
        {
            InitializeComponent();
            BindingContext = model = new PodaciOObuciViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
              var searchKandidat = new KandidatSearchRequest()
                {
                    KorisnikId = APIService.trenutniKorisnik.Id
                };
            //pretraga kandidata sa tim korisnickim nalogom
            var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
            if (kandidat.Count() != 0)
            {
                var searchPrakticno = new TerminRCSearchRequest()
                {
                    KandidatId = kandidat[0].Id,
                    Prakticno = true,
                    PrikazUXamarinu = true
                };
                var searchTeorija = new TerminRCSearchRequest()
                {
                    KandidatId = kandidat[0].Id,
                    Teorija = true,
                    PrikazUXamarinu = true
                };
                var searchZ = new ZahtjeviSearchRequest()
                {
                    KandidatiId = kandidat[0].Id,
                    PrikazUXamarinu = true
                };
                await model.VratiBrojCasovaPrakticno(searchPrakticno);
                await model.VratiBrojCasovaTeorija(searchTeorija);
                await model.VratiInfoUsluga(searchZ);
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Nema usluga!", "Nemate aktivnih usluga", "OK");
            }
        }
    }
}