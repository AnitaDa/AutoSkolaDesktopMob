using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MKorisnik
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public  ICollection<MKorisnikUloga> KorisnikUloga { get; set; }
    }
}
