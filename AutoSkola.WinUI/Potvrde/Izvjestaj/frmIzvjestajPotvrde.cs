using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Potvrde.Izvjestaj
{
    public partial class frmIzvjestajPotvrde : Form
    {
        private APIService _potvrde = new APIService("Potvrde");
        private APIService _kategorije = new APIService("Kategorije");

        public frmIzvjestajPotvrde()
        {
            InitializeComponent();
        }

        private async void IzvjestajPotvrde_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPotvrde.DataTable1' table. You can move, or remove it, as needed.
            var kat = await _kategorije.Get<List<MKategorije>>(null);
            kat.Insert(0, new MKategorije { Naziv = "---Odaberite kategoriju---" });
            cbKategorije.DataSource = kat;
            cbKategorije.DisplayMember = "Naziv";
            cbKategorije.ValueMember = "Id";
            dtpDatumPolaganja.CustomFormat = " ";
          
        }

        private async void btnUcitaj_Click(object sender, EventArgs e)
        {

            dtpDatumPolaganja.CustomFormat = " ";
            var search = new PotvrdaSearchRequest();

            var kategorijaId = cbKategorije.SelectedValue;
            if (int.TryParse(kategorijaId.ToString(), out int Id))
            {
                search.KategorijaId = Id;
            }
            search.DatumPolaganja = dtpDatumPolaganja.Value;

            var potvrde = await _potvrde.Get<List<MPotvrda>>(search);

            ReportDataSource rd = new ReportDataSource("DataSetPotvrde", potvrde);
            reportViewerPotvrde.LocalReport.ReportPath =
                Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "Potvrde", "Izvjestaj", "IzvjestajPotvrde.rdlc");
                // @"C:\Users\Anita\source\repos\AutoSkola\AutoSkola.WinUI\Potvrde\Izvjestaj\IzvjestajPotvrde.rdlc";
            reportViewerPotvrde.LocalReport.DataSources.Clear();
            reportViewerPotvrde.LocalReport.DataSources.Add(rd);

            reportViewerPotvrde.RefreshReport();
        }

        private void dtpDatumPolaganja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dtpDatumPolaganja.CustomFormat = " ";
                dtpDatumPolaganja.Value = new DateTime(2000, 1, 1);
                btnUcitaj_Click(this, EventArgs.Empty);
                
            }
        }
    }
}
