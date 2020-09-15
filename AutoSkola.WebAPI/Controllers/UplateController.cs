using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Authorize(Roles = "Kandidat,Referent")]
    [Route("api/[controller]")]
    [ApiController]
    public class UplateController : CRUDBaseController<MUplate, UplataSearchRequest, UplataUpsertRequest, UplataUpsertRequest>
    {
        public UplateController(ICRUDBaseService<MUplate, UplataSearchRequest, UplataUpsertRequest, UplataUpsertRequest> iCRUDService) : base(iCRUDService)
        {
        }
       
    }
}