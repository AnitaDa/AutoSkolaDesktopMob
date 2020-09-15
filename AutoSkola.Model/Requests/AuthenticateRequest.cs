using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSkola.Model.Requests
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
