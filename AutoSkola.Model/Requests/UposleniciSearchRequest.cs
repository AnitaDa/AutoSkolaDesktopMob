using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UposleniciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string TipUposlenika { get; set; }
        public int KorisnikId { get; set; }
        public bool Top5 { get; set; }
        public override string ToString()
        {
            return $"Ime={Ime}&Prezime={Prezime}&TipUposlenika={TipUposlenika}&KorisnikId={KorisnikId}&Top5={Top5}";
        }
    }
}
