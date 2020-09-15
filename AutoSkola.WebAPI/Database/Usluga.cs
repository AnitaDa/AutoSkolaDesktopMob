using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Usluga
    {
        public Usluga()
        {
            Zahtjev = new HashSet<Zahtjev>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public int KategorijaId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Zahtjev> Zahtjev { get; set; }
    }
}
