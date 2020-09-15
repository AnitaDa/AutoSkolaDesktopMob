using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Services.Uposlenici
{
    public class UposleniciService:CRUDBaseService<MUposlenik, UposleniciSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest, Database.Uposlenik>
    {
        public UposleniciService(AutoSkolaContext context,IMapper mapper) : base(context, mapper)
        {

        }
        public override List<MUposlenik> Get(UposleniciSearchRequest search)
        {
           
                var query = _context.UposlenikTipUposlenika.AsQueryable();
                if (!string.IsNullOrWhiteSpace(search?.Ime))
                {
                    query = query.Where(f => f.Uposlenik.Ime == search.Ime);
                }
                if (!string.IsNullOrWhiteSpace(search?.Prezime))
                {
                    query = query.Where(f => f.Uposlenik.Prezime == search.Prezime);
                }
                if (!string.IsNullOrWhiteSpace(search?.TipUposlenika))
                {
                    query = query.Where(f => f.TipUposlenika.Naziv == search.TipUposlenika);
                }
                if (search.KorisnikId != 0)
                {
                    query = query.Where(f => f.Uposlenik.KorisnikId == search.KorisnikId);
                }
                var listaUposlenika = query.Select(v => new MUposlenik
                {
                    Id = v.UposlenikId,
                    ImePrezime = v.Uposlenik.Ime + " " + v.Uposlenik.Prezime,
                    Slika = v.Uposlenik.Slika,
                    DatumRodjenja = v.Uposlenik.DatumRodjenja,
                }).ToList();
                         
            return _mapper.Map<List<MUposlenik>>(listaUposlenika);
        }
        public override MUposlenik GetById(int Id)
        {
            decimal prosek;
            var utisci = _context.Utisak.Where(x => x.UposlenikId == Id).ToList();
            if (utisci.Count>0)
            {
                 prosek = _context.Utisak.Where(x => x.UposlenikId == Id).Average(x => x.Ocjena);
            }
            else
            {
                prosek = 0;
            }
            var uposlenik = _context.UposlenikTipUposlenika.Where(f => f.UposlenikId == Id).Select(g => new MUposlenik {
                Id = g.Uposlenik.Id,
                ImePrezime = g.Uposlenik.Ime + " " + g.Uposlenik.Prezime,
                DatumRodjenja = g.Uposlenik.DatumRodjenja,
                Slika = g.Uposlenik.Slika,
                TipUposlenika = g.TipUposlenika.Naziv,
                Ime = g.Uposlenik.Ime,
                Prezime = g.Uposlenik.Prezime,
                ProsecnaOcjena = Math.Round(prosek,2)
            }).FirstOrDefault();
            return _mapper.Map<MUposlenik>(uposlenik);
        }
    }
}
