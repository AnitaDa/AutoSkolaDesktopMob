using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace AutoSkola.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class KandidatiController:CRUDBaseController<Model.MKandidat,KandidatSearchRequest, KandidatUpsertRequest, KandidatUpsertRequest>
    {
        public KandidatiController(ICRUDBaseService<Model.MKandidat,KandidatSearchRequest, KandidatUpsertRequest, KandidatUpsertRequest> services):base(services) { }
        [AllowAnonymous]
        public override MKandidat Insert(KandidatUpsertRequest insert)
        {
            return base.Insert(insert);
        }
    }
    
}