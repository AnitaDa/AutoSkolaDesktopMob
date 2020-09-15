using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.RasporedCasovaService.TerminRasporeda
{
    public class TerminRasporedaCasovaService : CRUDBaseService<MTerminRasporedaCasova, TerminRCSearchRequest, TeminRCUpsertRequest, TeminRCUpsertRequest, TerminRasporedCasova>
    {
        public TerminRasporedaCasovaService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<MTerminRasporedaCasova> Get(TerminRCSearchRequest search)
        {
            var query = _context.TerminRasporedCasova.AsQueryable();
            if (search.KandidatId != 0)
            {
                query = query.Where(d => d.RasporedCasova.KandidatId == search.KandidatId);
            }
            //ukoliko je datum 1/1/2000 prikazuje sve termine
            if (search.Datum > new DateTime(2000, 1, 1))
            {
                query = query.Where(d => d.Datum == search.Datum);
            }
            //ako se prikazuje kandidatu, onda treba ispisati samo odvozene casove sa statusom true
            if (search.PrikazUXamarinu)
            {
                query = query.Where(d => d.Status == true);
                if (search.Teorija)
                    query = query.Where(d => d.Teorija == true);
                if (search.Prakticno)
                    query = query.Where(d => d.Prakticno == true);
            }
            else
            {
                //prikazuje sve termine koji nisu odrzani
                query = query.Where(x => x.Status == false);
            }
           
            var list =query.Select(f => new MTerminRasporedaCasova {
                Id=f.Id,
                Datum = f.Datum,
                Od=f.Od+"h",
                Do=f.Do+"h",
                Vozilo=f.Vozilo.RegistarskaOznaka,
                KandidatId=f.RasporedCasova.KandidatId,
                VoziloId=f.VoziloId,
                UposlenikId=f.UposlenikId,
                RasporedCasovaId=f.RasporedCasovaId,
                Teorija=f.Teorija,
                Prakticno=f.Prakticno
            }).ToList();
            return _mapper.Map<List<MTerminRasporedaCasova>>(list);
        }
    }
}
