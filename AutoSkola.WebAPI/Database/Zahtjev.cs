using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Zahtjev
    {
        public int Id { get; set; }
        public DateTime DatumPodnosenjaZahtjeva { get; set; }
        public int LjekarskoUvjerenjeId { get; set; }
        public int UposlenikId { get; set; }
        public int UslugaId { get; set; }
        public bool Odobren { get; set; }
        public bool Odbacen { get; set; }
       

        public virtual LjekarskoUvjerenje LjekarskoUvjerenje { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
        public virtual Usluga Usluga { get; set; }
    }
}
