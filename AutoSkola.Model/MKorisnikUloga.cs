using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AutoSkola.Model
{
    public class MKorisnikUloga
    {
        public int Id { get; set; }
        public int UlogaId { get; set; }
        public int KorisnikId { get; set; }
        // public MKorisnik Korisnik { get; set; }
        public string UlogaNaziv { get; set; }
        public MUloga Uloga { get; set; }
    }
}
