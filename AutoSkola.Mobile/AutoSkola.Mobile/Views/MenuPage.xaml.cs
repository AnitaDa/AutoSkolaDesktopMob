using AutoSkola.Mobile.Models;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoSkola.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        private APIService _kandidati = new APIService("Kanidati");
        List<HomeMenuItem> menuItems;
        public bool Prihvacen;

        public async Task KandidatPrihvacen()
        {
            var searchKandidat = new KandidatSearchRequest()
            {
                KorisnikId = APIService.trenutniKorisnik.Id
            };
           
             //pretraga kandidata sa tim korisnickim nalogom
            var kandidati = await _kandidati.Get<List<MKandidat>>(searchKandidat);
            var kandidat = kandidati.FirstOrDefault();
            if (kandidat == null && kandidat.Status)
            {
               Prihvacen=true;
            }
            Prihvacen=false;
        }
        public MenuPage()
        {
            InitializeComponent();

            //if (Prihvacen)
            //{
                menuItems = new List<HomeMenuItem>
            {
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.Pocetna, Title="Pocetna" },
                new HomeMenuItem {Id = MenuItemType.RasporedCasova, Title="Raspored časova" },
                new HomeMenuItem {Id = MenuItemType.SalnjeZahtjeva, Title="Posalji zahtjev" },
                new HomeMenuItem {Id = MenuItemType.PodaciOObuci, Title="Podaci o obuci" },
                new HomeMenuItem {Id = MenuItemType.Usluge, Title="Usluge" },
                new HomeMenuItem {Id = MenuItemType.Uplate, Title="Uplate" },
                new HomeMenuItem {Id = MenuItemType.Instruktori, Title="Instruktori" }

            };
            //}
            //else
            //{
            //    menuItems = new List<HomeMenuItem>
            //{
            //    new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
            //    new HomeMenuItem {Id = MenuItemType.SalnjeZahtjeva, Title="Posalji zahtjev" },      
            //    new HomeMenuItem {Id = MenuItemType.Usluge, Title="Usluge" }
            //};
            //}
           

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage=new LoginPage();
        }
    }
}