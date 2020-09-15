using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model
{
    public class MUplate
    {
        public int Id { get; set; }
        public float Iznos { get; set; }
        public string Svrha { get; set; }
        public DateTime DatumUplate { get; set; }
        public string Kandidat { get; set; }
        public byte[] Slika { get; set; }
    }
}
