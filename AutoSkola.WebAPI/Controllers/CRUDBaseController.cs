using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSkola.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoSkola.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDBaseController<TModel, TSearch, TInsert, TUpdate> : BaseController<TModel, TSearch>
    {
        private readonly ICRUDBaseService<TModel, TSearch, TInsert, TUpdate> _ICRUDService;

        public CRUDBaseController(ICRUDBaseService<TModel, TSearch, TInsert, TUpdate> iCRUDService):base(iCRUDService)
        {
            _ICRUDService = iCRUDService;
        }
        [HttpPost]
        public virtual TModel Insert(TInsert insert)
        {
            return _ICRUDService.Insert(insert);
        }
        [HttpPut("{Id}")]
        public virtual TModel Update(int Id, TUpdate update)
        {
            return _ICRUDService.Update(Id, update);
        }
        [HttpDelete("{Id}")]
        public bool Delete(int Id)
        {
            return _ICRUDService.Delete(Id);
        }
    }
}