using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class TerminRCSearchRequest
    {
      public int KandidatId { get; set; }
        public DateTime Datum { get; set; }
        //kandidatu se prikazuju samo odvozeni casovi sa statusom true
        public bool PrikazUXamarinu { get; set; }
        public bool Teorija { get; set; }
        public bool Prakticno { get; set; }

        public override string ToString()
        {
            return $"KandidatId={KandidatId}&Datum={Datum}&PrikazUXamarinu={PrikazUXamarinu}&Teorija={Teorija}&Prakticno={Prakticno}";
        }
    }
}
