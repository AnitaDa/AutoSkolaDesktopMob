using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MUsluge
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public string Opis { get; set; }
        public string Kategorija { get; set; }
        public int KategorijaId { get; set; }
        public string NazivKategorija { get; set; }
    }
}
