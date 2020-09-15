
using AutoSkola.WinUI.Uplate.Izvjestaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSkola.WinUI.Uplate
{
    public partial class frmNavBarUplat : Form
    {
        private Panel PomocniPanel;
        public Panel PocetniPanel;
#pragma warning disable CS0108 // 'frmNavBarUplat.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmUplate Parent;
#pragma warning restore CS0108 // 'frmNavBarUplat.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public frmNavBarUplat(Panel pnlPomoc, Panel pnlPocetna)
        {
            InitializeComponent();
            PomocniPanel = pnlPomoc;
            PocetniPanel = pnlPocetna;
        }

        private void novaUplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaUplata novaUplata = new frmNovaUplata() {Parent=Parent};
            novaUplata.Show();
        }

        private void izvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtvoriFormu(new frmUplateIzvjestajj(), PocetniPanel);
        }
      

        private void OtvoriFormu(Form forma, Panel panel, bool Zatvori = true)

        {
            if (Zatvori == true)

            {
                PocetniPanel.Controls.Clear();
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
