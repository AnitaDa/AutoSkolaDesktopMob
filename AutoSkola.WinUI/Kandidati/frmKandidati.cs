using AutoSkola.Model;

using AutoSkola.Model.Requests;

using AutoSkola.WinUI.UserControls;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace AutoSkola.WinUI.Korisnici

{

    public partial class frmKandidati : Form

    {

        private readonly APIService _kandidatiUrl = new APIService("Kandidati");
        private Panel _pocetniPanel;
        public frmKandidati(Panel pocetniPanel)

        {
            InitializeComponent();
            _pocetniPanel = pocetniPanel;
        }
        private async void frmKandidati_Load(object sender, EventArgs e)
        {
            var result = await _kandidatiUrl.Get<List<MKandidat>>(null);

            PrikaziKandidate(result);
        }
        private void PrikaziKandidate(List<MKandidat> kandidati)
        {
            int brojacKandidata = kandidati.Count();

            ListaKandidata[] listaKandidata = new ListaKandidata[brojacKandidata];

            for (int i = 0; i < brojacKandidata; i++)

            {

                listaKandidata[i] = new ListaKandidata(_pocetniPanel);
                listaKandidata[i].KandidatId = kandidati[i].Id;
                listaKandidata[i].Kandidat = kandidati[i].ImePrezime;

                if (kandidati[i].Slika != null)

                    listaKandidata[i].Slika = kandidati[i].Slika;

                flowLayoutPanelKandidati.Controls.Add(listaKandidata[i]);

            }

        }
        private async void btnPretraga_Click(object sender, EventArgs e)

        {

            //brisanje prethodnog sadrzaja
            flowLayoutPanelKandidati.Controls.Clear();
            //razdvajanje imena od prezimena ukoliko postoji
            
            int brojreci = txtPretraga.Text.Split(' ').Count();
            KandidatSearchRequest search;
            if (brojreci==2) {
                var imeprezime = txtPretraga.Text.Split(' ');
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
                    Ime = txtPretraga.Text
                };
            }
           
            var result = await _kandidatiUrl.Get<List<MKandidat>>(search);

            PrikaziKandidate(result);

        }
    }
    
}