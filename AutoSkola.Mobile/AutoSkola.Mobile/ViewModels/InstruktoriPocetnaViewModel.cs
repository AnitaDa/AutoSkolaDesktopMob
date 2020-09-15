using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Mobile.ViewModels
{
    public class InstruktoriPocetnaViewModel:BaseViewModel
    {
        private readonly APIService _uposlenici = new APIService("Uposlenici");
        public ObservableCollection<MUposlenik> listaNajboljihInstruktora { get; set; } = new ObservableCollection<MUposlenik>();
        async Task PrikaziTop5Instruktora()
        {
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(new UposleniciSearchRequest {Top5 = true });
            foreach(var i in uposlenici)
            {
                listaNajboljihInstruktora.Add(i);
            }
        }
    }
}
