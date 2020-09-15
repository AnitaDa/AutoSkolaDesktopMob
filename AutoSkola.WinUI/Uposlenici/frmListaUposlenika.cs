using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Uposlenici
{
    public partial class frmListaUposlenika : Form
    {
        private APIService _uposlenici = new APIService("Uposlenici");
        private Panel _pnlPocetna;
        public frmListaUposlenika(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }

        private async void frmListaUposlenika_Load(object sender, EventArgs e)
        {
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(null);
            PrikaziListu(uposlenici);
        }
        private void PrikaziListu(List<MUposlenik> uposlenici)
        {
            flpUposlenici.Controls.Clear();
            Uposlenik[] listaUposlenika = new Uposlenik[uposlenici.Count()];
            for(int i = 0; i < uposlenici.Count(); i++)
            {
                listaUposlenika[i] = new Uposlenik(_pnlPocetna);
                listaUposlenika[i].UposlenikId = uposlenici[i].Id;
                listaUposlenika[i].ImePrezime = uposlenici[i].ImePrezime;
                if (uposlenici[i].Slika != null)
                    listaUposlenika[i].Slika = uposlenici[i].Slika;
                flpUposlenici.Controls.Add(listaUposlenika[i]);
            }
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            int brojreci = txtUposlenik.Text.Split(' ').Count();
            UposleniciSearchRequest search;
            if (brojreci == 2)
            {
                var imeprezime = txtUposlenik.Text.Split(' ');
                string Ime = imeprezime[0];
                string Prezime = imeprezime[1];
                search = new UposleniciSearchRequest()
                {
                    Ime = Ime,
                    Prezime = Prezime
                };
            }
            else
            {
                search = new UposleniciSearchRequest()
                {
                    Ime = txtUposlenik.Text
                };
            }

            var result = await _uposlenici.Get<List<MUposlenik>>(search);
            PrikaziListu(result);
        }

        private void btnUposlenik_Click(object sender, EventArgs e)
        {
            frmNoviUposlenik uposlenik = new frmNoviUposlenik(null) {Parent=this };       
            uposlenik.Show();
        }
        public void Reload()
        {
            frmListaUposlenika_Load(this, EventArgs.Empty);
        }
    }
}
