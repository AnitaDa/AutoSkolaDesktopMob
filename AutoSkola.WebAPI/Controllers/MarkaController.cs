using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkaController : CRUDBaseController<MMarka, object, object, object>
    {
        public MarkaController(ICRUDBaseService<MMarka, object, object, object> iCRUDService) : base(iCRUDService)
        {
        }
    }
}
