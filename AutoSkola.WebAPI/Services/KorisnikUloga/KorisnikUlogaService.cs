using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.KorisnikUloga
{
    public class KorisnikUlogaService : CRUDBaseService<MKorisnikUloga, KorisnikUlogaSearchRequest, KorisnikUlogaUpsertRequest, object, Database.KorisnikUloga>
    {
        public KorisnikUlogaService(AutoSkolaContext context,IMapper mapper):base(context,mapper)
        {

        }
        public override List<MKorisnikUloga> Get(KorisnikUlogaSearchRequest search)
        {
            var query = _context.KorisnikUloga.AsQueryable();
            if (search.KorisnikId != 0)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikId);
            }
            var korisnici = query.Select(x => new MKorisnikUloga { 
                Id=x.Id,
                KorisnikId = x.KorisnikId,
               UlogaId=x.UlogaId,
               UlogaNaziv=x.Uloga.Naziv
            }).ToList();
            return _mapper.Map<List<MKorisnikUloga>>(korisnici);
        }
    }
}
