using AutoSkola.Model;
using AutoSkola.Model.Requests;
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

namespace AutoSkola.WinUI.Potvrde
{
    public partial class frmNovaPotvrda : Form
    {
        private APIService _kategorije = new APIService("Kategorije");
        private APIService _uposlenici = new APIService("Uposlenici");
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _potvrde = new APIService("Potvrde");
#pragma warning disable CS0108 // 'frmNovaPotvrda.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaPotvrda Parent;
#pragma warning restore CS0108 // 'frmNovaPotvrda.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNovaPotvrda()
        {
            InitializeComponent();
        }
        private async void frmNovaPotvrda_Load(object sender, EventArgs e)
        {
            // combo box za uposlenike
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(null);
            cbUposlenik.DataSource = uposlenici;
            cbUposlenik.DisplayMember = "ImePrezime";
            cbUposlenik.ValueMember = "Id";
            // combo box za kategorije
            var kategorije = await _kategorije.Get<List<MKategorije>>(null);
            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "Id";
            //combo box za kandidate
            var kandidati = await _kandidati.Get<List<MKandidat>>(null);
            cbKandidati.DataSource = kandidati;
            cbKandidati.DisplayMember = "ImePrezime";
            cbKandidati.ValueMember = "Id";
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
                var kategorijaId = cbKategorija.SelectedValue;
                var uposlenikId = cbUposlenik.SelectedValue;
                var kandidatId = cbKandidati.SelectedValue;

                var kat = int.TryParse(kategorijaId.ToString(), out int KategorijaId);
                var upo = int.TryParse(uposlenikId.ToString(), out int UposlenikId);
                var kan = int.TryParse(kandidatId.ToString(), out int KandidatId);

            if (kat && upo && kan)
            {
                var upsert = new PotvrdaUpsertRequest()
                {
                    KategorijaId = KategorijaId,
                    KandidatId = KandidatId,
                    UposlenikId = UposlenikId,
                    DatumPolaganja = dtpDatumPolaganja.Value
                };
                var potvrda = await _potvrde.Insert<MPotvrda>(upsert);
                if (potvrda != null)
                {
                    MessageBox.Show("Uspjesno dodana potvrda!");
                    this.Close();
                    Parent.Reload();
                }
            }    
        }
    }
}
