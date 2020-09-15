using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
   public class KorisnikUpsertRequest
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
       public string Lozinka { get; set; }
        public string StaraLozinka { get; set; }
        public string PotrvrdnaLozinka { get; set; }
        public bool? Status { get; set; }
    }
}
