using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class TeminRCUpsertRequest
    {
        public int? Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public DateTime Datum { get; set; }
        public int RasporedCasovaId { get; set; }
        public int VoziloId { get; set; }
        public int UposlenikId { get; set; }
        public bool Teorija { get; set; }
        public bool Prakticno { get; set; }
        public bool Status { get; set; }
    }
}
