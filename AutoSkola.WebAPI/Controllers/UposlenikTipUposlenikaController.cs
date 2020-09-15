using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UposlenikTipUposlenikaController : CRUDBaseController<MUposlenikTipUposlenika, object, UTUUpsertRequest, object>
    {
        public UposlenikTipUposlenikaController(ICRUDBaseService<MUposlenikTipUposlenika, object, UTUUpsertRequest, object> iCRUDService) : base(iCRUDService)
        {
        }
    }
}
