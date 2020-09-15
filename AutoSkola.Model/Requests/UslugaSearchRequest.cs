using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UslugaSearchRequest
    {
        public int KategorijaId { get; set; }
        public override string ToString()
        {
            return $"KategorijaId={KategorijaId}";
        }
    }
}
