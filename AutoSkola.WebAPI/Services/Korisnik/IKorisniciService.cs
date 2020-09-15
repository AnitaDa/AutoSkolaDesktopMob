using AutoSkola.Model;
using AutoSkola.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Korisnik
{
    public interface IKorisniciService
    {
        List<MKorisnik> Get(KorisniciSearchRequest search);
        MKorisnik GetById(int id);
        MKorisnik Insert(KorisnikUpsertRequest request);
        MKorisnik Update(int id,KorisnikUpsertRequest request);
        MKorisnik Authenticate(AuthenticateRequest request);
    }
}
