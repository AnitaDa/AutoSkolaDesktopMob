using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Drawing;

using System.Data;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
using AutoSkola.WinUI.Kandidati;
using System.IO;

namespace AutoSkola.WinUI.UserControls

{

    public partial class ListaKandidata : UserControl

    {
        private Panel _pocetniPanel;
        public ListaKandidata(Panel pocetniPanel)

        {

            InitializeComponent();
            _pocetniPanel = pocetniPanel;
        }

        private string _Kandidat;
        private int _KandidatId;


        private byte[] _Slika;


        public int KandidatId
        {

            get { return _KandidatId; }

            set { _KandidatId = value; }

        }
        public string Kandidat
        {

            get { return _Kandidat; }

            set { _Kandidat = value; lblKandidat.Text = value; }

        }

        public byte[] Slika

        {

            get { return _Slika; }

            set { 
                _Slika = value;
                using (var ms = new MemoryStream(value))
                {
                    slikaKandidata.Image = Image.FromStream(ms);
                }             
            }

        }

        private void slikaKandidata_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmKandidatDetalji(KandidatId), _pocetniPanel);
        }
        private Form AktivnaForma = null;

        private void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true)

        {

            if (Zatvori == true)

            {

                if (AktivnaForma != null)

                    AktivnaForma.Close();

            }

            AktivnaForma = forma;

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