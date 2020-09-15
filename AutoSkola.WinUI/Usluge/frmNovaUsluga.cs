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
using Ubiety.Dns.Core.Records.NotUsed;

namespace AutoSkola.WinUI.Usluge
{
    public partial class frmNovaUsluga : Form
    {
        private APIService _kategorije = new APIService("Kategorije");
        private APIService _usluge = new APIService("Usluge");
        private int? _Id;
        public new frmListaUsluga Parent;
       
        public frmNovaUsluga(int? Id)
        {
            InitializeComponent();
            _Id = Id;
        }
        private async  void frmNovaUsluga_Load(object sender, EventArgs e)
        {
            var kategorije = await _kategorije.Get<List<MKategorije>>(null);
            kategorije.Insert(0, new MKategorije { Naziv = "Odaberite kategoriju" });
            cbKategorija.DataSource = kategorije;
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "Id";
            if (_Id != null)
            {
                var trenutniPodaci = await _usluge.GetById<MUsluge>(_Id);
                txtNaziv.Text = trenutniPodaci.Naziv;
                nCijena.Value = (decimal)trenutniPodaci.Cijena;
                rtOpis.Text = trenutniPodaci.Opis;
                cbKategorija.SelectedValue = int.Parse(trenutniPodaci.KategorijaId.ToString());
            }
         
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPolje()) { 
            var kategorijaId = cbKategorija.SelectedValue;
            
                var upsert = new UslugaUpsertRequest();
                if (int.TryParse(kategorijaId.ToString(), out int Id))
                {
                upsert.KategorijaId = Id;
                }
            upsert.Naziv = txtNaziv.Text;
            upsert.Cijena = (float)nCijena.Value;
            upsert.Opis = rtOpis.Text;

                if (_Id != null)
                {
                    upsert.Id = _Id;
                    var izmjenjenaUsluga = await _usluge.Update<MUsluge>(_Id, upsert);
                    if (izmjenjenaUsluga != null)
                    {
                        MessageBox.Show("Uspješno izmjenjena usluga!");
                        this.Close();
                        Parent.Reload();
                    }
                }
                else
                {
                    var novaUsluga = await _usluge.Insert<MUsluge>(upsert);
                    if (novaUsluga != null)
                    {
                        MessageBox.Show("Uspješno dodana usluga!");
                        this.Close();
                        Parent.Reload();
                    }
                }
            }
        }
        private bool ValidirajPolje()
        {
            bool rezultat = true;
            GNaziv.Visible = false;
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                GNaziv.Visible = true;
                rezultat = false;
            }
            GCijena.Visible = false;
            if (nCijena.Value == 0)
            {
                GCijena.Visible = true;
                rezultat = false;
            }
            GKategorija.Visible = false;
            if((int.TryParse(cbKategorija.SelectedValue.ToString(),out int Id))){
                if (Id == 0)
                {
                    GKategorija.Visible = true;
                    rezultat = false;
                }
            }
            return rezultat;
        }
      
    }
}
