using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MZahtjevi
    {
        public int Id { get; set; }
        public int UslugaId { get; set; }
        public int UposlenikId { get; set; }
        public string Instruktor { get; set; }
        public string Usluga { get; set; }
        public string OpisUsluge { get; set; }
        public string Kategorija { get; set; }
        public int LjekarskoUvjerenjeId { get; set; }
        public string Kandidat { get; set; }
        public bool Odobren { get; set; }
        public bool Odbacen { get; set; }
        public DateTime DatumPodnosenja { get; set; }
    }
}
