using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class TerminRasporedCasova
    {
        public int Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public DateTime Datum { get; set; }
        public int RasporedCasovaId { get; set; }
        public int UposlenikId { get; set; }
        public int VoziloId { get; set; }
        public bool Teorija { get; set; }
        public bool Prakticno { get; set; }
        public bool Status { get; set; }
       
        public virtual RasporedCasova RasporedCasova { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
