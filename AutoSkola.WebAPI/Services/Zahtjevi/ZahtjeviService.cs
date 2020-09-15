using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Zahtjevi
{
    public class ZahtjeviService : CRUDBaseService<MZahtjevi, ZahtjeviSearchRequest,ZahtjeviUpsertRequest,ZahtjeviUpsertRequest, Zahtjev>
    {
        public ZahtjeviService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<MZahtjevi> Get(ZahtjeviSearchRequest search)
        {
            var query = _context.Zahtjev
             
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.LjekarskoUvjerenje.Kandidat.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.LjekarskoUvjerenje.Kandidat.Prezime.StartsWith(search.Prezime));
            }
            if(search.UslugaId!=0){
                query = query.Where(x => x.UslugaId == search.UslugaId);
            }
           
            if (search.KandidatiId !=0)
            {
                query = query.Where(x => x.LjekarskoUvjerenje.KandidatId==search.KandidatiId);
            }
            //ovaj filter vredi samo za desktop app
            if (!search.PrikazUXamarinu)
            {
                if (!search.pocetnaPrikaz)
                {
                    query = query.Where(x => x.Odobren == false);
                    query = query.Where(x => x.Odbacen == false);
                }
            }
          
            //ovaj filter se koristi samo pri kupovini usluga
            if (search.KupovinaUsluga)
            {
                query = query.Where(x => x.Odobren==search.Odobren);
            }
            if (search.Godina > 2000)
            {
                query = query.Where(x => x.DatumPodnosenjaZahtjeva.Year == search.Godina);
            }
            var list = query.Select(g => new MZahtjevi {
                Id = g.Id,
                Kandidat = g.LjekarskoUvjerenje.Kandidat.Ime + " " + g.LjekarskoUvjerenje.Kandidat.Prezime,
                Usluga = g.Usluga.Naziv,
                Kategorija = g.Usluga.Kategorija.Naziv,
                LjekarskoUvjerenjeId = g.LjekarskoUvjerenjeId,
                Odbacen=g.Odbacen,
                Odobren=g.Odobren,
                DatumPodnosenja=g.DatumPodnosenjaZahtjeva,
                UposlenikId=g.UposlenikId,  
                UslugaId=g.UslugaId,
                OpisUsluge=g.Usluga.Opis,
                Instruktor=g.Uposlenik.Ime+" "+g.Uposlenik.Prezime
            }).ToList();
          
            return _mapper.Map<List<MZahtjevi>>(list);
        }
    }
}
