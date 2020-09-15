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
    [AllowAnonymous]
    public class UposleniciController : CRUDBaseController<MUposlenik, UposleniciSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest>
    {
        public UposleniciController(ICRUDBaseService<MUposlenik, UposleniciSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest> iCRUDService) : base(iCRUDService)
        {

        }         
    }
}
