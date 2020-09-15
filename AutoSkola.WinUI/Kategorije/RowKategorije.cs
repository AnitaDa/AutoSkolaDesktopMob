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

namespace AutoSkola.WinUI.Kategorije
{
    public partial class RowKategorije : UserControl
    {
        private string _Naziv;
        private string _Opis;
        private int _KategorijaId;
        private APIService _kategorije = new APIService("Kategorije");
       
#pragma warning disable CS0108 // 'RowKategorije.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaKategorija Parent;
#pragma warning restore CS0108 // 'RowKategorije.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public RowKategorije()
        {
            InitializeComponent();
        }
        public string Naziv
        {
            get { return _Naziv; }
            set { _Naziv = value; lblNaziv.Text = value; }
        }
        public string Opis
        {
            get { return _Opis; }
            set { _Opis = value;lblOpis.Text = value; }
        }
        public int KategorijaId
        {
            get { return _KategorijaId; }
            set { _KategorijaId = value;  }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            //jel ovo to jes, vidis da sam pokusavala
            //al ne uspeva
            
           bool jel = await _kategorije.Delete(KategorijaId);
            if (jel)
            {
                MessageBox.Show("Kategorija uspjesno obrisana!");
                Parent.Reload();
            }
            else
                MessageBox.Show("Greska!", "Kategorija se koristi u drugim podacima, nije moguce obrisati");
           
           
        }

        private  void btnIzmjeni_Click(object sender, EventArgs e)
        {
           var kategorija=new frmNovaKategorija(_KategorijaId) {Parent=Parent};
            kategorija.Show();
           
        }
      
       
    }
}
