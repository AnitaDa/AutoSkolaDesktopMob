using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AutoSkola.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public  class BaseController<TModel,TSearch> : ControllerBase
    {
        private readonly IBaseServices<TModel,TSearch> _baseService;

        public BaseController(IBaseServices<TModel, TSearch> baseService)
        {
            _baseService = baseService;
        }
        [HttpGet]
      
        public virtual List<TModel> Get([FromQuery]TSearch search)
        {
            return _baseService.Get(search);
        }
        [HttpGet("{Id}")]
        public virtual TModel GetById(int Id)
        {
            return _baseService.GetById(Id);
        }
    }
}