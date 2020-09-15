using System;
using System.Collections.Generic;

using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UplataUpsertRequest
    {
     
        public int Iznos{ get; set; }
        public DateTime DatumUplate { get; set; }
        public string Svrha { get; set; }
        public int KandidatId { get; set; }
    }
}
