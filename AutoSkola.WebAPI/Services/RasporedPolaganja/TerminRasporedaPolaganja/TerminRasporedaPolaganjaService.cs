using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.RasporedPolaganja.TerminRasporedaPolaganja
{
    public class TerminRasporedaPolaganjaService:CRUDBaseService<MTerminRasporedaPolaganja,TerminRPSearchRequest, TerminRPUpsertRequest, TerminRPUpsertRequest, Database.TerminRasporedaPolaganja>
    {
        public TerminRasporedaPolaganjaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<MTerminRasporedaPolaganja> Get(TerminRPSearchRequest search)
        {
            var query = _context.TerminRasporedaPolaganja.AsQueryable();
            query = query.Where(d => d.RasporedPolaganjaId == search.RasporedPolaganjaId);
            var lista = query.Select(v => new MTerminRasporedaPolaganja {
                Id = v.Id,
                Od = v.Od+"h",
                Do = v.Do+"h",
                Kandidat =v.Kandidat.Ime+" "+v.Kandidat.Prezime,
                KandidatId=v.KandidatId
            }).ToList();
            return _mapper.Map<List<MTerminRasporedaPolaganja>>(lista);
        }
    }
}
