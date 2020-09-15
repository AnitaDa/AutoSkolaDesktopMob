using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AutoSkola.Model
{
    public class MUposlenik
    {
        public int Id { get; set; }
       public string ImePrezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public decimal ProsecnaOcjena { get; set; }
        public byte[] Slika { get; set; }
        public string TipUposlenika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

    }
}
