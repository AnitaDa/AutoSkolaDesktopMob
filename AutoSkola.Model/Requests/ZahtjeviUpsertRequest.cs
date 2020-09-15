using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class ZahtjeviUpsertRequest
    {
        public int? Id { get; set; }
        public bool Odobren { get; set; }
        public bool Odbacen { get; set; }
        public int LjekarskoUvjerenjeId { get; set; }
        public int UposlenikId { get; set; }
        public int UslugaId { get; set; }
        public DateTime DatumPodnosenjaZahtjeva { get; set; }
    }
}
