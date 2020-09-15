using AutoSkola.WinUI.Potvrde.Izvjestaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Potvrde
{
    public partial class frmNavBar : Form
    {
#pragma warning disable CS0108 // 'frmNavBar.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmListaPotvrda Parent;
#pragma warning restore CS0108 // 'frmNavBar.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        private Panel pnlPocetna;
        public frmNavBar(Panel pnlPocetna)
        {
            InitializeComponent();
            this.pnlPocetna = pnlPocetna;
        }

        private void novaPotvrdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaPotvrda potvrda = new frmNovaPotvrda() {Parent=Parent };
            potvrda.Show();
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmIzvjestajPotvrde(), pnlPocetna);
        }
        public void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true)

        {
            if (Zatvori == true)

            {
                pnlPocetna.Controls.Clear();
            }

            forma.TopLevel = false;//bez ovog ne bih mogla dodati formu u panel

            forma.FormBorderStyle = FormBorderStyle.None;

            forma.Dock = DockStyle.Fill;

            panel.Controls.Add(forma);

            panel.Tag = forma;//ne znam sta je

            forma.BringToFront();

            forma.Show();
        }
    }
}
