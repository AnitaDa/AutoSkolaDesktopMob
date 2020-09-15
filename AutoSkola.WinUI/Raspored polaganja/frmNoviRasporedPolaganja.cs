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
#pragma warning disable
namespace AutoSkola.WinUI.Raspored_polganja
{
    public partial class frmNoviRasporedPolaganja : Form
    {
        
        private APIService _polaganje = new APIService("RasporedPolaganja");
        public frmRasporedPolaganja Parent;
        public frmNoviRasporedPolaganja()
        {
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var insert = new RasporedPolaganjaUpsertRequest()
            {
                DatumPolaganja = dtpDatumPolaganja.Value
            };
            var polaganje=await _polaganje.Insert<MRasporedPolaganja>(insert);
            if (polaganje != null)
            {
                MessageBox.Show("Polaganje uspjesno dodano!");
                this.Close();
                Parent.Reload();
            }
        }
    }
}
