using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Uplata
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public string Svrha { get; set; }
        public DateTime DatumUplate { get; set; }
        public int KandidatId { get; set; }

        public virtual Kandidat Kandidat { get; set; }
    }
}
