using AutoSkola.Mobile.ViewModels;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class Usluge : ContentPage
    {
        private readonly APIService _kandidati = new APIService("Kandidati");
        private readonly APIService _usluge = new APIService("Usluge");

        private UslugeViewModel model = null;
        
       
        public  Usluge()
        {
            InitializeComponent();
            BindingContext = model = new UslugeViewModel();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await model.PrikaziKategorije();
            await model.PrikaziUsluge(null);
        }
       
        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var search = new UslugaSearchRequest()
            {
                KategorijaId = model.selectedKategorija.Id

            };
            await model.PrikaziUsluge(search);
        }


        private async void Button_OnClicked(object sender, EventArgs e)
        {
            int uslugaId = int.Parse((sender as Button).CommandParameter.ToString());
            var searchKandidat = new KandidatSearchRequest()
            {
                KorisnikId = APIService.trenutniKorisnik.Id
            };
            //pretraga kandidata sa tim korisnickim nalogom
            var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
            var kandidatId = kandidat.FirstOrDefault().Id;
            //filter da li kandidat ima odobren zahtjev za uslugu koju zeli kupiti
            var searchZahtev = new ZahtjeviSearchRequest()
            {
                UslugaId = uslugaId,
                KandidatiId = kandidatId,
                Odobren = true,
                KupovinaUsluga = true,
                PrikazUXamarinu = true
            };
            var odabranaUsluga = await _usluge.GetById<MUsluge>(uslugaId);
            model.Usluga = odabranaUsluga;
            await model.DodajUsluguUKorpu(searchZahtev);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UslugeProdavnica());
        }
        //povecavanje broja usluge
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            model.BrojacUsluge += 1;         
        }

    }
}