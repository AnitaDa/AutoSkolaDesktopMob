using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class TipUposlenika
    {
        public TipUposlenika()
        {
            UposlenikTipUposlenika = new HashSet<UposlenikTipUposlenika>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<UposlenikTipUposlenika> UposlenikTipUposlenika { get; set; }
    }
}
