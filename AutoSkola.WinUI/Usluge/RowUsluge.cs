using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSkola.Model;

namespace AutoSkola.WinUI.Usluge
{
    public partial class RowUsluge : UserControl
    {
#pragma warning disable CS0108 // 'RowUsluge.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaUsluga Parent;
#pragma warning restore CS0108 // 'RowUsluge.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public RowUsluge()
        {
            InitializeComponent();
        }
        private string _Naziv;
        private string _Cijena;
        private string _Opis;
        private string _Kategorija;
        private int _UslugaId;
        private APIService _usluge = new APIService("Usluge");
        public string Naziv
        {
            get { return _Naziv; }
            set { _Naziv = value;lblNaziv.Text = value; }
        }
        public string Cijena
        {
            get { return _Cijena; }
            set { _Cijena = value; lblCijena.Text = value; }
        }
        public string Opis
        {
            get { return _Opis; }
            set { _Opis = value; lblOpis.Text = value; }
        }
        public string Kategorija
        {
            get { return _Kategorija; }
            set { _Kategorija = value; lblKategorija.Text = value; }
        }
        public int UslugaId
        {         
            get { return _UslugaId; }
            set { _UslugaId = value; }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var uspjesnoObrisana = await _usluge.Delete(_UslugaId);
            if (uspjesnoObrisana)
            {
                MessageBox.Show("Usluga uspješno obrisana!");
                Parent.Reload();
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            frmNovaUsluga izmjena = new frmNovaUsluga(_UslugaId) {Parent=Parent };
            izmjena.Show();
           
        }
    }
}
