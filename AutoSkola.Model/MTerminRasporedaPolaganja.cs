using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
   public class MTerminRasporedaPolaganja
    {
        public int Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public string Kandidat { get; set; }
        public int KandidatId { get; set; }

        public int RasporedPolaganjaId { get; set; }
    }
}
