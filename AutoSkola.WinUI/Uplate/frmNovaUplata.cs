using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Flurl.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Uplate
{
    public partial class frmNovaUplata : Form
    {
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _uplata = new APIService("Uplate");
#pragma warning disable CS0108 // 'frmNovaUplata.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmUplate Parent;
#pragma warning restore CS0108 // 'frmNovaUplata.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNovaUplata()
        {
            InitializeComponent();
        }

        private async void frmNovaUplata_Load(object sender, EventArgs e)
        {
           await ListaKandidata();

        }
        private async Task ListaKandidata()
        {
            var result =await _kandidati.Get<List<MKandidat>>(null); 
            cbKandidat.DataSource = result;
            cbKandidat.DisplayMember = "ImePrezime";
            cbKandidat.ValueMember = "Id";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPolja())
            {
                UplataUpsertRequest novaUplata = new UplataUpsertRequest();
                var odabraniKandidatId = cbKandidat.SelectedValue;
                if (int.TryParse(odabraniKandidatId.ToString(), out int id))
                {
                    novaUplata.KandidatId = id;
                }
                novaUplata.DatumUplate = dtpDatumUplate.Value;
                novaUplata.Svrha = txtSvrha.Text;
                novaUplata.Iznos = (int)numericIznos.Value;
                await _uplata.Insert<MUplate>(novaUplata);
                if (novaUplata != null)
                {
                    DialogResult poruka = MessageBox.Show("Uspješno evidentirana uplata!");
                    this.Close();
                    Parent.Reload();
                }
            }
        }
        private bool ValidirajPolja()
        {
            bool rezultat = true;
            GSvrha.Visible = false;
            if (string.IsNullOrEmpty(txtSvrha.Text))
            {
                GSvrha.Visible = true;
                rezultat= false;
            }
            GIznos.Visible = false;
            if (numericIznos.Value==0)
            {
                GIznos.Visible = true;
                rezultat= false;
            }
            return rezultat;
        }

    }
}
