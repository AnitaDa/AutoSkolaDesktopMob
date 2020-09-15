using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UslugaUpsertRequest
    {
        public int? Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public int KategorijaId { get; set; }
    }
}
