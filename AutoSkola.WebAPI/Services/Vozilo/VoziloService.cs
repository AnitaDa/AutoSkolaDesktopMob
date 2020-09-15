using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Vozilo
{
    public class VoziloService:CRUDBaseService<MVozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest, Database.Vozilo>
    {
        public VoziloService(Database.AutoSkolaContext context,IMapper mapper):base(context,mapper)
        {
        }
        public override List<MVozilo> Get(VoziloSearchRequest search)
        {
            var query = _context.Vozilo.AsQueryable();
            if (search.MarkaId != 0)
            {
                query = query.Where(x => x.Model.MarkaId == search.MarkaId);
            }
            var list=query.Select(f => new MVozilo
             {
                 Id = f.Id,
                 Kategorija = f.Kategorija.Naziv,
                 Model = f.Model.Naziv,
                 RegistarskaOznaka = f.RegistarskaOznaka,
                 Slika = f.Slika,
                 Marka=f.Model.Marka.Naziv
             }).ToList();
            return _mapper.Map<List<MVozilo>>(list);
        }
        public override MVozilo GetById(int Id)
        {
            var vozilo = _context.Vozilo.Where(x => x.Id == Id).Select(v => new MVozilo {
                Slika = v.Slika,
                Kategorija = v.Kategorija.Naziv,
                RegistarskaOznaka = v.RegistarskaOznaka,
                Marka = v.Model.Marka.Naziv,
                Model = v.Model.Naziv,
                ModelId = v.ModelId,
                KategorijaId = v.KategorijaId
            }).FirstOrDefault();
            return _mapper.Map<MVozilo>(vozilo);
        }
 
       public override MVozilo Insert(VoziloUpsertRequest upsert)
        {
            var entity = _mapper.Map<Database.Vozilo>(upsert);

            _context.Set<Database.Vozilo>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<MVozilo>(entity);
        }
    }
}
