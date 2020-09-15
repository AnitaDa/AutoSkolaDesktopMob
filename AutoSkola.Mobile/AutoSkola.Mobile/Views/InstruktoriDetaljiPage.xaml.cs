using AutoSkola.Mobile.ViewModels;
using AutoSkola.Model;
using Microsoft.CodeAnalysis.CSharp;
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
    public partial class InstruktoriDetaljiPage : ContentPage
    {
        private APIService _instruktori = new APIService("Uposlenici");
        private InstruktorDetaljiViewModel model = null;
        private int InstruktorId;
        public InstruktoriDetaljiPage(int instruktorId)
        {
            InitializeComponent();
            InstruktorId = instruktorId;
            BindingContext = model = new InstruktorDetaljiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
             model.Instruktor =await _instruktori.GetById<MUposlenik>(InstruktorId);
            await model.PrikaziPreporuceneInstruktore();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(OcjenaInstruktora.Text, out int ocjena)){
                model.Ocjena = ocjena; 
            }
            await model.PohraniOcjenu();
        }
    }
}