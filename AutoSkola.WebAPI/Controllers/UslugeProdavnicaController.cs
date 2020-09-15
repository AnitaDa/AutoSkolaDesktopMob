using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UslugeProdavnicaController : CRUDBaseController<MUslugeProdavnica,object,UslugeProdavnicaUpsertRequest,object>
    {
        public UslugeProdavnicaController(ICRUDBaseService<MUslugeProdavnica, object, UslugeProdavnicaUpsertRequest, object> baseService) : base(baseService)
        {
        }
    }
}
