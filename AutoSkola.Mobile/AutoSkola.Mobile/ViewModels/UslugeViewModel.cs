using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class UslugeViewModel:BaseViewModel
    {
        MKategorije _kategorija = null;
        public int _UslugaId;
        public int _brojacUsluge=1;
       public  MUsluge _usluga = null;
        int _Ukupno = 0;
        private APIService _usluge = new APIService("Usluge"); 
        private APIService _kategorije = new APIService("Kategorije");
        private APIService _zahtjevi = new APIService("Zahtjevi");
        public ObservableCollection<MUsluge> listaUsluga { get; set; } = new ObservableCollection<MUsluge>();
        public ObservableCollection<MKategorije> listaKategorija { get; set; } = new ObservableCollection<MKategorije>();
        public UslugeViewModel()
        {
            Title = "Usluge";
        }
        public int Id
        {
            get { return _UslugaId; }
            set { SetProperty(ref _UslugaId, value); }
        }
        public MUsluge Usluga
        {
            get { return _usluga; }
            set { SetProperty(ref _usluga, value); }
        }
        public  int BrojacUsluge
        {
            get { return _brojacUsluge; }
            set { SetProperty(ref _brojacUsluge, value); }
        }

        public int UkupanIznos
        {
            get { return _Ukupno; }
            set { SetProperty(ref _Ukupno, value); }
        }
        public MKategorije selectedKategorija
        {
            get { return _kategorija; }
            set { SetProperty(ref _kategorija, value); }
        }
        public async Task PrikaziKategorije()
        {
            
            var kategorije = await _kategorije.Get<List<MKategorije>>(null);
            kategorije.Insert(0, new MKategorije { Naziv = "--Sve kategorije--" });
            listaKategorija.Clear();
            foreach (var i in kategorije)
            {
                listaKategorija.Add(i);
            }
        }
        public async Task PrikaziUsluge(UslugaSearchRequest search)
        {
            
            var usluge = await _usluge.Get<List<MUsluge>>(search);
            listaUsluga.Clear();
            foreach(var i in usluge)
            {
                listaUsluga.Add(i);
            }
        }


        //klikom na dugme kupi, prosledjujem UslugaId
        //proveravam da li trenutni kandidat ima odobren zahtjev za uslugu sa prosledjenim ID
        //zahtjev->ljekarsko->kandidatId==trenutniKandidat && zahtjev->odobren==true && zahtjev->uslugaId==prosledjena uslugaId
        public async Task DodajUsluguUKorpu(ZahtjeviSearchRequest search)
        { 
                //ako je kadndidatu odobren zahtjev, uslugu treba dodati u korpu
                var zahtjevi = await _zahtjevi.Get<List<MZahtjevi>>(search);
                if (zahtjevi.Count()== 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Obavjestenje","Odabranu uslugu nije moguce kupiti, prethodno posaljite zahtjev za istu!","OK");
                }
                else {
                if (KorpaService.Korpa.ContainsKey(Usluga.Id))
                {
                    KorpaService.Korpa.Remove(Usluga.Id);
                }
                KorpaService.Korpa.Add(Usluga.Id,this);
                UkupanIznos += Usluga.Cijena*BrojacUsluge;
                await Application.Current.MainPage.DisplayAlert("Obavjestenje", "Usluga dodana u korpu!", "OK");
            }
        }
    }
}
