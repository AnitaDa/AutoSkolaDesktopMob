using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool? Status { get; set; }

        public virtual Kandidat Kandidat { get; set; }
        public virtual Kartica Kartica { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUloga { get; set; }
    }
}
