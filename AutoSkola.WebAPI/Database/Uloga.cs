using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUloga = new HashSet<KorisnikUloga>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string? Opis { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        public virtual ICollection<KorisnikUloga> KorisnikUloga { get; set; }
    }
}
