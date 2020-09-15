using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoSkola.Mobile.ViewModels
{
    public class RasporedCasovaViewModel:BaseViewModel
    {
        private readonly APIService _termini = new APIService("TerminRasporedaCasova");
        public ObservableCollection<MTerminRasporedaCasova> listaTermina { get; set; } = new ObservableCollection<MTerminRasporedaCasova>();
        public RasporedCasovaViewModel()
        {
            Title = "Raspored časova";
        }
        public async Task PrikaziTermine(TerminRCSearchRequest search)
        {
            //ukoliko je datum 1/1/2000 prikazuje sve termine
            var termini = await _termini.Get<List<MTerminRasporedaCasova>>(search);
            listaTermina.Clear();
            foreach(var i in termini) 
            {
                listaTermina.Add(i);
            }
        }
    }
}
