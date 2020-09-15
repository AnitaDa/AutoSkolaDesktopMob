using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Potvrde
{
    public class PotvrdeService:CRUDBaseService<MPotvrda,PotvrdaSearchRequest, PotvrdaUpsertRequest, object,Database.Potvrda>
    {
     
        public PotvrdeService(AutoSkolaContext context,IMapper mapper):base(context,mapper)
        {

        }
        public override List<MPotvrda> Get(PotvrdaSearchRequest search)
        {
            var query = _context.Potvrda.AsQueryable();

           
                if (search.DatumPolaganja > new DateTime(2000,1,1))
                {
                    query = query.Where(f => f.DatumPolaganja == search.DatumPolaganja);
                }

            if (search.KategorijaId != 0)
            {
                query = query.Where(f => f.KategorijaId == search.KategorijaId);
            }
            var lista = query.Select(g => new MPotvrda {
                DatumPolaganja=g.DatumPolaganja,
                KandidatId=g.KandidatId,
                KandidatIme=g.Kandidat.Ime+" "+g.Kandidat.Prezime,
                Kategorija=g.Kategorija.Naziv,
                KategorijaId=g.KategorijaId,
                UposlenikId=g.UposlenikId,
                UposlenikIme=g.Uposlenik.Ime+" "+g.Uposlenik.Prezime

            }).ToList();
            return _mapper.Map<List<MPotvrda>>(lista);
        }
    }
}
