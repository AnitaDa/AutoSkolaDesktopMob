using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.Routing.Internal;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WinUI.Raspored_casova;
using AutoSkola.WinUI.Raspored_polaganja.TerminiRasporedaPolaganja;

namespace AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja
{
    public partial class RowTerminRasporedPolaganja : UserControl
    {
        private string _Kandidat;
        private string _Od;
        private string _Do;
        private int _terminRPId;
        private Panel _flpRasporedPolaganja;
#pragma warning disable CS0108 // 'RowTerminRasporedPolaganja.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public  frmTerminRasporedaPolaganja Parent;
#pragma warning restore CS0108 // 'RowTerminRasporedPolaganja.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        private APIService _terminRP = new APIService("TerminRasporedaPolaganja");
        public RowTerminRasporedPolaganja(Panel flpRasporedPolganja)
        {
            InitializeComponent();
            _flpRasporedPolaganja = flpRasporedPolganja;
        }
        public string Kandidat
        {
            get { return _Kandidat; }
            set { _Kandidat = value;lblKandidat.Text = value; }
        }
        public string Od
        {
            get { return _Od; }
            set { _Od = value; lblOd.Text = value; }
        }
        public string Do
        {
            get { return _Do; }
            set { _Do = value; lblDo.Text = value; }
        }
        public int TerminRPId
        {
            get { return _terminRPId; }
            set { _terminRPId = value; }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var uspjesnoObrisan = await _terminRP.Delete(_terminRPId);
            if (uspjesnoObrisan)
            {
                MessageBox.Show("Termin uspješno obrisan!");
                Parent.Reload();
            }
        }

        private  void btnIzmjeni_Click(object sender, EventArgs e)
        {
            frmNoviTerminPolaganje termin = new frmNoviTerminPolaganje(null, TerminRPId) { Parent = Parent };
            termin.Show();
            
        }
    }
}
