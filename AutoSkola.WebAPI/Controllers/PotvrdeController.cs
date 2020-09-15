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
    public class PotvrdeController : CRUDBaseController<MPotvrda, PotvrdaSearchRequest, PotvrdaUpsertRequest, object>
    {
        public PotvrdeController(ICRUDBaseService<MPotvrda, PotvrdaSearchRequest, PotvrdaUpsertRequest, object> iCRUDService) : base(iCRUDService)
        {
        } 
    }
}
