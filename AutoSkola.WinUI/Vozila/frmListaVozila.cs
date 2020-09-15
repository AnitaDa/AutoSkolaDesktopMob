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

namespace AutoSkola.WinUI.Vozila
{
    public partial class frmListaVozila : Form
    {
        private APIService _vozila = new APIService("Vozila");
        private APIService _marka = new APIService("Marka");

        private Panel _pnlPocetna;
        public frmListaVozila(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }

        private async void frmListaVozila_Load(object sender, EventArgs e)
        {
            //ucitavanje svih marki vozila
            var marke =await _marka.Get<List<MMarka>>(null);
            marke.Insert(0, new MMarka());
            cbMarka.DataSource = marke;
            cbMarka.DisplayMember = "Naziv";
            cbMarka.ValueMember = "Id";
            var vozila = await _vozila.Get<List<MVozilo>>(null);
            PrikaziVozila(vozila);
        }
        public void PrikaziVozila(List<MVozilo> vozila)
        {
            flpListaVozila.Controls.Clear();  
            Vozilo[] listaVozila = new Vozilo[vozila.Count()];
            for(int i = 0; i < vozila.Count(); i++)
            {
               
                listaVozila[i] = new Vozilo(_pnlPocetna) {Parent=this };
                if (vozila[i].Slika != null)
                {
                    listaVozila[i].Slika = vozila[i].Slika;           
                } 
                //tu treba da bude filename
               
                
                //listaVozila[i].Slika = Image.FromFile();
                listaVozila[i].VoziloId = vozila[i].Id;
                listaVozila[i].RegOznaka = vozila[i].RegistarskaOznaka;
                flpListaVozila.Controls.Add(listaVozila[i]);
            }
        }

        private async void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            var markaId = cbMarka.SelectedValue;
            if(int.TryParse(markaId.ToString(),out int Id))
            {
                var search = new VoziloSearchRequest()
                {
                    MarkaId=Id
                };
                var vozila = await _vozila.Get<List<MVozilo>>(search);
                
                PrikaziVozila(vozila);
            }
        }

        private void btnNovoVozilo_Click(object sender, EventArgs e)
        {
            frmNovoVozilo novoVozilo = new frmNovoVozilo(null,null) {Parent=this };
            novoVozilo.Show();
        }
        public void Reload()
        {
            frmListaVozila_Load(this, EventArgs.Empty);
        }
    }
}
