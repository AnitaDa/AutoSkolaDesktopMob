using AutoSkola.Model;

using AutoSkola.Model.Requests;

using AutoSkola.WinUI.UserControls;
using Microsoft.SqlServer.Server;
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace AutoSkola.WinUI.Uplate

{

    public partial class frmUplate : Form

    {

        private readonly APIService _uplateUrl = new APIService("Uplate");

        public frmUplate()

        { 
            InitializeComponent();
        }

        private async void frmUplate_Load(object sender, EventArgs e)

        {
            dtpUplate.CustomFormat = " ";
            dtpUplate.Format = DateTimePickerFormat.Custom;
            var uplate = await _uplateUrl.Get<List<MUplate>>(null);
            PrikaziUplate(uplate);
        }

        private void PrikaziUplate(List<MUplate> uplate)

        {

            if (flowLayoutPanelUplate.Controls.Count > 0)

            {

                flowLayoutPanelUplate.Controls.Clear();

            }

            int brojacUplata = uplate.Count();

            ListaUplata[] listaUplata = new ListaUplata[brojacUplata];

            for (int i = 0; i < brojacUplata; i++)

            {

                listaUplata[i] = new ListaUplata(){};

                listaUplata[i].ImePrezime = uplate[i].Kandidat;

                listaUplata[i].Datum = uplate[i].DatumUplate.ToString("dd/MMMM/yyyy");

                listaUplata[i].Iznos = uplate[i].Iznos.ToString() + "KM";

                listaUplata[i].Svrha = uplate[i].Svrha;
                if (uplate[i].Slika != null)
                    listaUplata[i].Slika = uplate[i].Slika;

                flowLayoutPanelUplate.Controls.Add(listaUplata[i]);

            }

        }


        //ujedno kupi vrednost iz date time pickera i proverava
        private async void btnPretrazi_Click(object sender, EventArgs e)

        {
            int brojreci = txtPretragaUplate.Text.Split(' ').Count();
            UplataSearchRequest search;
            if (brojreci == 2)
            {
                var imeprezime = txtPretragaUplate.Text.Split(' ');
                string Ime = imeprezime[0];
                string Prezime = imeprezime[1];
                search = new UplataSearchRequest()
                {
                    Ime = Ime,
                    Prezime = Prezime
                };
            }
            else
            {
                search = new UplataSearchRequest()
                {
                    Ime = txtPretragaUplate.Text,
                    DatumUplate=dtpUplate.Value
                };
            }
            var uplate = await _uplateUrl.Get<List<MUplate>>(search);

            PrikaziUplate(uplate);

        }
        //ujedno kupi podatak iz polja za pretrazivanje kandidata, ukoliko je uneseno odredjeno ime, filtirra uplate za tog kandidata
        private async void dtpUplate_ValueChanged(object sender, EventArgs e)
        {

            dtpUplate.CustomFormat = "dd-MM-yyyy";
            var search = new UplataSearchRequest()
            {
                DatumUplate = dtpUplate.Value,
                Ime = txtPretragaUplate.Text
            };
            var uplate = await _uplateUrl.Get<List<MUplate>>(search);

            PrikaziUplate(uplate);

        }

        private async void dtpUplate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back || e.KeyCode==Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dtpUplate.CustomFormat = " ";
                //dtpUplate.Value = DateTime.Now.AddDays(1);
                var uplate = await _uplateUrl.Get<List<MUplate>>(null);
                txtPretragaUplate.Text = null;         
                PrikaziUplate(uplate);
            }
        }
        public void Reload()
        {
            frmUplate_Load(this, EventArgs.Empty);
        }
    }
}

