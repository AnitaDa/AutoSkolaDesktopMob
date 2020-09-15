using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoSkola.WinUI.Vozila
{
    public partial class Vozilo : UserControl
    {
        private byte[] _Slika;
        private int _VoziloId;
        private string _RegOznaka;
        private Panel _pnlPocetna;
#pragma warning disable CS0108 // 'Vozilo.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaVozila Parent;
#pragma warning restore CS0108 // 'Vozilo.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        private APIService _vozilo = new APIService("Vozila");
        public Vozilo(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }
        public byte[] Slika
        {
            get { return _Slika; }
            set {               
                _Slika = value;
                using (var ms = new MemoryStream(value))
                {
                    pictureVozilo.Image = Image.FromStream(ms);
                }
            }
        }
        public int VoziloId
        {
            get { return _VoziloId; }
            set { _VoziloId = value; }
        }
        public string RegOznaka
        {
            get { return _RegOznaka; }
            set { _RegOznaka = value;lblRegOznaka.Text = value; }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmDetaljiVozilo(_VoziloId), _pnlPocetna);
        }
        private void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true)

        {
            if (Zatvori)
            {
                _pnlPocetna.Controls.Clear();
            }
            forma.TopLevel = false;//bez ovog ne bih mogla dodati formu u panel

            forma.FormBorderStyle = FormBorderStyle.None;

            forma.Dock = DockStyle.Fill;

            panel.Controls.Add(forma);

            panel.Tag = forma;//ne znam sta je

            forma.BringToFront();

            forma.Show();



        }

        private async  void btnObrisi_Click(object sender, EventArgs e)
        {
            var uspjesnoObrisan = await _vozilo.Delete(_VoziloId);
            if (uspjesnoObrisan)
            {
                MessageBox.Show("Vozilo uspješno obrisano!");
                Parent.Reload();
            }
        }
    }
}
