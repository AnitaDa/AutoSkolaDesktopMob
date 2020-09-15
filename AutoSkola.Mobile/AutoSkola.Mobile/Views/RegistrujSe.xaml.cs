using AutoSkola.Mobile.ViewModels;
using Plugin.FilePicker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoSkola.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrujSe : ContentPage
    {
        private RegistrujSeViewModel model=null;
        
        public RegistrujSe()
        {
            InitializeComponent();
            BindingContext = model = new RegistrujSeViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();
            if (file != null)
            {
                txtFileName.Text = file.FileName;
                model.Slika = file.DataArray;
            }
        }
    }
}