using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class UslugeProdavnicaUpsertRequest
    {
        public int KandidatId { get; set; }
        public DateTime Datum { get; set; }
    }
}
