using AutoSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Kandidati
{
    public partial class frmKandidatDetalji : Form
    {
        private APIService _kandidati = new APIService("Kandidati");
        private int KandidatId;
        public frmKandidatDetalji(int Id)
        {
            InitializeComponent();
            KandidatId = Id;

        }

        private async void frmKandidatDetalji_Load(object sender, EventArgs e)
        {

            var kandidat = await _kandidati.GetById<MKandidat>(KandidatId);
            if (kandidat != null)
            {
                txtImePrezime.Text = kandidat.ImePrezime;
                txtDatumRodjenja.Text = kandidat.DatumRodjenja.ToString("dd/MMMM/yyyy");
                txtDatumIzdavanja.Text = kandidat.DatumIzdavanja.ToString("dd/MMMM/yyyy");
                txtDatumVazenja.Text = kandidat.DatumVazenja.ToString("dd/MMMM/yyyy");
                txtUsluga.Text = kandidat.Usluga;
                txtInstruktor.Text = kandidat.OdabraniInstruktor;
                if (kandidat.Slika != null)
                    using (var ms = new MemoryStream(kandidat.Slika))
                    {
                        //konvertuje byte u Image
                        imgKandidat.Image = Image.FromStream(ms);
                    }
            }
            else
            {
                MessageBox.Show("Kandidat nije pronadjen!");

            }
        }
    }
}
