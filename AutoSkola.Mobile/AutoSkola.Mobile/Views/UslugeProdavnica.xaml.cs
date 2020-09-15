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
    public partial class UslugeProdavnica : ContentPage
    {
        private UslugeProdavnicaViewModel model = null;
        public UslugeProdavnica()
        {
            InitializeComponent();
            BindingContext = model = new UslugeProdavnicaViewModel();
        }
        protected  override void OnAppearing()
        {
            base.OnAppearing();
             model.PrikaziOdabraneUsluge();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var ukupno = int.Parse((sender as Button).CommandParameter.ToString());
          
            await Navigation.PushAsync(new PlacanjeKarticom(ukupno));
        }
    }
}