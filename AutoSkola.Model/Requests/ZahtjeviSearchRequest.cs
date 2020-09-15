using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class ZahtjeviSearchRequest
    {
        public int UslugaId { get; set; }
        public bool Odobren { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; }
        public int KandidatiId { get; set; }
        public bool PrikazUXamarinu { get; set; }
        public bool KupovinaUsluga { get; set; }
        public bool pocetnaPrikaz { get; set; }
        public override string ToString()
        {
            return $"Ime={Ime}&Prezime={Prezime}&UslugaId={UslugaId}&Godina={Godina}&KandidatiId={KandidatiId}&PrikazUXamarinu={PrikazUXamarinu}&Odobren={Odobren}&KupovinaUsluga={KupovinaUsluga}&pocetnaPrikaz={pocetnaPrikaz}";
        }
    }
}
