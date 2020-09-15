using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MLjekarskoUvjerenje
    {
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string Opis { get; set; }
        public string Kandidat { get; set; }
        public int KandidatId { get; set; }
        public bool SposobanZaObuku { get; set; }
    }
}
