using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
   public  class KorisnikUlogaUpsertRequest
    {
        public int UlogaId { get; set; }
        public int KorisnikId { get; set; }
    }
}
