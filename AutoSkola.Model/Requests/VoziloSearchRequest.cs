using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class VoziloSearchRequest
    {
        public int MarkaId { get; set; }
        public override string ToString()
        {
            return $"MarkaId={MarkaId}";
        }
    }
}
