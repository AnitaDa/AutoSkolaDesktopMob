using AutoSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Vozila
{
    public partial class frmDetaljiVozilo : Form
    {
        private int _VoziloId;
        private APIService _vozilo = new APIService("Vozila");
        public frmDetaljiVozilo(int VoziloId)
        {
            InitializeComponent();
            _VoziloId = VoziloId;
        }
        private async void frmDetaljiVozilo_Load(object sender, EventArgs e)
        {
            var vozilo =await _vozilo.GetById<MVozilo>(_VoziloId);
            lblKategorija.Text = vozilo.Kategorija;
            lblMarka.Text = vozilo.Marka;
            lblModel.Text = vozilo.Model;
            lblRegOznaka.Text = vozilo.RegistarskaOznaka;
            if(vozilo.Slika!=null)
                using (var ms = new MemoryStream(vozilo.Slika))
                {
                    //konvertuje byte u Image
                    pictureVozilo.Image = Image.FromStream(ms);
                }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmNovoVozilo detalji = new frmNovoVozilo(_VoziloId,this) ;
            detalji.Show();
        }
        public void Reload()
        {
            frmDetaljiVozilo_Load(this, EventArgs.Empty);
        }
    }
}
