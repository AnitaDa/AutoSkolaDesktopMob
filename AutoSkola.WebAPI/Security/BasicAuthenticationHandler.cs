using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services.Korisnik;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IKorisniciService _korisniciService;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
           ILoggerFactory logger,
           UrlEncoder encoder,
           ISystemClock clock,
           IKorisniciService korisniciService) : base(options, logger, encoder, clock)
        {
            _korisniciService = korisniciService;
        }
#pragma warning disable CS1998
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing authorization header");

            MKorisnik korisnik = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                AuthenticateRequest request = new AuthenticateRequest()
                {
                    Username = username,
                    Password = password
                };

                korisnik = _korisniciService.Authenticate(request);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (korisnik == null)
                return AuthenticateResult.Fail("Invalid username or password");

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, korisnik.KorisnickoIme),
                new Claim(ClaimTypes.Email, korisnik.Email)
            };
            foreach(var i in korisnik.KorisnikUloga)
            {
              claims.Add(new Claim(ClaimTypes.Role, i.Uloga.Naziv));
            }
           

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            //Thread.CurrentPrincipal = principal;
            return AuthenticateResult.Success(ticket);
        }
    }
}
