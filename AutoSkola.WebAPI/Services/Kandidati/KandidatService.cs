using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Kandidati
{
    public class KandidatService : CRUDBaseService<MKandidat, KandidatSearchRequest, KandidatUpsertRequest, KandidatUpsertRequest, Kandidat>
    {
        public KandidatService(AutoSkolaContext context, IMapper mapper) : base(context, mapper)
        {
        }
       
        public override List<MKandidat> Get(KandidatSearchRequest search)
        {
            var query = _context.Kandidat.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x=>x.Prezime.StartsWith(search.Prezime));
            }
            //potrebno u xamarinu prilikom pretrage termina za odredjenog kandidata
            if (search.KorisnikId!=0)
            {
                query = query.Where(x => x.KorisnikId==search.KorisnikId);
            }
            //prikazuje samo aktivne kandidate tj. one kojima je zahtev prihvacen ukoliko se prikazuje u desktop aplikaciji
            if (!search.PrikazUXamarinu)
            {
                query = query.Where(x => x.Status == true);
            }
            
            var list = query.Select(x => new MKandidat
            {
                Id = x.Id,
                ImePrezime = x.Ime+" "+x.Prezime,
                Slika=x.Slika
            }).ToList();
            return _mapper.Map <List<MKandidat>> (list);
        }

        public override MKandidat GetById(int Id)
        {
            var result = _context.Zahtjev.Where(s => s.LjekarskoUvjerenje.KandidatId == Id).Select(x => new MKandidat
            {
                Id = x.LjekarskoUvjerenje.KandidatId,
                ImePrezime = x.LjekarskoUvjerenje.Kandidat.Ime + " " + x.LjekarskoUvjerenje.Kandidat.Prezime,
                DatumRodjenja = x.LjekarskoUvjerenje.Kandidat.DatumRodjenja,
                DatumIzdavanja = x.LjekarskoUvjerenje.DatumIzdavanja,
                DatumVazenja = x.LjekarskoUvjerenje.DatumVazenja,
                Usluga = x.Usluga.Opis,
                Slika = x.LjekarskoUvjerenje.Kandidat.Slika,
                Ime = x.LjekarskoUvjerenje.Kandidat.Ime,
                Prezime = x.LjekarskoUvjerenje.Kandidat.Prezime,
                KorisnikId = x.LjekarskoUvjerenje.Kandidat.KorisnikId,
                Status = x.LjekarskoUvjerenje.Kandidat.Status,
                OdabraniInstruktor = _context.Zahtjev.FirstOrDefault(c => c.LjekarskoUvjerenjeId == x.LjekarskoUvjerenjeId).Uposlenik.Ime + " " + _context.Zahtjev.FirstOrDefault(c => c.LjekarskoUvjerenjeId == x.LjekarskoUvjerenjeId).Uposlenik.Prezime
            }).FirstOrDefault();
            return _mapper.Map<MKandidat>(result);
        }

    }
}
