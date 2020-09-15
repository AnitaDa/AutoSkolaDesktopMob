using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Usluge
{
    public class UslugaService:CRUDBaseService<MUsluge, UslugaSearchRequest, UslugaUpsertRequest, UslugaUpsertRequest, Database.Usluga>
    {
        public UslugaService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<MUsluge> Get(UslugaSearchRequest search)
        {
            var query = _context.Usluga.AsQueryable();
            if (search.KategorijaId != 0)
            {
                query = query.Where(x => x.KategorijaId == search.KategorijaId);
            }
           
            var lista = query.Select(f => new MUsluge {
             Id=f.Id,
            Naziv=f.Naziv,
            Cijena=(int)f.Cijena,
            Opis=f.Opis,
            Kategorija=f.Kategorija.Naziv,
            KategorijaId=f.KategorijaId,
            NazivKategorija=f.Naziv+" "+f.Kategorija.Naziv
            }).ToList();
            return _mapper.Map<List<MUsluge>>(lista);
        }
    }
}
