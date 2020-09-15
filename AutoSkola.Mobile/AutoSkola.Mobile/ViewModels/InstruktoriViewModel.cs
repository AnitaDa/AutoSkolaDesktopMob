using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class InstruktoriViewModel:BaseViewModel
    {
        private APIService _instruktori = new APIService("Uposlenici");
        public ObservableCollection<MUposlenik> listaInstruktora { get; set; } = new ObservableCollection<MUposlenik>();
         public MUposlenik _instruktor;
        public MUposlenik odabraniInstruktor
        {
            get { return _instruktor; }
            set { SetProperty(ref _instruktor, value); }
        }
        public async Task PrikaziInstruktore()
        {
                listaInstruktora.Clear();
            var instruktori =await _instruktori.Get<List<MUposlenik>>(new UposleniciSearchRequest {TipUposlenika="Instruktor"});
            foreach(var i in instruktori)
            {
                listaInstruktora.Add(i);
            }
        }
    }
}
