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

namespace AutoSkola.WinUI.Uposlenici
{
    public partial class frmDetaljiUposlenika : Form
    {
        private APIService _uposlenici = new APIService("Uposlenici");
        private int _Id;

        public frmDetaljiUposlenika(int Id)
        {
            InitializeComponent();
            _Id = Id;
        }

        private async void frmDetaljiUposlenika_Load(object sender, EventArgs e)
        {
            var uposlenik = await _uposlenici.GetById<MUposlenik>(_Id);
            lblDatumRodjenja.Text = uposlenik.DatumRodjenja.ToString("dd/MMMM/yyyy");
            lblImePrezime.Text = uposlenik.ImePrezime;
            if(uposlenik.Slika!=null)
                using (var ms = new MemoryStream(uposlenik.Slika))
                {
                    //konvertuje byte u Image
                    pictureUposlenik.Image = Image.FromStream(ms);
                }
            lblVrstaPosla.Text = uposlenik.TipUposlenika;
        }
    }
}
