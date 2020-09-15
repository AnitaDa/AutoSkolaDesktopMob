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
    public partial class UplatePage : ContentPage
    {
        private APIService _kandidati = new APIService("Kandidati");
        private UplateViewModel model = null;
        public UplatePage()
        {
            InitializeComponent();
            BindingContext = model = new UplateViewModel();
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
            await model.PrikaziUplate(kandidat.FirstOrDefault().Id);
        }
    }
}