using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.Raspored_polganja;
using AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Raspored_polaganja.TerminiRasporedaPolaganja
{
    public partial class frmNoviTerminPolaganje : Form
    {
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _terminRP = new APIService("TerminRasporedaPolaganja");
        private int? _rasporedPolaganjaId=null;
        private int? _terminId;
#pragma warning disable CS0108 // 'frmNoviTerminPolaganje.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmTerminRasporedaPolaganja Parent;
#pragma warning restore CS0108 // 'frmNoviTerminPolaganje.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNoviTerminPolaganje(int? rasporedPolaganjaId=null,int? terminId=null)
        {
            InitializeComponent();
            _terminId = terminId;
            _rasporedPolaganjaId = rasporedPolaganjaId;
        }
        private async void frmNoviTermin_Load(object sender, EventArgs e)
        {
            var kandidati = await _kandidati.Get<List<MKandidat>>(null);
            kandidati.Insert(0, new MKandidat { ImePrezime = "Odaberite kandidata" });
            cbKandidat.DataSource = kandidati;
            cbKandidat.DisplayMember = "ImePrezime";
            cbKandidat.ValueMember = "Id";
            if (_terminId.HasValue)
            {
                var postojeciTermin = await _terminRP.GetById<MTerminRasporedaPolaganja>(_terminId);
                txtOd.Text = postojeciTermin.Od;
                txtDo.Text = postojeciTermin.Do;
                _rasporedPolaganjaId = postojeciTermin.RasporedPolaganjaId;
                cbKandidat.SelectedValue = int.Parse(postojeciTermin.KandidatId.ToString());
            }
                
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var odabraniKandidatId = cbKandidat.SelectedValue;
            var upsert = new TerminRPUpsertRequest();
            if(int.TryParse(odabraniKandidatId.ToString(),out int Id))
            {
                upsert.KandidatId = Id;
            }

            upsert.Od = txtOd.Text;
            upsert.Do = txtDo.Text;
            upsert.RasporedPolaganjaId = _rasporedPolaganjaId;
            if (_terminId.HasValue) 
            {
                upsert.Id = _terminId;
                var t = await _terminRP.Update<MTerminRasporedaPolaganja>(_terminId, upsert);
                if (t != null)
                {
                    MessageBox.Show("Termin uspješno izmjenjen!");
                    this.Close();
                    Parent.Reload();
                }
            }
            else
            {
                var t = await _terminRP.Insert<MTerminRasporedaPolaganja>(upsert);
                if (t != null)
                {
                    MessageBox.Show("Termin uspješno dodan!");
                    this.Close();
                    Parent.Reload();

                }
            }


        }

     
    }
}
