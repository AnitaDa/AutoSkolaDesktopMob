using AutoSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Kategorije
{
    public partial class frmListaKategorija : Form
    {
        private APIService _kategorije = new APIService("Kategorije");
        public Panel _pnlPocetna;
        public frmListaKategorija(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }

        private async void frmListaKategorija_Load(object sender, EventArgs e)
        {
            var kategorije = await _kategorije.Get<List<MKategorije>>(null);
            FormirajTabelu(kategorije);
        }
        private void FormirajTabelu(List<MKategorije> kategorije)
        {
            flpKategorije.Controls.Clear();
            flpKategorije.Controls.Add(new HeaderKategorija());
            RowKategorije[] listaKategorija = new RowKategorije[kategorije.Count()];
            for (int i = 0; i < kategorije.Count(); i++)
            {
                listaKategorija[i] = new RowKategorije() { Parent=this};
                listaKategorija[i].Dock = DockStyle.Top;
                listaKategorija[i].KategorijaId = kategorije[i].Id;
                listaKategorija[i].Naziv = kategorije[i].Naziv;
                listaKategorija[i].Opis = kategorije[i].Opis;
                
                flpKategorije.Controls.Add(listaKategorija[i]);
            }
        }

        private void btnNovaKategorija_Click(object sender, EventArgs e)
        {
            frmNovaKategorija novaKategorija = new frmNovaKategorija(null) {Parent=this };
            novaKategorija.Show();
        }
        public void Reload()
        {
            frmListaKategorija_Load(this, EventArgs.Empty);
        }
    }
}
