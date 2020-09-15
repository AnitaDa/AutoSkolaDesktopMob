using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoSkola.Model;
using AutoSkola.WebAPI.Services;
using AutoSkola.Model.Requests;
using Microsoft.AspNetCore.Authorization;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminRasporedaCasovaController : CRUDBaseController<MTerminRasporedaCasova, TerminRCSearchRequest, TeminRCUpsertRequest, TeminRCUpsertRequest>
    {
        public TerminRasporedaCasovaController(ICRUDBaseService<MTerminRasporedaCasova, TerminRCSearchRequest, TeminRCUpsertRequest, TeminRCUpsertRequest> iCRUDService) : base(iCRUDService)
        {
        }
        [Authorize]
        public override List<MTerminRasporedaCasova> Get([FromQuery] TerminRCSearchRequest search)
        {
            return base.Get(search);
        }
    }
}