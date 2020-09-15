using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class VoziloUpsertRequest
    {
        public int? Id { get; set; }
        public int KategorijaId { get; set; }
        public string RegistarskaOznaka { get; set; }
        public byte[] Slika { get; set; }
        public int ModelId { get; set; }
        public byte[] Attachment { get; set; } = null;
        public string FileName { get; set; }
    }
}
