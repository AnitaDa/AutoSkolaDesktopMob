using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services.Korisnik;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace eProdaja.WebAPI.Controllers

{

    [Route("api/[controller]")]
    [ApiController]

    public class KorisniciController : ControllerBase

    {

        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)

        {
            _service = service;
        }
        [AllowAnonymous]
        [HttpGet]
        public List<MKorisnik> Get([FromQuery] KorisniciSearchRequest request)

        {
            return _service.Get(request);
        }
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public MKorisnik Authenticate([FromBody] AuthenticateRequest request)
        {
            return  _service.Authenticate(request);
        }
        [HttpPost]
        [AllowAnonymous]
        public MKorisnik Insert(KorisnikUpsertRequest request)

        {
            return _service.Insert(request);
        }


        [HttpPut("{id}")]

        public MKorisnik Update(int id, [FromBody] KorisnikUpsertRequest request)

        {
            return _service.Update(id, request);
        }



        [HttpGet("{id}")]

        public MKorisnik GetById(int id)

        {
            return _service.GetById(id);
        }

    }

}