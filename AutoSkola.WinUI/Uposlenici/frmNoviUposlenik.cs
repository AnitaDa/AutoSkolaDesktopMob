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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Uposlenici
{
    public partial class frmNoviUposlenik : Form
    {
        private APIService _tip = new APIService("TipUposlenika");
        private APIService _UposlenikTip = new APIService("UposlenikTipUposlenika");

        private APIService _korisnikUloga = new APIService("KorisnikUloga");
        private APIService _korisnik = new APIService("Korisnici");
        private APIService _uposlenik = new APIService("Uposlenici");
#pragma warning disable CS0108 // 'frmNoviUposlenik.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaUposlenika Parent;
#pragma warning restore CS0108 // 'frmNoviUposlenik.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        private int? _UposlenikId;
        private bool IzmjenaSlike = false;
        public byte[] _Slika;
        public frmNoviUposlenik(int? UposlenikId)
        {
            InitializeComponent();
            _UposlenikId = UposlenikId;
        }

        private async void frmNoviUposlenik_Load(object sender, EventArgs e)
        {
            if (_UposlenikId.HasValue)
            {
                //var korisnik = await _korisnik.Get<List<MKorisnik>>(new KorisniciSearchRequest { Id = APIService.trenutniKorisnik.Id });
                var uposlenik = await _uposlenik.GetById<MUposlenik>(_UposlenikId);
                if (uposlenik!=null)
                {
                    txtIzmenaEmail.Text = APIService.trenutniKorisnik.Email;
                    txtIzmenaKorisnickoIme.Text = APIService.trenutniKorisnik.KorisnickoIme;
                    txtIzmenaIme.Text = uposlenik.Ime;
                    txtIzmenaPrezime.Text = uposlenik.Prezime;
                    if(uposlenik.Slika!=null)
                        using (var ms = new MemoryStream(uposlenik.Slika))
                        {
                            pictureUposlenik.Image = Image.FromStream(ms);
                        }
                    _Slika = uposlenik.Slika;
                }
                pnlIzmenaLicnihPodataka.Visible = true;
            }
            //combo box tip uposlenika
            pnlNoviUposlenik.Visible = true;
            var result = await _tip.Get<List<MTipUposlenika>>(null);
            result.Insert(0, new MTipUposlenika { Naziv = "Odaberite tip" });
            cbTipUposlenika.DataSource = result;
            cbTipUposlenika.DisplayMember = "Naziv";
            cbTipUposlenika.ValueMember = "Id";
        }
        //javna zbog dodavanja slike
        UposlenikUpsertRequest upsertUposlenik = new UposlenikUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {         
                var upsertKorisnik = new KorisnikUpsertRequest();

                if (_UposlenikId.HasValue)
                {
                    MKorisnik korisnik=null;
                    MUposlenik uposlenik=null;
                    var trenutniUposlenik = await _uposlenik.GetById<MUposlenik>(_UposlenikId);
                //ovde menjamo postojece podatke za tablu korisnik
                if (!IzmjenaSlike)
                {
                    upsertUposlenik.Slika = _Slika;
                }
                upsertKorisnik.Id = APIService.trenutniKorisnik.Id;
                    upsertKorisnik.Email = txtIzmenaEmail.Text;
                    upsertKorisnik.KorisnickoIme = txtIzmenaKorisnickoIme.Text;
                    upsertKorisnik.StaraLozinka = txtStaraLozinka.Text;
                    upsertKorisnik.Lozinka = txtNovaLozinka.Text; 
                    if(txtStaraLozinka.Text!=null && txtNovaLozinka.Text != null)
                    {
                       korisnik= await _korisnik.Update<MKorisnik>(APIService.trenutniKorisnik.Id,upsertKorisnik);
                    }
                //izmena za tablelu uposlenik
                    upsertUposlenik.Id = trenutniUposlenik.Id;
                    upsertUposlenik.Ime = txtIzmenaIme.Text;
                    upsertUposlenik.Prezime = txtIzmenaPrezime.Text;
                    upsertUposlenik.DatumRodjenja = trenutniUposlenik.DatumRodjenja;
                    upsertUposlenik.KorisnikId = APIService.trenutniKorisnik.Id;
                  uposlenik= await _uposlenik.Update<MUposlenik>(_UposlenikId, upsertUposlenik);
                    if (korisnik != null && uposlenik != null)
                    {
                        MessageBox.Show("Uspjesno izmjenjeni podaci!");
                    }
                    else
                    {
                        MessageBox.Show("Doslo je do greske!");
                    }
                frmNoviUposlenik_Load(this, EventArgs.Empty);
                }
            if (ValidirajPolja())
            {
                // dodavanje korisnickog naloga
                upsertKorisnik.Email = txtEmail.Text;
                upsertKorisnik.KorisnickoIme = txtKorisnickoIme.Text;
                upsertKorisnik.Lozinka = txtLozinka.Text;
                upsertKorisnik.PotrvrdnaLozinka = txtLozinka.Text;
                var noviKorisnik = await _korisnik.Insert<MKorisnik>(upsertKorisnik);
                //korisnik_uloga dodavanje
                var upsertKorisnikUloga = new KorisnikUlogaUpsertRequest();
                var upsertUposlenikTip = new UTUUpsertRequest();

                var tipUposlenikaId = cbTipUposlenika.SelectedValue;
                if (int.TryParse(tipUposlenikaId.ToString(), out int TUId))
                {   
                    upsertKorisnikUloga.UlogaId = TUId;
                }
                upsertKorisnikUloga.KorisnikId = noviKorisnik.Id;
                await _korisnikUloga.Insert<MKorisnikUloga>(upsertKorisnikUloga);
                //dodavanje objekta uposlenik
                upsertUposlenik.Ime = txtIme.Text;
                upsertUposlenik.Prezime = txtPrezime.Text;
                upsertUposlenik.DatumRodjenja = dtpDatumRodjenja.Value;
                upsertUposlenik.KorisnikId = noviKorisnik.Id;
                var noviUposlenik = await _uposlenik.Insert<MUposlenik>(upsertUposlenik);
                if (noviUposlenik != null)
                {
                    MessageBox.Show("Uposlenik uspjesno dodan!");
                    this.Close();
                    Parent.Reload();
                }
                //uposlenik_tipUposlenika
                var TipId = cbTipUposlenika.SelectedValue;
                if (int.TryParse(TipId.ToString(), out int Id))
                {
                    upsertUposlenikTip.TipUposlenikaId = Id;
                }
                upsertUposlenikTip.UposlenikId = noviUposlenik.Id;

                await _UposlenikTip.Insert<MUposlenikTipUposlenika>(upsertUposlenikTip);
            }
        }
        //ucitavanje slike
        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            IzmjenaSlike = true;
            var result = openFileDialogUposlenik.ShowDialog();
            if (result == DialogResult.OK) { 
            var fileName = openFileDialogUposlenik.FileName;
            upsertUposlenik.Slika = File.ReadAllBytes(fileName);
            pictureUposlenik.Image = Image.FromFile(fileName);
            }
        }
        public bool ValidirajPolja()
        {
            bool rezultat = true;
            GIme.Visible = false;
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                GIme.Visible = true;
                rezultat = false;
            }
            GPrezime.Visible = false;
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                GPrezime.Visible = true;
                rezultat = false;
            }

            GTipUposlenika.Visible = false;
            if (int.TryParse(cbTipUposlenika.SelectedValue.ToString(), out int Id)){
                if (Id == 0)
                {
                        GTipUposlenika.Visible = true;
                        rezultat = false;       
                }
            }
            GKorisnickoIme.Visible = false;
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                GKorisnickoIme.Visible = true;
                rezultat = false;
            }
            GEmail.Visible = false;
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {

                if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) {
                    GEmail.Text = "Neispravan format email unosa";
                    GEmail.Visible = true;
                    rezultat = false; 
                }
            }
            else
            {
                GEmail.Text = "Obavezno polje";
                GEmail.Visible = true;
                rezultat = false;
            }
            GLozinka.Visible = false;
            if (string.IsNullOrEmpty(txtLozinka.Text))
            {
                GLozinka.Visible = true;
                rezultat = false;
            }
            GPotvrdnaLozinka.Visible = false;
            if (string.IsNullOrEmpty(txtPotvrdnaLozinka.Text))
            {
                GPotvrdnaLozinka.Visible = true;
                rezultat = false;
            }
            return rezultat;
        }
    }
}
