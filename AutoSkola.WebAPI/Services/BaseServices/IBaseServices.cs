using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services
{
   public interface IBaseServices<TModel,TSearch>
    {
        List<TModel> Get(TSearch search);
        TModel GetById(int Id);
    }
}
