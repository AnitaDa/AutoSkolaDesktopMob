using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
       
        public override string ToString()
        {
            return $"Id={Id}&KorisnickoIme={KorisnickoIme}";
        }
    }
}
