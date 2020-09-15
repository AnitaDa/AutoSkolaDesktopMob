using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Database
{
    public partial class Utisak
    {
        public int Id { get; set; }
        public decimal Ocjena { get; set; }
        public int KandidatId { get; set; }
        public int UposlenikId { get; set; }
        public Kandidat Kandidat { get; set; }
        public Uposlenik Uposlenik { get; set; }
    }
}
