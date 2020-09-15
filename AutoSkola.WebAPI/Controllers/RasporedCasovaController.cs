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
    public class RasporedCasovaController : CRUDBaseController<MRasporedCasova, RasporedSearchRequest,RasporedCasovaUpsertRequest,object>
    {
        public RasporedCasovaController(ICRUDBaseService<MRasporedCasova, RasporedSearchRequest, RasporedCasovaUpsertRequest, object> baseService) : base(baseService)
        {
        }
        [Authorize]
        public override List<MRasporedCasova> Get([FromQuery] RasporedSearchRequest search)
        {
            return base.Get(search);
        }
    }
}