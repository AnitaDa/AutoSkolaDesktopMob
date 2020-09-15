using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class InstruktorDetaljiViewModel : BaseViewModel
    {
        MUposlenik _instruktor;
        decimal _ocjena;
        private APIService _preporuceni = new APIService("Recommender");
        private APIService _utisci = new APIService("Utisci");
        private APIService _kandidati = new APIService("Kandidati");

        string _greskaOcjena;
        public ObservableCollection<MUposlenik> listaPreporucenihInstruktora { get; set; } = new ObservableCollection<MUposlenik>();
        public MUposlenik Instruktor {
            get { return _instruktor; }
            set { SetProperty(ref _instruktor, value); }
        }
        public string GreskaOcjena
        {
            get { return _greskaOcjena; }
            set { SetProperty(ref _greskaOcjena,value); }
        }
        public decimal Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        public async Task PohraniOcjenu()
        {
            bool validnaOcjena = true;
            GreskaOcjena = null;
            //validacija unosa ocjene
            if(Ocjena<1 || Ocjena > 5)
            {
                GreskaOcjena = "Ocjena nije validna! Unesite ocjenu izmedju 1 i 5!";
                validnaOcjena = false;
            }
            if (validnaOcjena)
            {
                var searchKandidat = new KandidatSearchRequest()
                {
                    KorisnikId = APIService.trenutniKorisnik.Id
                };
                //pretraga kandidata sa tim korisnickim nalogom
                var kandidat = await _kandidati.Get<List<MKandidat>>(searchKandidat);
                if (kandidat.Count > 0)
                {
                    var kandidatId = kandidat[0].Id;
                    var upsert = new UtisakUpsertRequest()
                    {
                        UposlenikId = Instruktor.Id,
                        KandidatId = kandidatId,
                        Ocjena = Ocjena
                    };
                    var utisak = await _utisci.Insert<MUtisak>(upsert);
                    if (utisak != null)
                        await Application.Current.MainPage.DisplayAlert("Ocjenjivanje", "Uspjesno pohranjena " + Ocjena + " ocjena!", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Obavjestenje!", "Ne možete ocjeniti, dok ne postanete aktivni kandidat", "OK");
                }
            }
        }
        public async Task PrikaziPreporuceneInstruktore()
        {
            var preporuceni = await _preporuceni.Get<List<MUposlenik>>(new RecommenderSearchRequest{InstruktorId=Instruktor.Id});
           
            foreach (var i in preporuceni)
            {
                listaPreporucenihInstruktora.Add(i);
            }
        }
    }
}
