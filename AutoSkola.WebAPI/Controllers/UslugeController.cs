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
    public class UslugeController : CRUDBaseController<MUsluge, UslugaSearchRequest, UslugaUpsertRequest, UslugaUpsertRequest>
    {
        public UslugeController(ICRUDBaseService<MUsluge, UslugaSearchRequest, UslugaUpsertRequest, UslugaUpsertRequest> iCRUDService) : base(iCRUDService)
        {
        }
        
    }
}
