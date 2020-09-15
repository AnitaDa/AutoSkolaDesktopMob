using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Potvrda
    {
        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public int KandidatId { get; set; }
        public int KategorijaId { get; set; }
        public int UposlenikId { get; set; }
        public virtual Kandidat Kandidat { get; set; }
        public virtual Kategorija Kategorija { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
    }
}
