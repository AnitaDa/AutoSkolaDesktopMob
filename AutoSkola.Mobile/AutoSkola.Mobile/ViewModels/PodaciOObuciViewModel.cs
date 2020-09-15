using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Mobile.ViewModels
{
    public class PodaciOObuciViewModel : BaseViewModel
    {
        private readonly APIService _terminiRasporeda = new APIService("TerminRasporedaCasova");
        private readonly APIService _zahtjev = new APIService("Zahtjevi");

         int _BrojOdvozenihCasova;
        public int BrojCasovaPrakticno
        {
            get { return _BrojOdvozenihCasova; }
            set { SetProperty(ref _BrojOdvozenihCasova, value); }
        }
        int _BrojCasovaTeorija;
        public int BrojCasovaTeorija
        {
            get { return _BrojCasovaTeorija; }
            set { SetProperty(ref _BrojCasovaTeorija, value); }
        }
        MZahtjevi _Zahtjev;
        public MZahtjevi Zahtjev
        {
            get { return _Zahtjev; }
            set { SetProperty(ref _Zahtjev, value); }
        }
        public async Task  VratiBrojCasovaPrakticno(TerminRCSearchRequest search)
        {
            var termini = await _terminiRasporeda.Get<List<MTerminRasporedaCasova>>(search);

            BrojCasovaPrakticno = termini.Count();
        }
        public async Task VratiBrojCasovaTeorija(TerminRCSearchRequest search)
        {
            var termini = await _terminiRasporeda.Get<List<MTerminRasporedaCasova>>(search);

            BrojCasovaTeorija = termini.Count();
        }
        
        public async Task VratiInfoUsluga(ZahtjeviSearchRequest zahtjevSearch)
        {
            var zahtjevi = await _zahtjev.Get<List<MZahtjevi>>(zahtjevSearch);
            Zahtjev = zahtjevi.FirstOrDefault();

        }
    }
}
