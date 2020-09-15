using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.RasporedPolaganja
{
    public class RasporedPolaganjaService:CRUDBaseService<MRasporedPolaganja, RasporedPolaganjaSearchRequest, RasporedPolaganjaUpsertRequest,object,Database.RasporedPolaganja>
    {
        public RasporedPolaganjaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
        
        public override List<MRasporedPolaganja> Get(RasporedPolaganjaSearchRequest search)
        {
            var query = _context.RasporedPolaganja.AsQueryable();
            if(search.DatumPolaganja>default(DateTime))
            query=query.Where(x => x.DatumPolaganja.Date == search.DatumPolaganja.Date);
            var lista = query.Select(v => new MRasporedPolaganja {
                Id = v.Id,
            DatumPolaganja = v.DatumPolaganja
            }).ToList();
           return _mapper.Map<List<MRasporedPolaganja>>(lista);
        }
    }
}
