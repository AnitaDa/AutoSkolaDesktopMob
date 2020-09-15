using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
   public class TerminRPSearchRequest
    {
        public int RasporedPolaganjaId { get; set; }
        public override string ToString()
        {
            return $"RasporedPolaganjaId={RasporedPolaganjaId}";
        }
    }
}
