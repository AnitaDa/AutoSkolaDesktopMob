using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class LjekarskoUvjerenje
    {
        public LjekarskoUvjerenje()
        {
            Zahtjev = new HashSet<Zahtjev>();
        }

        public int Id { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string Opis { get; set; }
        public int KandidatId { get; set; }
        public bool SposobanZaObuku { get; set; }

        public virtual Kandidat Kandidat { get; set; }
        public virtual ICollection<Zahtjev> Zahtjev { get; set; }
    }
}
