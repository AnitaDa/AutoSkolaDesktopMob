using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UplataSearchRequest
    {
        public int KandidatId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina { get; set; } 
        public DateTime DatumUplate { get; set; }
        public override string ToString()
        {
            return $"Ime={Ime}&Prezime={Prezime}&Godina={Godina}&KandidatId={KandidatId}&DatumUplate={DatumUplate}";
        }
    }
}
