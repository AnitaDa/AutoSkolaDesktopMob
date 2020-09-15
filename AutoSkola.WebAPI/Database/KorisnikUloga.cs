using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class KorisnikUloga
    {
        public int Id { get; set; }
        public int UlogaId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
