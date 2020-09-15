using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class LjekarskoUvjerenjeUpsertRequest
    {
        public int Id { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string Opis { get; set; }
        public int KandidatId { get; set; }
        public bool SposobanZaObuku { get; set; }
    }
}
