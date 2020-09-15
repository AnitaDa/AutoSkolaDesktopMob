using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Uplate.Izvjestaj
{
    public partial class frmUplateIzvjestajj : Form
    {
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _uplate = new APIService("Uplate");


        public frmUplateIzvjestajj()
        {
            InitializeComponent();
        }
        string datum;
        private async void frmUplateIzvjestajj_Load(object sender, EventArgs e)
        {
            dtpUplata.CustomFormat = " ";
            datum = dtpUplata.Value.ToString("dd-MM-yyyy");
            var kandidati = await _kandidati.Get<List<MKandidat>>(null);
            kandidati.Insert(0, new MKandidat());
            cbKandidat.DataSource = kandidati;
            cbKandidat.DisplayMember = "ImePrezime";
            cbKandidat.ValueMember = "Id";
        }

        private async void btnUcitaj_Click(object sender, EventArgs e)
        {
            int ID=0;
            var kandidatId = cbKandidat.SelectedValue;
            if(int.TryParse(kandidatId.ToString(),out int Id))
            {
                ID = Id;
            }

            var uplate = await _uplate.Get<List<MUplate>>(null);
            ReportDataSource rdd = new ReportDataSource("DataSetUplate", uplate);
            reportViewerUplate.LocalReport.ReportPath =
                Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "Uplate", "Izvjestaj", "IzjvestajtUplate.rdlc");
            reportViewerUplate.LocalReport.DataSources.Clear();
            reportViewerUplate.LocalReport.DataSources.Add(rdd);
            reportViewerUplate.RefreshReport();
        }

        private async void dtpUplata_ValueChanged(object sender, EventArgs e)
        {
            dtpUplata.CustomFormat = "dd-MM-yyyy";
           var search =new UplataSearchRequest(){
               DatumUplate=dtpUplata.Value
            };
            var uplate = await _uplate.Get<List<MUplate>>(search);

        }

        private void dtpUplata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dtpUplata.CustomFormat = " ";
                datum = dtpUplata.Value.ToString("yyyy-MM-dd");
            }
        }
    }
}
