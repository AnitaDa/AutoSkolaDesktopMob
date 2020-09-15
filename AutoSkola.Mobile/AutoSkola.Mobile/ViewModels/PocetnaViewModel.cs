using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Mobile.ViewModels
{
    public class PocetnaViewModel:BaseViewModel
    {
        private readonly APIService _instrukotir = new APIService("Uposlenici");
        private readonly APIService _usluge = new APIService("Usluge");

        public ObservableCollection<MUsluge> listaUsluga { get; set; } = new ObservableCollection<MUsluge>();
        public ObservableCollection<MUposlenik> listaInstruktora { get; set; } = new ObservableCollection<MUposlenik>();

        public async Task PrikaziUsluge()
        {
            var usluge = await _usluge.Get<List<MUsluge>>(null);
            listaUsluga.Clear();
            foreach(var i in usluge)
            {
                listaUsluga.Add(i);
            }
        }
        public async Task PrikaziInstruktore()
        {
            var instruktori = await _instrukotir.Get<List<MUposlenik>>(new UposleniciSearchRequest {TipUposlenika="Instruktor"});
            listaUsluga.Clear();
            foreach (var i in instruktori)
            {
                listaInstruktora.Add(i);
            }
        }
    }
}
