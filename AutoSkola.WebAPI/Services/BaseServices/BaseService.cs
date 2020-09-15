using AutoMapper;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services
{
  
    public class BaseService<TModel, TSearch,TDatabase> : IBaseServices<TModel, TSearch> where TDatabase:class
    {
        protected readonly AutoSkolaContext _context;
        protected readonly IMapper _mapper; 
        public BaseService(AutoSkolaContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual  TModel GetById(int Id)
        {
            var entity = _context.Set<TDatabase>().Find(Id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
