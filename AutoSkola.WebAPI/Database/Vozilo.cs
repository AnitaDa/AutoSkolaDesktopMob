using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Vozilo
    {
        public Vozilo()
        {
            TerminRasporedCasova = new HashSet<TerminRasporedCasova>();
        }

        public int Id { get; set; }
        public int KategorijaId { get; set; }
        public string RegistarskaOznaka { get; set; }
        public byte[] Slika { get; set; }
        public int ModelId { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<TerminRasporedCasova> TerminRasporedCasova { get; set; }
    }
}
