using System;

namespace AutoSkola.Model
{
    public class MKandidat
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KorisnikId { get; set; }
        public bool Status { get; set; }
        public string OdabraniInstruktor { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string Opis { get; set; }
        public string Usluga { get; set; }
        public byte[] Slika { get; set; }

    }
}
