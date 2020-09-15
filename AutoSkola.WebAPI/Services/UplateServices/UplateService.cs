using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AutoSkola.WebAPI.Services.UplateServices
{
    public class UplateService : CRUDBaseService<MUplate, UplataSearchRequest,UplataUpsertRequest,UplataUpsertRequest,Uplata>
    {
        public UplateService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MUplate> Get(UplataSearchRequest search)
        {
            var query = _context.Uplata.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Kandidat.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Kandidat.Prezime.StartsWith(search.Prezime));
            }
            if (search.KandidatId!=0)
            {
                query = query.Where(x => x.KandidatId==search.KandidatId);
            }
            if (search.Godina > 2000)
            {
                query = query.Where(x => x.DatumUplate.Year == search.Godina);
            }
            if (search.DatumUplate.Date >new DateTime(2000,1,1).Date)
            {
                query = query.Where(x => x.DatumUplate == search.DatumUplate);
            }
            var list = query.Select(x => new MUplate
            {
                Id=x.Id,
                Svrha=x.Svrha,
                Iznos=x.Iznos,
                DatumUplate=x.DatumUplate,
                Kandidat=x.Kandidat.Ime+" "+x.Kandidat.Prezime,
                Slika=x.Kandidat.Slika
            }).ToList();
            return _mapper.Map<List<MUplate>>(list);
        }
        
    }
}
