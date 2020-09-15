using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Database
{
    public class OdabranaUsluga
    {
        public int Id { get; set; }
        public int UslugaId { get; set; }
        public int UslugeProdavnicaId { get; set; }
        public Usluga Usluga { get; set; }
        public UslugeProdavnica UslugeProdavnica { get; set; }
    }
}
