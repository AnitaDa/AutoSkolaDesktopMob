using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class RasporedCasova
    {
        public RasporedCasova()
        {
            TerminRasporedCasova = new HashSet<TerminRasporedCasova>();
        }

        public int Id { get; set; }
        public int KandidatId { get; set; }

        public virtual Kandidat Kandidat { get; set; }
        public virtual ICollection<TerminRasporedCasova> TerminRasporedCasova { get; set; }
    }
}
