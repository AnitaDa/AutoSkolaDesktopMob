using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class UposlenikTipUposlenika
    {
        public int Id { get; set; }
        public int UposlenikId { get; set; }
        public int TipUposlenikaId { get; set; }

        public virtual TipUposlenika TipUposlenika { get; set; }
        public virtual Uposlenik Uposlenik { get; set; }
    }
}
