using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Usluge
{
    public partial class frmListaUsluga : Form
    {
        private APIService _usluge = new APIService("Usluge");
        private APIService _kategorije = new APIService("Kategorije");

        public frmListaUsluga()
        {
            InitializeComponent();
        }

        private async void frmListaUsluga_Load(object sender, EventArgs e)
        {
            
            var kategorije = await _kategorije.Get<List<MKategorije>>(null);
            kategorije.Insert(0, new MKategorije());
            cbKategorije.DataSource = kategorije;
            cbKategorije.DisplayMember = "Naziv";
            cbKategorije.ValueMember = "Id";
            var usluge = await _usluge.Get<List<MUsluge>>(null);
            FormirajTabelu(usluge);
        }
        private void FormirajTabelu(List<MUsluge>usluge) {
            flpUsluge.Controls.Clear();
            flpUsluge.Controls.Add(new HeaderUsluge());
            RowUsluge[] listaUsluga = new RowUsluge[usluge.Count()];
            for(int i = 0; i < usluge.Count(); i++)
            {
                listaUsluga[i] = new RowUsluge() { Parent = this };
                listaUsluga[i].UslugaId = usluge[i].Id;
                listaUsluga[i].Kategorija = usluge[i].Kategorija;
                listaUsluga[i].Naziv = usluge[i].Naziv;
                listaUsluga[i].Cijena = usluge[i].Cijena.ToString()+"KM";
                listaUsluga[i].Opis = usluge[i].Opis;
                flpUsluge.Controls.Add(listaUsluga[i]);
            }
        }

        private void btnNovaUsluga_Click(object sender, EventArgs e)
        {
            frmNovaUsluga novaUsluga = new frmNovaUsluga(null) { Parent=this};
            novaUsluga.Show();
        }

        private async void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var search = new UslugaSearchRequest();
            
            var kategorijaId = cbKategorije.SelectedValue;
            if(int.TryParse(kategorijaId.ToString(),out int Id))
            {
                search.KategorijaId = Id;
            }
            var usluge = await _usluge.Get<List<MUsluge>>(search);
            FormirajTabelu(usluge);
        }

        private void cbKategorije_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        public void Reload()
        {
            frmListaUsluga_Load(this, EventArgs.Empty);
        }

       
    }
}
