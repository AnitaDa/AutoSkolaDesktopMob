using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Potvrde
{
    public partial class RowPotvrda : UserControl
    {
        private string _DatumPolaganja;
        private string _Kategorija;
        private string _PotvrduIzdao;
        private string _Kandidat;

        public RowPotvrda()
        {
            InitializeComponent();
        }
        public string DatumPolaganja {
            get { return _DatumPolaganja; }
            set { _DatumPolaganja = value;lblDatumPolaganja.Text = value; }
        }
        public string Kategorija
        {
            get { return _Kategorija; }
            set { _Kategorija = value; lblKategorija.Text = value; }
        }
        public string PotvduIzdao
        {
            get { return _PotvrduIzdao; }
            set { _PotvrduIzdao = value; lblPotvrduIzdao.Text = value; }
        }
        public string Kandidat
        {
            get { return _Kandidat; }
            set { _Kandidat = value; lblKandidat.Text = value; }
        }
    }
}
