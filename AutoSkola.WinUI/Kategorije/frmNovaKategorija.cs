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
using System.Xml.Linq;

namespace AutoSkola.WinUI.Kategorije
{
    public partial class frmNovaKategorija : Form
    {
        private APIService _kategorije = new APIService("Kategorije");
        private int? _Id;
#pragma warning disable CS0108 // 'frmNovaKategorija.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaKategorija Parent;
#pragma warning restore CS0108 // 'frmNovaKategorija.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNovaKategorija(int? Id)
        {
            InitializeComponent();
            _Id = Id;
        }
        private async void frmNovaKategorija_Load(object sender, EventArgs e)
        {
            if (_Id.HasValue)
            {
                var kategorija = await _kategorije.GetById<MKategorije>(_Id);
                txtNaziv.Text = kategorija.Naziv;
                rtOpis.Text = kategorija.Opis;
            }
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajPolja())
            {
                var upsert = new KategorijeUpsertRequest()
                {
                    Id = _Id,
                    Naziv = txtNaziv.Text,
                    Opis = rtOpis.Text
                };

                if (_Id.HasValue)
                {
                    var t = await _kategorije.Update<MKategorije>(_Id, upsert);
                    if (t != null)
                    {
                        MessageBox.Show("Kategorija uspjesno izmjenjena!");
                        this.Close();
                        Parent.Reload();
                    }
                }
                else
                {
                    var t = await _kategorije.Insert<MKategorije>(upsert);
                    if (t != null)
                    {
                        MessageBox.Show("Kategorija uspjesno dodana!");
                        this.Close();
                        Parent.Reload();
                    }
                }
            }
           
        }
        private bool ValidirajPolja()
        {
            Poruka.Visible = false;
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                Poruka.Visible = true;
                return false;
            }
            return true;
        }
    }
}
