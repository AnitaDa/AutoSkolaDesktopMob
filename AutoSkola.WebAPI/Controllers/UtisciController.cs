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
    public class UtisciController : CRUDBaseController<MUtisak, UtisakSearchRequest, UtisakUpsertRequest, object>
    {
        public UtisciController(ICRUDBaseService<MUtisak, UtisakSearchRequest, UtisakUpsertRequest, object> iCRUDService) : base(iCRUDService)
        {
        }
    }
}
