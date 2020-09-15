using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.UserControls;

using System;

using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace AutoSkola.WinUI.Zahtjevi

{

    public partial class frmZahtjevi : Form

    {

        private readonly APIService _zahtjeviUrl = new APIService("Zahtjevi");
        private readonly APIService _uslugeUrl = new APIService("Usluge");

        public frmZahtjevi()

        {

            InitializeComponent();

        }



        private async void frmZahtjevi_Load(object sender, EventArgs e)

        {
            var result = await _uslugeUrl.Get<List<MUsluge>>(null);
            result.Insert(0, new MUsluge());
            cbUsluga.DataSource = result;
            cbUsluga.DisplayMember = "NazivKategorija";
            cbUsluga.ValueMember = "Id";
            //cbUsluga.SelectedIndex = 0;
            var zahtjevi = await _zahtjeviUrl.Get<List<MZahtjevi>>(null);

            FormirajTabelu(zahtjevi);

        }

        private void FormirajTabelu(List<MZahtjevi> zahtjevi)

        {
            flowLayoutZahtjevi.Controls.Clear();
            int brojacZahtjeva = zahtjevi.Count();

            //dodavanje headera

            flowLayoutZahtjevi.Controls.Add(new HeaderTable());

            //dodavanje ostalih redova 

            RowZahtjevi[] red = new RowZahtjevi[brojacZahtjeva];

            for (int i = 0; i < brojacZahtjeva; i++)

            {

                red[i] = new RowZahtjevi() { Parent = this };

                red[i].Kandidat = zahtjevi[i].Kandidat;

                red[i].Usluga = zahtjevi[i].Usluga;

                red[i].Kategorija = zahtjevi[i].Kategorija;
                red[i].ZahtjevId = zahtjevi[i].Id;
                red[i].Instruktor = zahtjevi[i].Instruktor;

                flowLayoutZahtjevi.Controls.Add(red[i]);

            }



        }

        private async void cbUsluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutZahtjevi.Controls.Clear();
            var uslugaId = cbUsluga.SelectedValue;
            if(int.TryParse(uslugaId.ToString(),out int Id)){
                var search = new ZahtjeviSearchRequest()
                {
                    UslugaId=Id,
                    Ime=txtImePrezime.Text
                };
                var result =await _zahtjeviUrl.Get<List<MZahtjevi>>(search);
                FormirajTabelu(result);
            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new ZahtjeviSearchRequest();
            flowLayoutZahtjevi.Controls.Clear();
            //razdvajanje imena od prezimena ukoliko postoji

            int brojreci = txtImePrezime.Text.Split(' ').Count();
           
            if (brojreci == 2)
            {
                var imeprezime = txtImePrezime.Text.Split(' ');
                string Ime = imeprezime[0];
                string Prezime = imeprezime[1];
                search.Ime = Ime;
                search.Prezime = Prezime;
            }
            else
            {
                search.Ime = txtImePrezime.Text;
            }
            var uslugaId = cbUsluga.SelectedValue;
            if (int.TryParse(uslugaId.ToString(), out int Id))
            {
                search.UslugaId = Id;
            }
            var result = await _zahtjeviUrl.Get<List<MZahtjevi>>(search);
            FormirajTabelu(result);
        }
        public void Reload() {
            frmZahtjevi_Load(this, EventArgs.Empty);
        }

    }

}