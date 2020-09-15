using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class OdabraneUslugeUspertRequest
    {
        public int Id { get; set; }
        public int UslugaId { get; set; }
        public int UslugeProdavnicaId { get; set; }
    }
}
