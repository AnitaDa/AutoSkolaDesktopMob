using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipUposlenikaController : BaseController<MTipUposlenika, object>
    {
        public TipUposlenikaController(IBaseServices<MTipUposlenika, object> baseService) : base(baseService)
        {
        }
        [AllowAnonymous]
        public override List<MTipUposlenika> Get([FromQuery] object search)
        {
            return base.Get(search);
        }
    }
}
