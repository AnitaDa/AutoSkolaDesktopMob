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
    public class UlogaController : BaseController<MUloga, object>
    {
        
        public UlogaController(IBaseServices<MUloga, object> baseService) : base(baseService)
        {
            
        }
        [AllowAnonymous]
        public override List<MUloga> Get([FromQuery] object search)
        {
            return base.Get(search);
        }
    }
}
