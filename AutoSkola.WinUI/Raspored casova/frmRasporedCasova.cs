using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.UserControls;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace AutoSkola.WinUI.Raspored_casova

{

    public partial class frmRasporedCasova : Form

    {

        private readonly APIService _KandidatiUrl = new APIService("Kandidati");
        private readonly APIService _rasporedCasova = new APIService("RasporedCasova");

        private Panel _pnlPocetna;

        public frmRasporedCasova(Panel pnlPocetna)

        {

            InitializeComponent();

            _pnlPocetna = pnlPocetna;

        }
        private async void frmRasporedCasova_Load(object sender, EventArgs e)
        {
            if (APIService.UlogaNaziv == "Instruktor")
            {
                btnNoviTermin.Visible = false;
            }
            flpRasporedCasova.Controls.Add(new HeaderRasporedCasova());

            //Prikazuje kandidate u desnom delu forme
           
            dtpDatumTermina.CustomFormat = " ";
            dtpDatumTermina.Format = DateTimePickerFormat.Custom;
            
            var kandidati = await _KandidatiUrl.Get<List<MKandidat>>(null);

            PrikaziKandidate(kandidati);

            //Ucitavanje termina je ostavljeno prilikom klika na kandidata
        }
        private void PrikaziKandidate(List<MKandidat> kandidati)

        {  flpKandidati.Controls.Clear();
            int brojKandidata = kandidati.Count();

            ListaKandidataZaRaspored[] kandidat = new ListaKandidataZaRaspored[brojKandidata];

            for (int i = 0; i < brojKandidata; i++)

            {

                kandidat[i] = new ListaKandidataZaRaspored(flpRasporedCasova, dtpDatumTermina){Parent=this};

                kandidat[i].Kandidat = kandidati[i].ImePrezime;

                kandidat[i].KandidatId = kandidati[i].Id;

                flpKandidati.Controls.Add(kandidat[i]);

            }

        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            flpKandidati.Controls.Clear();
            //razdvajanje imena od prezimena ukoliko postoji

            int brojreci = txtPretragaKandidata.Text.Split(' ').Count();
            KandidatSearchRequest search;
            if (brojreci == 2)
            {
                var imeprezime = txtPretragaKandidata.Text.Split(' ');
                string Ime = imeprezime[0];
                string Prezime = imeprezime[1];
                search = new KandidatSearchRequest()
                {
                    Ime = Ime,
                    Prezime = Prezime
                };
            }
            else
            {
                search = new KandidatSearchRequest()
                {
                    Ime = txtPretragaKandidata.Text
                };
            }
            var kandidati = await _KandidatiUrl.Get<List<MKandidat>>(search);
            //int brojKandidata = kandidati.Count();

            PrikaziKandidate(kandidati);
         }
        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            
            frmNoviTermin t = new frmNoviTermin(null);
            t.Show();
        }

        private void dtpDatumTermina_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumTermina.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpDatumTermina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dtpDatumTermina.CustomFormat = " ";
                dtpDatumTermina.Value = new DateTime(2000, 1, 1);
            }
        }
    }

}