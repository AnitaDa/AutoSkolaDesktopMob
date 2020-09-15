using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Uposlenik
    {
        public Uposlenik()
        {
            Potvrda = new HashSet<Potvrda>();
            UposlenikTipUposlenika = new HashSet<UposlenikTipUposlenika>();
            Zahtjev = new HashSet<Zahtjev>();
            Utisak = new HashSet<Utisak>();
    }

    public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int KorisnikId { get; set; }
        public byte[] Slika { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Potvrda> Potvrda { get; set; }
        public virtual ICollection<UposlenikTipUposlenika> UposlenikTipUposlenika { get; set; }
        public virtual ICollection<TerminRasporedCasova> TerminRasporedCasova { get; set; }

        public virtual ICollection<Zahtjev> Zahtjev { get; set; }
        public virtual ICollection<Utisak> Utisak { get; set; }
    }
}
