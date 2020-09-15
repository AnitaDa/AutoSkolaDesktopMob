using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class RasporedPolaganja
    {
        public RasporedPolaganja()
        {
            TerminRasporedaPolaganja = new HashSet<TerminRasporedaPolaganja>();
        }

        public int Id { get; set; }
        public DateTime DatumPolaganja { get; set; }

        public virtual ICollection<TerminRasporedaPolaganja> TerminRasporedaPolaganja { get; set; }
    }
}
