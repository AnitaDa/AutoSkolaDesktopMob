using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
   public class KandidatUpsertRequest
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int KorisnikId { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }
    }
}
