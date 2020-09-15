using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Database
{
    public class Kartica
    {
        public int Id { get; set; }
        public long BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
