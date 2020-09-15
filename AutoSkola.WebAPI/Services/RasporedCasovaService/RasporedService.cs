using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using AutoSkola.WebAPI.Services.RasporedCasovaService.TerminRasporeda;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.RasporedCasovaService
{
    public class RasporedService :CRUDBaseService<MRasporedCasova,RasporedSearchRequest,RasporedCasovaUpsertRequest,object,Database.RasporedCasova>
    {
        public RasporedService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<MRasporedCasova> Get(RasporedSearchRequest search)
        {
            var query = _context.RasporedCasova.AsQueryable();
            if (search.KandidatId != 0)
            {
                query = query.Where(d => d.KandidatId == search.KandidatId);
            }
            var list = query.Select(g => new MRasporedCasova {
            Id=g.Id,
            KandidatId=g.KandidatId
            }).ToList();
            return _mapper.Map<List<MRasporedCasova>>(list);
        }
    }
}
