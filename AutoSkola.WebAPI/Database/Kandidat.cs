using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Kandidat
    {
        public Kandidat()
        {
            LjekarskoUvjerenje = new HashSet<LjekarskoUvjerenje>();
            Potvrda = new HashSet<Potvrda>();
            RasporedCasova = new HashSet<RasporedCasova>();
            TerminRasporedaPolaganja = new HashSet<TerminRasporedaPolaganja>();
            Uplata = new HashSet<Uplata>();
            Utisak = new HashSet<Utisak>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int KorisnikId { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<LjekarskoUvjerenje> LjekarskoUvjerenje { get; set; }
        public virtual ICollection<Potvrda> Potvrda { get; set; }
        public virtual ICollection<RasporedCasova> RasporedCasova { get; set; }
        public virtual ICollection<TerminRasporedaPolaganja> TerminRasporedaPolaganja { get; set; }
        public virtual ICollection<Uplata> Uplata { get; set; }
        public virtual ICollection<Utisak> Utisak { get; set; }

    }
}
