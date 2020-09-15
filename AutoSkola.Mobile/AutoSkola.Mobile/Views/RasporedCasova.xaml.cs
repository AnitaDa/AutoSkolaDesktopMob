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
    public partial class RasporedCasova : ContentPage
    {
        private RasporedCasovaViewModel model=null;
        private readonly APIService _kandidati = new APIService("Kandidati");
        public RasporedCasova()
        {
            InitializeComponent();
            BindingContext = model = new RasporedCasovaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            try
            {
                //vraca termine za trenutno ulogovanog kandidata
                var searchKandidat = new KandidatSearchRequest()
                {
                    KorisnikId = APIService.trenutniKorisnik.Id
                };
                //pretraga kandidata sa tim korisnickim nalogom
                var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
                if (kandidat == null)
                {
                    throw new Exception("Ne postoje evidentirani termini!");
                }
                  
                var search = new TerminRCSearchRequest()
                {
                    KandidatId = kandidat[0].Id   
                };
                await model.PrikaziTermine(search);
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Obavjestenje!",ex.Message, "OK");
            }
        }

        private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //pronalazak id trenutno logovanog korisnika
            try
            {
                var searchKandidat = new KandidatSearchRequest()
                {
                    KorisnikId = APIService.trenutniKorisnik.Id
                };
                //pretraga kandidata sa tim korisnickim nalogom
                var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
                if (kandidat == null)
                {
                    throw new Exception("Ne postoje evidentirani termini!");
                }
                var search = new TerminRCSearchRequest()
                {
                    KandidatId = kandidat[0].Id,
                    Datum = e.NewDate
                };
                //prikaz termina pronadjenog korisnika
                await model.PrikaziTermine(search);
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Obavjestenje!","Nemate termine", "OK");
            }
        }
    }
}