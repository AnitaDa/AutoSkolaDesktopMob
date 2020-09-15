

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Drawing;

using System.Data;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
using AutoSkola.Model.Requests;
using AutoSkola.Model;
using AutoSkola.WinUI.Zahtjevi;
using AutoSkola.WinUI.Potvrde.Izvjestaj.DataSetPotvrdeTableAdapters;

namespace AutoSkola.WinUI.UserControls

{

    public partial class RowZahtjevi : UserControl

    {
        private APIService _zahtjevUrl = new APIService("Zahtjevi");
        private APIService _ljekarsko = new APIService("LjekarskoUvjerenje");
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _rasporedCasova = new APIService("RasporedCasova");



#pragma warning disable CS0108 // 'RowZahtjevi.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmZahtjevi Parent;
#pragma warning restore CS0108 // 'RowZahtjevi.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public RowZahtjevi()

        {

            InitializeComponent();

        }
        private int _ZahtjevId;

        private string _Kandidat;

        private string _Usluga;

        private string _Kategorija;

        private string _Instruktor;

        

        [Category("Custom props")]

        public string Kandidat

        {

            get { return _Kandidat; }

            set { _Kandidat = value; lblKandidat.Text = value; }



        }

        [Category("Custom props")]

        public string Usluga

        {

            get { return _Usluga; }

            set { _Usluga = value; lblUsluga.Text = value; }



        }

        [Category("Custom props")]

        public string Kategorija

        {

            get { return _Kategorija; }

            set { _Kategorija = value; lblKategorija.Text = value; }



        }

        [Category("Custom props")]

        public string Instruktor

        {

            get { return _Instruktor; }

            set { _Instruktor = value; lblInstruktor.Text = value; }



        }
        public int ZahtjevId

        {

            get { return _ZahtjevId; }

            set { _ZahtjevId = value;  }



        }

        private async void btnOdobri_Click(object sender, EventArgs e)
        {
            var zahtjev = await _zahtjevUrl.GetById<MZahtjevi>(ZahtjevId);
            //menjam atriput odobren na true
            var upsert = new ZahtjeviUpsertRequest()
            {
                Id = zahtjev.Id,
                Odbacen = false,
                Odobren = true,
                DatumPodnosenjaZahtjeva = zahtjev.DatumPodnosenja,
                LjekarskoUvjerenjeId = zahtjev.LjekarskoUvjerenjeId,
                UposlenikId = zahtjev.UposlenikId,
                UslugaId = zahtjev.UslugaId
            };
            await _zahtjevUrl.Update<MZahtjevi>(ZahtjevId, upsert);

            var ljekarsko = await _ljekarsko.GetById<MLjekarskoUvjerenje>(zahtjev.LjekarskoUvjerenjeId);
            var kandidat = await _kandidati.GetById<MKandidat>(ljekarsko.KandidatId);
            //menjam status kandidatu na true nakon prihvatanja
            var upsertKandidat = new KandidatUpsertRequest() {
               Id=kandidat.Id,
               Ime=kandidat.Ime,
               Prezime=kandidat.Prezime,
               DatumRodjenja=kandidat.DatumRodjenja,
              Slika=kandidat.Slika,
              Status=true,
              KorisnikId=kandidat.KorisnikId
            };
            await _kandidati.Update<MKandidat>(kandidat.Id, upsertKandidat);
            //po odobrenom zahtjevu kreirati kandidatu raspored
            var noviRaspored = new RasporedCasovaUpsertRequest()
            {
                KandidatId=kandidat.Id
            };
            await _rasporedCasova.Insert<MRasporedCasova>(noviRaspored);
            Parent.Reload();
        }

        private async void btnOdbaci_Click(object sender, EventArgs e)
        {
            var zahtjev = await _zahtjevUrl.GetById<MZahtjevi>(ZahtjevId);
            var upsert = new ZahtjeviUpsertRequest()
            {    
                Id=zahtjev.Id,
                Odbacen = true,
                Odobren=false,
                DatumPodnosenjaZahtjeva=zahtjev.DatumPodnosenja,
                LjekarskoUvjerenjeId=zahtjev.LjekarskoUvjerenjeId,
                UposlenikId=zahtjev.UposlenikId,
                UslugaId=zahtjev.UslugaId
            };
            await _zahtjevUrl.Update<MZahtjevi>(ZahtjevId, upsert);
            Parent.Reload();
        }
    }

}