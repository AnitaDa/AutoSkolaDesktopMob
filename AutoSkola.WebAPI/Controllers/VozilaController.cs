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
    [Authorize (Roles ="Referent")]
    [Route("api/[controller]")]
    [ApiController]
    public class VozilaController : CRUDBaseController<MVozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest>
    {
        public VozilaController(ICRUDBaseService<MVozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest> iCRUDService) : base(iCRUDService)
        {
        }
        [Authorize]
        public override List<MVozilo> Get([FromQuery] VoziloSearchRequest search)
        {
            return base.Get(search);
        }

    }
}
