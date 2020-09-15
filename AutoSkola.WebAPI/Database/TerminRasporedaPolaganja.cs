using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class TerminRasporedaPolaganja
    {
        public int Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public int RasporedPolaganjaId { get; set; }
        public int KandidatId { get; set; }

        public virtual Kandidat Kandidat { get; set; }
        public virtual RasporedPolaganja RasporedPolaganja { get; set; }
    }
}
