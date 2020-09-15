using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Kategorija
    {
        public Kategorija()
        {
            Potvrda = new HashSet<Potvrda>();
            Usluga = new HashSet<Usluga>();
            Vozilo = new HashSet<Vozilo>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Potvrda> Potvrda { get; set; }
        public virtual ICollection<Usluga> Usluga { get; set; }
        public virtual ICollection<Vozilo> Vozilo { get; set; }
    }
}
