using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSkola.WinUI.Raspored_polganja.TerminiRasporedaPolaganja;
using System.Security.Permissions;
#pragma warning disable
namespace AutoSkola.WinUI.Raspored_polganja
{
    public partial class RowRasporedPolanja : UserControl
    {
        private Panel _pnlPocetna;
        public frmRasporedPolaganja Parent;
        public RowRasporedPolanja(Panel pnlPocetna)
        {
            InitializeComponent();
            _pnlPocetna = pnlPocetna;
        }
        private string _DatumPolaganja;
        private int _RasporedPolaganjaId;
        public string DatumPolaganja
        {
            get { return _DatumPolaganja; }
            set { _DatumPolaganja = value;lblDatumPolaganja.Text = value; }
        }
        public int RasporedPolaganjaId
        {
            get { return _RasporedPolaganjaId; }
            set { _RasporedPolaganjaId = value; }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmTerminRasporedaPolaganja(_RasporedPolaganjaId) { Parent = Parent }, _pnlPocetna);
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
