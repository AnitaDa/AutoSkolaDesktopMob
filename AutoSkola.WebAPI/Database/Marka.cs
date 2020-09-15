using Microsoft.AspNetCore.Mvc.Abstractions;
using System;
using System.Collections.Generic;

namespace AutoSkola.WebAPI.Database
{
    public partial class Marka
    {
        public Marka()
        {
            Model = new HashSet<Model>();
        }
        public int Id { get; set; }

        public string Naziv { get; set; }
        public virtual ICollection<Model> Model { get; set; }
    }
}
