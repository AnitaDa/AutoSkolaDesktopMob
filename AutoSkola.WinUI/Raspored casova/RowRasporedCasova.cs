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
using AutoSkola.WinUI.Raspored_casova;
using AutoSkola.Model.Requests;

namespace AutoSkola.WinUI.UserControls

{

    public partial class RowRasporedCasova : UserControl

    {
        private APIService _termni = new APIService("TerminRasporedaCasova");
#pragma warning disable CS0108 // 'RowRasporedCasova.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
        public ListaKandidataZaRaspored Parent;
#pragma warning restore CS0108 // 'RowRasporedCasova.Parent' hides inherited member 'Control.Parent'. Use the new keyword if hiding was intended.
       
        public  RowRasporedCasova()

        {
            InitializeComponent();
            if (APIService.UlogaNaziv == "Instruktor")
            {
               
                btnIzmjeni.Visible = false;
                btnEvidentiraj.Visible = true;
            }
        }

        private string _Datum;

        private string _Od;
        private int _Id;
        private string _Do;
        private string _Vozilo;
        public int Id

        {

            get { return _Id; }

            set { _Id = value;}
        }
        public string Datum

        {

            get { return _Datum; }

            set { _Datum = value; lblDatum.Text = value; }
        }

        public string Od

        {

            get { return _Od; }

            set { _Od = value; lblOd.Text = value; }



        }

        public string Do

        {

            get { return _Do; }

            set { _Do = value; lblDo.Text = value; }



        }
        public string Vozilo

        {
            get { return _Vozilo; }

            set { _Vozilo = value; lblVozilo.Text = value; }
        }
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        private async void btnIzmjeni_Click(object sender, EventArgs e)
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {
           
            frmNoviTermin terminRC = new frmNoviTermin(_Id) {Parent=Parent };
            terminRC.Show();
        }

        private async void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            var termin = await _termni.GetById<MTerminRasporedaCasova>(_Id);
            var upsert = new TeminRCUpsertRequest()
            {
                Id=_Id,
                Status = true,
                Do=termin.Do,
                Od=termin.Od,
                Datum=termin.Datum,
                RasporedCasovaId=termin.RasporedCasovaId,
                UposlenikId=termin.UposlenikId,
                VoziloId=termin.VoziloId,
                Teorija=termin.Teorija,
                Prakticno=termin.Prakticno
            };
            var izmjenjenTermin=await _termni.Update<MTerminRasporedaCasova>(_Id,upsert);
            if (izmjenjenTermin!=null)
            {
                MessageBox.Show("Termin uspjesno evidentiran!");
                btnEvidentiraj.BackColor = Color.Green;
                
            }
     
        }
    }

}