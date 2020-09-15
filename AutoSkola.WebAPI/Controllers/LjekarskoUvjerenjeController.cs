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
    public class LjekarskoUvjerenjeController : CRUDBaseController<MLjekarskoUvjerenje, object, object, object>
    {
        public LjekarskoUvjerenjeController(ICRUDBaseService<MLjekarskoUvjerenje, object, object, object> iCRUDService) : base(iCRUDService)
        {
        }
    }
}
