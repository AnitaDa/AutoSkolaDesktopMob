using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services
{
    public interface ICRUDBaseService<TModel,TSearch,TInsert,TUpdate>:IBaseServices<TModel,TSearch>
    {

        TModel Update(int Id,TUpdate update);
        TModel Insert(TInsert insert);
        bool Delete(int Id);
    }
}
