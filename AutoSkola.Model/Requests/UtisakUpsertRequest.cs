using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UtisakUpsertRequest
    {
        public decimal Ocjena { get; set; }
        public int KandidatId { get; set; }
        public int UposlenikId { get; set; }
    }
}
