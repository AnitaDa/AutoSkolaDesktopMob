using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Raspored_casova
{
    public partial class frmNoviTermin : Form
    {
        private APIService _vozila = new APIService("Vozila");
        private APIService _kandidati = new APIService("Kandidati");
        private APIService _terminRasporedaCasova = new APIService("TerminRasporedaCasova");
        private APIService _uposlenici = new APIService("Uposlenici");

        private int? _Id;
        private APIService _rasporedCasova = new APIService("RasporedCasova");
#pragma warning disable CS0108 // 'frmNoviTermin.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public ListaKandidataZaRaspored Parent;
#pragma warning restore CS0108 // 'frmNoviTermin.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNoviTermin(int? Id)
        {
            InitializeComponent();
            _Id = Id;
        }
        private async void frmNoviTermin_Load(object sender, EventArgs e)
        {
            //instruktori combo box
            var search = new UposleniciSearchRequest()
            {
                TipUposlenika = "instruktor"
            };
            var uposlenici = await _uposlenici.Get<List<MUposlenik>>(search);
            uposlenici.Insert(0, new MUposlenik { ImePrezime = "Odaberite uposlenika" });
            cbInstruktori.DataSource = uposlenici;
            cbInstruktori.DisplayMember = "ImePrezime";
            cbInstruktori.ValueMember = "Id";
            //vozila combo box
            var vozila = await _vozila.Get<List<MVozilo>>(null);
            vozila.Insert(0, new MVozilo { RegistarskaOznaka = "Odaberite vozilo" });
            cbVozilo.DataSource = vozila;
            cbVozilo.DisplayMember = "RegistarskaOznaka";
            cbVozilo.ValueMember = "Id";
            //kandidati combo box
            var kandidati = await _kandidati.Get<List<MKandidat>>(null);
            kandidati.Insert(0, new MKandidat { ImePrezime = "Odaberite kandidata" });
            cbKandidati.DataSource = kandidati;
            cbKandidati.DisplayMember = "ImePrezime";
            cbKandidati.ValueMember = "Id";
            if (_Id.HasValue)
            {
                var termin = await _terminRasporedaCasova.GetById<MTerminRasporedaCasova>(_Id);
                txtDo.Text = termin.Do;
                txtOd.Text = termin.Od;
                dtpDatum.Value = termin.Datum;
                cbKandidati.SelectedValue = int.Parse(termin.KandidatId.ToString());
                cbVozilo.SelectedValue = int.Parse(termin.VoziloId.ToString());
                cbInstruktori.SelectedValue = int.Parse(termin.UposlenikId.ToString());
                if (termin.Teorija)
                    checkBoxTeorija.Checked = true;
                if (termin.Prakticno)
                    checkBoxPrakticno.Checked = true;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPolja())
            {
                var upsert = new TeminRCUpsertRequest();
                if (_Id.HasValue)
                {
                    upsert.Id = _Id;            
                }
                upsert.Od = txtOd.Text;
                upsert.Do = txtDo.Text;               
                upsert.Datum = dtpDatum.Value;
                var voziloId = cbVozilo.SelectedValue;
                if (checkBoxPrakticno.Checked == true)
                {
                    upsert.Prakticno = true;
                }
                else
                {
                    upsert.Prakticno = false;
                }
                if (checkBoxTeorija.Checked == true)
                {
                    upsert.Teorija = true;
                }
                else
                {
                    upsert.Teorija = false;
                }

                if (int.TryParse(voziloId.ToString(), out int vId))
                {
                    upsert.VoziloId = vId;
                }
                var kandidatId = cbKandidati.SelectedValue;
                if (int.TryParse(kandidatId.ToString(), out int kanId))
                {

                    var search = new RasporedSearchRequest()
                    {
                        KandidatId = kanId
                    };
                    var raspored = await _rasporedCasova.Get<List<MRasporedCasova>>(search);
                    var pronadjeniRaspo = raspored.FirstOrDefault(x=>x.KandidatId==search.KandidatId);
                    upsert.RasporedCasovaId = pronadjeniRaspo.Id;
                    upsert.Status = false;
                }
                var instruktorId = cbInstruktori.SelectedValue;
                if (int.TryParse(instruktorId.ToString(), out int instId))
                {
                    upsert.UposlenikId = instId;
                }
                if (_Id.HasValue)
                {
                    var termin = await _terminRasporedaCasova.Update<MRasporedCasova>(_Id, upsert);
                    if (termin != null)
                    {
                        MessageBox.Show("Termin uspjesno izmjenjen!");
                        this.Close();
                        Parent.Reload();
                    }
                }
                else
                {
                    var termin = await _terminRasporedaCasova.Insert<MRasporedCasova>(upsert);
                    if (termin != null)
                    {
                        MessageBox.Show("Termin uspjesno dodan!");
                        this.Close();
                    }
                }
            }
        }
        private bool ValidirajPolja()
        {
            bool rezultat = true;
            GOd.Visible = false;
            if (string.IsNullOrEmpty(txtOd.Text))
            {
                GOd.Visible = true;
                rezultat = false;
                GOd.Text = "Obavezno polje";
            }
            else
            {
                if (!Regex.IsMatch(txtOd.Text, "^[0-9]"))
                {
                    GOd.Visible = true;
                    GOd.Text = "Dozvoljen unos samo brojeva";
                    rezultat = false;
                }
            }
            GDo.Visible = false;
            if (string.IsNullOrEmpty(txtDo.Text))
            {
                GDo.Visible = true;
                rezultat = false;
                GDo.Text = "Obavezno polje";
            }
            else
            {
                if (!Regex.IsMatch(txtDo.Text, "^[0-9]"))
                {
                    GDo.Text = "Dozvoljen unos samo brojeva";
                    GDo.Visible = true;
                    rezultat = false;
                }
            }
                GKandidat.Visible = false;
                if (int.TryParse(cbKandidati.SelectedValue.ToString(), out int Id))
                {
                    if (Id == 0)
                    {
                        GKandidat.Visible = true;
                        rezultat = false;
                    }
                }
                GVozilo.Visible = false;
                if (int.TryParse(cbVozilo.SelectedValue.ToString(), out int VoziloId))
                {
                    if (VoziloId == 0)
                    {
                        GVozilo.Visible = true;
                        rezultat = false;
                    }
                 }
            GInstruktor.Visible = false;
            if (int.TryParse(cbInstruktori.SelectedValue.ToString(), out int UposlenikId))
            {
                if (UposlenikId == 0)
                {
                    GInstruktor.Visible = true;
                    rezultat = false;
                }
            }

            GCheck.Visible = false;
            if (checkBoxPrakticno.Checked==true && checkBoxTeorija.Checked==true )
            {
                GCheck.Visible = true;
                rezultat = false;
                GCheck.Text = "Ne mozete oznaciti oba polja";
            }
            else if (checkBoxPrakticno.Checked==false && checkBoxTeorija.Checked==false)
            {
                GCheck.Visible = true;
                rezultat = false;
                GCheck.Text = "Morate odabrati teoriju ili prakticno";
            }
            return rezultat;
        }
   
    }
}
