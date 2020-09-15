using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
   public class KandidatSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int KorisnikId { get; set; }
        public bool PrikazUXamarinu { get; set; }
        public override string ToString()
        {
            return $"Ime={Ime}&Prezime={Prezime}&KorisnikId={KorisnikId}&PrikazUXamarinu={PrikazUXamarinu}";
        }
    }
}
