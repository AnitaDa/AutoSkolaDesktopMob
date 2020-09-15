using AutoSkola.Model;
using AutoSkola.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Raspored_polganja
{
    public partial class frmRasporedPolaganja : Form
    {
        private Panel _pnlPocetna;
        public frmRasporedPolaganja(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }
        private APIService _rasporedPolaganja = new APIService("RasporedPolaganja");
        private async void frmRasporedPolaganja_Load(object sender, EventArgs e)
        {
            dtpDatumPolaganja.CustomFormat = " ";
            dtpDatumPolaganja.Format = DateTimePickerFormat.Custom;
            var result =await _rasporedPolaganja.Get<List<MRasporedPolaganja>>(null);
            FormirajTabelu(result);
        }
        public void FormirajTabelu(List<MRasporedPolaganja> raspored)
        {
            flpRasporedPolaganja.Controls.Clear();
            flpRasporedPolaganja.Controls.Add(new HeaderRasporedPolaganja());
            RowRasporedPolanja[] listaRasporeda = new RowRasporedPolanja[raspored.Count()];
            for(int i = 0; i < raspored.Count(); i++)
            {
                listaRasporeda[i] = new RowRasporedPolanja(_pnlPocetna);
                listaRasporeda[i].RasporedPolaganjaId = raspored[i].Id;
                listaRasporeda[i].DatumPolaganja = raspored[i].DatumPolaganja.ToString("dd/MMMM/yyyy");
                flpRasporedPolaganja.Controls.Add(listaRasporeda[i]);
            }
        }

        private void btnNoviRaspored_Click(object sender, EventArgs e)
        {
            frmNoviRasporedPolaganja polaganje = new frmNoviRasporedPolaganja() {Parent=this };
            polaganje.Show();
        }

        private async void dtpDatumPolaganja_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumPolaganja.CustomFormat = "dd/MM/yyyy";
            var search = new RasporedPolaganjaSearchRequest()
            {
                DatumPolaganja=dtpDatumPolaganja.Value
            };
            var result = await _rasporedPolaganja.Get<List<MRasporedPolaganja>>(search);
            FormirajTabelu(result);
        }

        private async void dtpDatumPolaganja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtpDatumPolaganja.CustomFormat = " ";
                dtpDatumPolaganja.Format = DateTimePickerFormat.Custom;
         
                var result = await _rasporedPolaganja.Get<List<MRasporedPolaganja>>(null);
                FormirajTabelu(result);
            }
        }
        public virtual void  Reload()
        {
            frmRasporedPolaganja_Load(this, EventArgs.Empty);
        }
    }
}
