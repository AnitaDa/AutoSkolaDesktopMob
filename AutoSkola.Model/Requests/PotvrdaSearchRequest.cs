using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class PotvrdaSearchRequest
    {
        public DateTime DatumPolaganja { get; set; }
        public int KategorijaId { get; set; }
        public override string ToString()
        {
            return $"DatumPolaganja={DatumPolaganja}&KategorijaId={KategorijaId}";
        }
    }
}
