using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Drawing;

using System.Data;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using AutoSkola.Model;

using AutoSkola.WinUI.UserControls;

using AutoSkola.Model.Requests;
using System.Drawing.Printing;

namespace AutoSkola.WinUI.Raspored_casova

{

    public partial class ListaKandidataZaRaspored : UserControl

    {

        private readonly APIService _terminRasporeda = new APIService("TerminRasporedaCasova");
        private DateTimePicker _dtpDatumTermina;
        private FlowLayoutPanel _flpRasporedCasova;
        public ListaKandidataZaRaspored(FlowLayoutPanel flpRasporedCasova,DateTimePicker dtpDatumTermina)

        {
            InitializeComponent();
            _flpRasporedCasova = flpRasporedCasova;
            _dtpDatumTermina = dtpDatumTermina;
        }

        private string _Kandidat;

        private int _KandidatId;

        [Category("Custom props")]

        public string Kandidat

        {

            get { return _Kandidat; }

            set { _Kandidat = value; btnKandidat.Text = value; }

        }

        public int KandidatId

        {

            get { return _KandidatId; }

            set { _KandidatId = value; }

        }



        private async void btnKandidat_Click(object sender, EventArgs e)

        {

            _flpRasporedCasova.Controls.Clear();

            var search = new TerminRCSearchRequest
            {
                KandidatId =KandidatId,
                Datum=_dtpDatumTermina.Value
            };

            _flpRasporedCasova.Controls.Add(new HeaderRasporedCasova());

            //trazenje rasporeda za kandidata koji je odabran

            var termini = await _terminRasporeda.Get<List<MTerminRasporedaCasova>>(search);
          
            FormirajTabelu(termini);

        }



        private void FormirajTabelu(List<MTerminRasporedaCasova> termini)

        {
            
            int brojTermina = termini.Count();

            RowRasporedCasova[] row = new RowRasporedCasova[brojTermina];

            for (int i = 0; i < brojTermina; i++)

            {

                row[i] = new RowRasporedCasova() {Parent=this };
                row[i].Id = termini[i].Id;
                row[i].Datum = termini[i].Datum.ToString("dd/MMMM/yyyy");

                row[i].Od = termini[i].Od;

                row[i].Do = termini[i].Do;
                row[i].Vozilo = termini[i].Vozilo;
                
                _flpRasporedCasova.Controls.Add(row[i]);

            }

        }
        public  void Reload()
        {
            btnKandidat_Click(this, EventArgs.Empty);
        }
    }

}