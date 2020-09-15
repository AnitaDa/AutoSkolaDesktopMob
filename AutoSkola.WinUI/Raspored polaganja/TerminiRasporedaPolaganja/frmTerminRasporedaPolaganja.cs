using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.Raspored_polaganja.TerminiRasporedaPolaganja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja
{
    public partial class frmTerminRasporedaPolaganja : Form
    {
        private APIService _terminiRasporedPolaganja = new APIService("TerminRasporedaPolaganja");
        private int _rasporedPolaganjaId;
    
        public frmTerminRasporedaPolaganja(int rasporedPolaganjaId)
        {
            InitializeComponent();
            _rasporedPolaganjaId = rasporedPolaganjaId;
        }

        private async void frmTerminRasporedaPolaganja_Load(object sender, EventArgs e)
        {
            
            var search = new TerminRPSearchRequest() {
                RasporedPolaganjaId = _rasporedPolaganjaId
            };
            var termini =await _terminiRasporedPolaganja.Get<List<MTerminRasporedaPolaganja>>(search);
            FormirajTabelu(termini);

        }
        public void FormirajTabelu(List<MTerminRasporedaPolaganja> termini)
        {
            flpTerminiRasporedaPolaganja.Controls.Clear();
            flpTerminiRasporedaPolaganja.Controls.Add(new HeaderTerminRasporedPolaganja());
            RowTerminRasporedPolaganja[] listaTermina =new RowTerminRasporedPolaganja[termini.Count()];
            for(int i = 0; i < termini.Count(); i++)
            {
                listaTermina[i] = new RowTerminRasporedPolaganja(flpTerminiRasporedaPolaganja) {Parent=this};
                listaTermina[i].TerminRPId = termini[i].Id;
                listaTermina[i].Kandidat = termini[i].Kandidat;
                listaTermina[i].Od = termini[i].Od;
                listaTermina[i].Do = termini[i].Do;
                flpTerminiRasporedaPolaganja.Controls.Add(listaTermina[i]);
              
            }
        }

        private void btnNoviTermin_Click(object sender, EventArgs e)
        {
            frmNoviTerminPolaganje noviTermin = new frmNoviTerminPolaganje(_rasporedPolaganjaId) {Parent=this };
            noviTermin.Show();
           
        }
        public void Reload()
        {
            frmTerminRasporedaPolaganja_Load(this, EventArgs.Empty);
        }
    }
}
