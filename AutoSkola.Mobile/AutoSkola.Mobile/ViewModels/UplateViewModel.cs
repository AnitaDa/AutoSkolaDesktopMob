using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Mobile.ViewModels
{
    public class UplateViewModel : BaseViewModel
    {
        private readonly APIService _uplate = new APIService("Uplate");

        public ObservableCollection<MUplate> listaUplata { get; set; } = new ObservableCollection<MUplate>();
        public async Task PrikaziUplate(int KandidatId)
        {
            var search = new UplataSearchRequest()
            {
                KandidatId=KandidatId
            };
            var uplate = await _uplate.Get<List<MUplate>>(search);
            listaUplata.Clear();
            foreach(var i in uplate)
            {
                listaUplata.Add(i);
            }
        }
    }
}
