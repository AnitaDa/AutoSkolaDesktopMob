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
    public partial class SlanjeZahtjeva : ContentPage
    {
        private SlanjeZahtjevaViewModel model =null;
        private readonly APIService _kandidati = new APIService("Kandidati");
        
        public  SlanjeZahtjeva()
        {
            InitializeComponent();
            BindingContext = model = new SlanjeZahtjevaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PrikaziUposlenike();
            await model.PrikaziUsluge();
            var searchKandidat = new KandidatSearchRequest()
            {
                KorisnikId = APIService.trenutniKorisnik.Id,
                PrikazUXamarinu=true
            };
            //pretraga kandidata sa tim korisnickim nalogom
            var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
            model.KandidatId = kandidat.FirstOrDefault().Id;
        }
    }
}