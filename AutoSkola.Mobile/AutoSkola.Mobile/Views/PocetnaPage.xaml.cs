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
    public partial class PocetnaPage : ContentPage
    {
        private PocetnaViewModel model = null;
        public PocetnaPage()
        {
            InitializeComponent();
            BindingContext = model = new PocetnaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PrikaziInstruktore();
            await model.PrikaziUsluge();
        }
    }
}