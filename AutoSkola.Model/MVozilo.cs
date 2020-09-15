using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MVozilo
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string Kategorija { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KategorijaId { get; set; }
        public int ModelId { get; set; }

    }
}
