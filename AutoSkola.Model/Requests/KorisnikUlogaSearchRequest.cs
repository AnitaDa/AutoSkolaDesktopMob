using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class KorisnikUlogaSearchRequest
    {
        public int KorisnikId { get; set; }
        public override string ToString()
        {
            return $"KorisnikId={KorisnikId}";
        }
    }
}
