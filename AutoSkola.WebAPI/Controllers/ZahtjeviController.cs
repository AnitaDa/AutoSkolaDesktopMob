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
   
    public class ZahtjeviController : CRUDBaseController<MZahtjevi, ZahtjeviSearchRequest,ZahtjeviUpsertRequest,ZahtjeviUpsertRequest>
    {
        public ZahtjeviController(ICRUDBaseService<MZahtjevi, ZahtjeviSearchRequest,ZahtjeviUpsertRequest,ZahtjeviUpsertRequest> baseService) : base(baseService)
        {
        }
        [Authorize(Roles ="Kandidat")]
        public override MZahtjevi Insert(ZahtjeviUpsertRequest insert)
        {
            return base.Insert(insert);
        }
        [Authorize (Roles = "Referent,Kandidat")]
        public override List<MZahtjevi> Get([FromQuery] ZahtjeviSearchRequest search)
        {
            return base.Get(search);
        }
    }
}