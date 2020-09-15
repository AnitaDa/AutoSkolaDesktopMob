using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MPotvrda
    {
        public DateTime DatumPolaganja { get; set; }
        public string KandidatIme { get; set; }
        public int KandidatId { get; set; }
        public string Kategorija { get; set; }
        public int KategorijaId { get; set; }
        public string UposlenikIme { get; set; }
        public int UposlenikId { get; set; }
    }
}
