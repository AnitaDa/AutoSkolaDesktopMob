using AutoSkola.Mobile.ViewModels;
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
    public partial class InstruktoriPage : ContentPage
    {
        private InstruktoriViewModel model=null;
        public InstruktoriPage()
        {
            InitializeComponent();
            BindingContext = model = new InstruktoriViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PrikaziInstruktore();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var UposlenikId = model.odabraniInstruktor.Id;
            await Navigation.PushAsync(new InstruktoriDetaljiPage(UposlenikId));
        }
    }
}