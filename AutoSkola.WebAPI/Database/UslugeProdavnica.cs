using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Database
{
    public class UslugeProdavnica
    {
        public int Id { get; set; }
        public int KandidatId { get; set; }
        public DateTime Datum { get; set; }
        public Kandidat Kandidat { get; set; }
        public ICollection<OdabranaUsluga> OdabraneUsluge { get; set; }
    }
}
