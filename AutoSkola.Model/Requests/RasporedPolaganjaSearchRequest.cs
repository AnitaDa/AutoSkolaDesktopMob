using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class RasporedPolaganjaSearchRequest
    {
        public DateTime DatumPolaganja { get; set; }
        public override string ToString()
        {
            return $"DatumPolaganja={DatumPolaganja}";
        }
    }
}
