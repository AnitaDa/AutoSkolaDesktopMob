using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Zahtjevi
{
    public partial class ZahtjevPocetna : UserControl
    {
        private string _Kandidat;
        private string _Usluga;
        private int _ZahtjevId;
        private Panel pnlPocetna;
        private frmPocetna frmPocetna;
        public ZahtjevPocetna(frmPocetna frmPocetna, Panel pnlPocetna)
        {
            InitializeComponent();
            this.frmPocetna = frmPocetna;
            this.pnlPocetna = pnlPocetna;
        }
        public string Kandidat
        {
            get { return _Kandidat; }
            set { _Kandidat = value;lblKandidat.Text = value; }
        }
        public string Usluga
        {
            get { return _Usluga; }
            set { _Usluga = value; lblUsluga.Text = value; }
        }
        public int ZahtjevId
        {
            get { return _ZahtjevId; }
            set { _ZahtjevId = value; }
        }

        private void ZahtjevPocetna_Click(object sender, EventArgs e)
        {
            frmPocetna.OtvoriFormu(new frmZahtjevi(), pnlPocetna);
        }
    }
}
