using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Drawing;

using System.Data;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
using AutoSkola.WinUI.Uplate;
using System.IO;

namespace AutoSkola.WinUI.UserControls

{

    public partial class ListaUplata : UserControl

    {
        public ListaUplata()

        {

            InitializeComponent();

        }

        private string _ImePreizme;

        private string _Datum;

        private string _Svrha;

        private string _Iznos;

        private byte[] _Slika;

        [Category("Custom props")]

        public string ImePrezime

        {
            get { return _ImePreizme; }

            set { _ImePreizme = value; lblImePrezime.Text = value; }
        }

        [Category("Custom props")]

        public string Datum

        {
            get { return _Datum; }

            set { _Datum = value; lblDatum.Text = value; }

        }

        [Category("Custom props")]

        public string Svrha

        {
            get { return _Svrha; }

            set { _Svrha = value; lblSvrha.Text = value; }
        }

        [Category("Custom props")]
        public string Iznos

        {
            get { return _Iznos; }

            set { _Iznos = value; lblIznos.Text = value; }
        }
        [Category("Custom props")]
        public byte[] Slika

        {
            get { return _Slika; }

            set { _Slika = value;
                using (var ms = new MemoryStream(value))
                {
                    SlikaKandidata.Image = Image.FromStream(ms);
                }
            }
        }
    }

}
