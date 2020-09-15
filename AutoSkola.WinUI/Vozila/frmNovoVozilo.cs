using AutoSkola.Model;
using AutoSkola.Model.Requests;
using getFood_UI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Vozila
{
    public partial class frmNovoVozilo : Form
    {
        private APIService _kategorije = new APIService("Kategorije");
        private APIService _model = new APIService("Model");
        private APIService _vozilo = new APIService("Vozila");
        private int? _Id;
        private byte[] _Slika;
        private bool IzmjenaSlike=false;
        private OpenFileDialog dialog;
#pragma warning disable CS0108 // 'frmNovoVozilo.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaVozila Parent;
#pragma warning restore CS0108 // 'frmNovoVozilo.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        private frmDetaljiVozilo _Detalji;
        public frmNovoVozilo(int? Id,frmDetaljiVozilo detalji)
        {
            InitializeComponent();
            _Id = Id;
            _Detalji = detalji;
        }
        
        private async void frmNovoVozilo_Load(object sender, EventArgs e)
        {
            //combo box kategorije
            var kategorije =await _kategorije.Get<List<MKategorije>>(null);
            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "Id";
            //combo box model
            var model =await _model.Get<List<MModel>>(null);
            cbModel.DataSource = model;
            cbModel.DisplayMember = "Naziv";
            cbModel.ValueMember = "Id";
            if (_Id.HasValue)
            {
                var vozilo = await _vozilo.GetById<MVozilo>(_Id);
                txtRegOznaka.Text = vozilo.RegistarskaOznaka;
                if (vozilo.Slika != null)
                    using (var ms = new MemoryStream(vozilo.Slika))
                    {
                        pictureVozilo.Image = Image.FromStream(ms);
                    }
                _Slika = vozilo.Slika;
                cbKategorija.SelectedValue = int.Parse(vozilo.KategorijaId.ToString());
                cbModel.SelectedValue = int.Parse(vozilo.ModelId.ToString());
            }
        }
        VoziloUpsertRequest upsert = new VoziloUpsertRequest();
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidairajPolja())
            {
                var kategorijaId = cbKategorija.SelectedValue;
                var modelId = cbModel.SelectedValue;

                if (int.TryParse(kategorijaId.ToString(), out int KatId))
                {
                    upsert.KategorijaId = KatId;
                }
                if (int.TryParse(modelId.ToString(), out int ModId))
                {
                    upsert.ModelId = ModId;
                }
                upsert.Id = _Id;

                upsert.RegistarskaOznaka = txtRegOznaka.Text;
                

                if (_Id.HasValue)
                {
                    //ukoliko korisnik nije odabrao novu sliku, ostaje stara
                    if (!IzmjenaSlike)
                    {
                        upsert.Slika = _Slika;
                    }

                    var stream = dialog.OpenFile();
                    using (stream)
                    {
                        upsert.Slika= File.ReadAllBytes(dialog.FileName);
                    }




                    var vozilo = await _vozilo.Update<MVozilo>(_Id, upsert);
                    if (vozilo != null)
                    {
                        MessageBox.Show("Vozilo uspjesno izmijenjeno!");
                        this.Close();
                        _Detalji.Reload();
                    }
                }
                else
                {
                    var stream = dialog.OpenFile();
                    using (stream)
                    {
                        upsert.Slika = File.ReadAllBytes(dialog.FileName);
                    }
                    var vozilo = await _vozilo.Insert<MVozilo>(upsert);
                    if (vozilo != null)
                    {
                        MessageBox.Show("Vozilo uspjesno dodano!");
                        this.Close();
                        Parent.Reload();
                    }
                }
            }
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {   
             dialog = ofdNovoVozilo;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    if (dialog.OpenFile() != null)
                    {
                        txtFileName.Text = dialog.SafeFileName;
                        Stream file = dialog.OpenFile();
                        using (file)
                        {
                            pictureVozilo.Image = Image.FromStream(file);
                        }
                    }
                }
                catch (Exception) { }
            }
            else { return; }
        }
      

        public bool ValidairajPolja()
        {
            GRegOznaka.Visible = false;
            if (string.IsNullOrEmpty(txtRegOznaka.Text))
            {
                GRegOznaka.Visible = true;
                return false;
            }
            return true;
        }
    }
}
