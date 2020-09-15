using AutoMapper;
using AutoSkola.WebAPI.Database;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services
{
    public class CRUDBaseService<TModel, TSearch, TInsert, TUpdate, TDatabase> : BaseService<TModel, TSearch, TDatabase>, ICRUDBaseService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public CRUDBaseService(AutoSkolaContext context,IMapper mapper) : base(context, mapper) { }
        public bool Delete(int Id)
        {
            try
            {
                if (Id != 0)
                {
                    var entity = _context.Set<TDatabase>().Find(Id);
                    if (entity != null)
                    {
                        _context.Set<TDatabase>().Remove(entity);
                        _context.SaveChanges();
                        return true;
                    }
                    return false;
                }
                return false;
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            }catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                return false; 
            }
           
        }

        public virtual TModel Insert(TInsert insert)
        {
            var entity = _mapper.Map<TDatabase>(insert);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public TModel Update(int Id, TUpdate update)
        {
                     TDatabase entity = _context.Set<TDatabase>().Find(Id);
                    _context.Set<TDatabase>().Attach(entity);
                    _context.Set<TDatabase>().Update(entity);
                    _mapper.Map(update, entity);
                    _context.SaveChanges();
                    return _mapper.Map<TModel>(entity);
        }

        
    }
}
