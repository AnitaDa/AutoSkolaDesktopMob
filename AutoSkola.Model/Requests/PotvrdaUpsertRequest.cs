using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class PotvrdaUpsertRequest
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int KandidatId { get; set; }
        public int KategorijaId { get; set; }
        public int UposlenikId { get; set; }
    }
}
