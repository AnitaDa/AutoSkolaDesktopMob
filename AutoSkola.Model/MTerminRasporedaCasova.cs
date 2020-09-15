using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MTerminRasporedaCasova
    {
        public int Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public DateTime Datum { get; set; }
        public string Vozilo { get; set; }
        public int VoziloId { get; set; }
        public int KandidatId { get; set; }
        public int UposlenikId { get; set; }
        public int RasporedCasovaId { get; set; }
        public bool Teorija { get; set; }
        public bool Prakticno { get; set; }


    }
}
