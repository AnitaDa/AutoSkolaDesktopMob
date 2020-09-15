using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikUlogaController : CRUDBaseController<MKorisnikUloga, KorisnikUlogaSearchRequest, KorisnikUlogaUpsertRequest, object>
    {
        public KorisnikUlogaController(ICRUDBaseService<MKorisnikUloga, KorisnikUlogaSearchRequest, KorisnikUlogaUpsertRequest, object> iCRUDService) : base(iCRUDService)
        {
        }
        [AllowAnonymous]
        public override MKorisnikUloga Insert(KorisnikUlogaUpsertRequest insert)
        {
            return base.Insert(insert);
        }
    }
}
