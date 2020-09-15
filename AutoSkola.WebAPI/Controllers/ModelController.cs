using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Internal;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : CRUDBaseController<MModel, object, object, object>
    {
        public ModelController(ICRUDBaseService<MModel, object, object, object> iCRUDService) : base(iCRUDService)
        {
        }
    }
}
