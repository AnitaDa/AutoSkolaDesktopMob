
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.Kategorije;
using AutoSkola.WinUI.Korisnici;
using AutoSkola.WinUI.Pocetna;
using AutoSkola.WinUI.Potvrde;
using AutoSkola.WinUI.Raspored_casova;
using AutoSkola.WinUI.Raspored_polganja;
using AutoSkola.WinUI.Uplate;
using AutoSkola.WinUI.Uposlenici;
using AutoSkola.WinUI.Usluge;
using AutoSkola.WinUI.Vozila;
using AutoSkola.WinUI.Zahtjevi;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;
using System.Management;
using System.Text;

using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace AutoSkola.WinUI

{

    public partial class frmPocetna : Form

    {
        private readonly APIService _korisnikUloge = new APIService("KorisnikUloga");
        private readonly APIService _uposlenici = new APIService("Uposlenici");
#pragma warning disable CS0414 // The field 'frmPocetna.prikaziPocetnu' is assigned but its value is never used
        private bool prikaziPocetnu = false;
#pragma warning restore CS0414 // The field 'frmPocetna.prikaziPocetnu' is assigned but its value is never used
        //private bool referent = true;
        public frmPocetna()
        {
            InitializeComponent();
            UlogaTrenutnogKorisnika();

        }
        private async void UlogaTrenutnogKorisnika()
        {
            var search = new KorisnikUlogaSearchRequest() { KorisnikId = APIService.trenutniKorisnik.Id };
            var korisniciUloge = await _korisnikUloge.Get<List<MKorisnikUloga>>(search);

            if (korisniciUloge.FirstOrDefault().UlogaNaziv == "Instruktor")
            {              
                APIService.UlogaNaziv = korisniciUloge.FirstOrDefault().UlogaNaziv;
                OtvoriFormu(new frmRasporedCasova(pnlPocetna), pnlPocetna);
            }
            else if (korisniciUloge.FirstOrDefault().UlogaNaziv == "Referent")
            {
                panelReferent.Visible = true;
                prikaziPocetnu = true;
            }
    
        }
        private async void frmPocetna_Load(object sender, EventArgs e)
        {
            var search = new KorisnikUlogaSearchRequest() { KorisnikId = APIService.trenutniKorisnik.Id };
            var korisniciUloge = await _korisnikUloge.Get<List<MKorisnikUloga>>(search);
            if (korisniciUloge.FirstOrDefault().UlogaNaziv == "Referent")
                btnPocetnaKartica_Click(this, EventArgs.Empty);
            lblKorisnikEmail.Text = APIService.trenutniKorisnik.Email;
        }
        private void btnUplate_Click(object sender, EventArgs e)

        {
            frmUplate uplata = new frmUplate();
            OtvoriFormu(uplata, pnlPocetna);
            OtvoriFormu(new frmNavBarUplat(pnlPomoc, pnlPocetna) {Parent=uplata }, pnlPomoc, false);
        }
        private void btnZahtjevi_Click(object sender, EventArgs e)

        {
            OtvoriFormu(new frmZahtjevi(), pnlPocetna);
        }



        private void btnRasporedCasova_Click(object sender, EventArgs e)

        {
            OtvoriFormu(new frmRasporedCasova(pnlPocetna), pnlPocetna);

        }

        private void btnKandidati_Click(object sender, EventArgs e)
        {
           
            OtvoriFormu(new frmKandidati(pnlPocetna), pnlPocetna);
        }

        private void btnRasporedPolaganja_Click(object sender, EventArgs e)
        {

            OtvoriFormu(new frmRasporedPolaganja(pnlPocetna), pnlPocetna);
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmListaUsluga(), pnlPocetna);
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {

            OtvoriFormu(new frmListaKategorija(pnlPocetna), pnlPocetna);
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            frmListaPotvrda potvrde = new frmListaPotvrda();
            OtvoriFormu(new frmNavBar(pnlPocetna) {Parent=potvrde }, pnlPomoc);
            OtvoriFormu(potvrde, pnlPocetna,false,false);
        }
        //Univerzalna funckija za prikaz forme na panelu
        
        public void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true,bool ZatvoriPomocniPanel=true)

        {
            if (ZatvoriPomocniPanel)
            {
                pnlPomoc.Controls.Clear();

            }
            if (Zatvori == true)

            {
                pnlPocetna.Controls.Clear();
            }

            forma.TopLevel = false;//bez ovog ne bih mogla dodati formu u panel

            forma.FormBorderStyle = FormBorderStyle.None;

            forma.Dock = DockStyle.Fill;

            panel.Controls.Add(forma);

            panel.Tag = forma;//ne znam sta je

            forma.BringToFront();

            forma.Show();



        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmListaVozila(pnlPocetna), pnlPocetna);
        }

        private void btnUposlenici_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmListaUposlenika(pnlPocetna), pnlPocetna);
        }

        private void btnPocetnaKartica_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmPocetnaKartica(this,pnlPocetna), pnlPocetna);
        }

        private void lblOdjaviSe_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //var login = new frmLogin();
            //login.Show();
            //kako treba ovde jel ok
        }

        private async void lblKorisnikEmail_Click(object sender, EventArgs e)
        {
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(new UposleniciSearchRequest {KorisnikId=APIService.trenutniKorisnik.Id});
            OtvoriFormu(new frmNoviUposlenik(uposlenici.FirstOrDefault().Id), pnlPocetna);
            var search = new KorisnikUlogaSearchRequest() { KorisnikId = APIService.trenutniKorisnik.Id };
            var korisniciUloge = await _korisnikUloge.Get<List<MKorisnikUloga>>(search);

            if (korisniciUloge.FirstOrDefault().UlogaNaziv == "Instruktor")
            {
                pnlInstruktor.Visible = true;
                buttonInstruktor.Visible = true;
            }
          
        }
    }

}