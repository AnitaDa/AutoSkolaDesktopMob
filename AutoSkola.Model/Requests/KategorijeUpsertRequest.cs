using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class KategorijeUpsertRequest
    {
        public int? Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
