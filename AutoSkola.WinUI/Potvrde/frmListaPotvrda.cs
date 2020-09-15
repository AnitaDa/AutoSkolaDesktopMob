using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Potvrde
{
    public partial class frmListaPotvrda : Form
    {
        private APIService _potvrde = new APIService("Potvrde");
        private APIService _kategorije = new APIService("Kategorije");

        public frmListaPotvrda()
        {
            InitializeComponent();

        }

        private async void frmListaPotvrda_Load(object sender, EventArgs e)
        {
            //combo box kategorije
            var katetgorije = await _kategorije.Get<List<MKategorije>>(null);
            katetgorije.Insert(0, new MKategorije());
            cbKategorija.DataSource = katetgorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "Id";
            ////datum
            dtpDatumPolaganja.CustomFormat = " ";
            dtpDatumPolaganja.Format = DateTimePickerFormat.Custom;
           

            var potvrde = await _potvrde.Get<List<MPotvrda>>(null);
            PrikaziListu(potvrde);
        }
        private void PrikaziListu(List<MPotvrda> potvrde)
        {
            flpListaPotvrda.Controls.Clear();
            flpListaPotvrda.Controls.Add(new HeaderPotvrde());
            RowPotvrda[] listaPotvrda = new RowPotvrda[potvrde.Count()];
            for (int i = 0; i < potvrde.Count(); i++)
            {
                listaPotvrda[i] = new RowPotvrda();
                listaPotvrda[i].Kandidat = potvrde[i].KandidatIme;
                listaPotvrda[i].Kategorija = potvrde[i].Kategorija;
                listaPotvrda[i].DatumPolaganja = potvrde[i].DatumPolaganja.ToString("dd/MM/yyyy");
                listaPotvrda[i].PotvduIzdao = potvrde[i].UposlenikIme;
                flpListaPotvrda.Controls.Add(listaPotvrda[i]);
            }

        }
        private async void dtpDatumPolaganja_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumPolaganja.CustomFormat = "dd-MM-yyyy";
            var kategorijaId = cbKategorija.SelectedValue;
            if (int.TryParse(kategorijaId.ToString(), out int katId))
            {
                var search = new PotvrdaSearchRequest()
                {
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    KategorijaId = katId
                };
                var potvrde = await _potvrde.Get<List<MPotvrda>>(search);

                PrikaziListu(potvrde);
            }
        }

        private async void dtpDatumPolaganja_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtpDatumPolaganja.CustomFormat = " ";
                //dtpDatumPolaganja.Format = DateTimePickerFormat.Custom;
                //dtpDatumPolaganja.Value = DateTime.Now.AddDays(1);
                var potvrde = await _potvrde.Get<List<MPotvrda>>(null);
                PrikaziListu(potvrde);
            }
        }

        private async void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDatumPolaganja.CustomFormat = "dd-MM-yyyy";
            var kategorijaId = cbKategorija.SelectedValue;
            if (int.TryParse(kategorijaId.ToString(), out int katId))
            {
                var search = new PotvrdaSearchRequest()
                {
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    KategorijaId = katId
                };
                var potvrde = await _potvrde.Get<List<MPotvrda>>(search);

                PrikaziListu(potvrde);
            }
        }
        public void Reload()
        {
            frmListaPotvrda_Load(this, EventArgs.Empty);
        }
    }
}
