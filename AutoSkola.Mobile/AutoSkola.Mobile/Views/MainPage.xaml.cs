using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AutoSkola.Mobile.Models;

namespace AutoSkola.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    //case (int)MenuItemType.Browse:
                    //    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    //    break;
                    case (int)MenuItemType.Pocetna:
                        MenuPages.Add(id, new NavigationPage(new PocetnaPage()));
                        break;
                    case (int)MenuItemType.RasporedCasova:
                        MenuPages.Add(id, new NavigationPage(new RasporedCasova()));
                        break;
                    case (int)MenuItemType.SalnjeZahtjeva:
                        MenuPages.Add(id, new NavigationPage(new SlanjeZahtjeva()));
                        break;
                    case (int)MenuItemType.PodaciOObuci:
                        MenuPages.Add(id, new NavigationPage(new InformacijeOKoriscenjuUsluge()));
                        break;
                    case (int)MenuItemType.Usluge:
                        MenuPages.Add(id, new NavigationPage(new Usluge()));
                        break;
                    case (int)MenuItemType.Uplate:
                        MenuPages.Add(id, new NavigationPage(new UplatePage()));
                        break;
                    case (int)MenuItemType.Instruktori:
                        MenuPages.Add(id, new NavigationPage(new InstruktoriPage()));                    
                        break;
                   
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}