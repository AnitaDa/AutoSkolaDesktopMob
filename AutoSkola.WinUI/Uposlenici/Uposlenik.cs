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

namespace AutoSkola.WinUI.Uposlenici
{
    public partial class Uposlenik : UserControl
    {
        private byte[] _Slika;
        private string _ImePrezime;
        private int _uposlenikId;
        private Panel _pnlPocetna;
        public Uposlenik(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }
        public byte[] Slika
        {
            get { return _Slika; }
            set { _Slika = value;
                using (var ms = new MemoryStream(value))
                {
                    pictureUposlenik.Image = Image.FromStream(ms);
                }
            }
        }
        public string ImePrezime
        {
            get { return _ImePrezime; }
            set { _ImePrezime = value; lblImePrezime.Text = value; }
        }
        public int UposlenikId
        {
            get { return _uposlenikId; }
            set { _uposlenikId = value; }
        }

        private void pictureUposlenik_Click(object sender, EventArgs e)
        {
           OtvoriFormu(new frmDetaljiUposlenika(_uposlenikId),_pnlPocetna);
        }
        private void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true)

        {
            if (Zatvori == true)

            {
                _pnlPocetna.Controls.Clear();
            }

            forma.TopLevel = false;//bez ovog ne bi mogao dodati formu u panel

            forma.FormBorderStyle = FormBorderStyle.None;

            forma.Dock = DockStyle.Fill;

            panel.Controls.Add(forma);

            panel.Tag = forma;//ne znam sta je

            forma.BringToFront();

            forma.Show();



        }
    }
}
