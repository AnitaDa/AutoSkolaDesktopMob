using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class TerminRPUpsertRequest
    {
        public int? Id { get; set; }
        public string Od { get; set; }
        public string Do { get; set; }
        public int? RasporedPolaganjaId { get; set; }
        public int KandidatId { get; set; }
        public bool Status { get; set; }
    }
}
