using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Model
    {
        public Model()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int MarkaId { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual ICollection<Vozilo> Vozilo { get; set; }
    }
}
